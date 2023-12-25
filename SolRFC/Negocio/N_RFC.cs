using Datos;
using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_RFC
    {

       

        public string inicialP(string paterno)
        {
            string dosLetras, palabra,letra2;
            if (paterno != "X") //Invertir el valor de la variable booleana IsNullOrWhiteSpace
            {
                string letra1 = paterno.Substring(0, 1);

                palabra = paterno.ToLower();
                letra2 = "X";
                for(int i = 1; i < palabra.Length - 1; i++) //string elemento in lista
                {
                    char caracter = palabra[i];

                    // Verifica si el carácter es una vocal
                    if ("aeiou".Contains(caracter))
                    {
                        letra2 = caracter.ToString();
                        break;
                    }
                }

                //string letra2 = paterno.Substring(1, 1);

                if (letra1 == "ñ" || letra1 == "Ñ")
                {
                    letra1 = "X";
                }
                if (letra2 == "ñ" || letra2 == "Ñ")
                {
                    letra2 = "X";
                }
                dosLetras = letra1 + letra2;
            }
            else 
            {
                dosLetras = "X";
            }
            
            //dosLetras = letra1 + letra2;
            return dosLetras.ToUpper();
        }

        public string tomar2M(string materno) 
        {
            string dosLetras;
            
            string letra1 = materno.Substring(0, 1);
            string letra2 = materno.Substring(1, 1);

                if (letra1 == "ñ" || letra1 == "Ñ")
                {
                    letra1 = "X";
                }
                if (letra2 == "ñ" || letra2 == "Ñ")
                {
                    letra2 = "X";
                }
                dosLetras = letra1 + letra2;
           
            //dosLetras = letra1 + letra2;
            return dosLetras.ToUpper();
        }

        public string inicialM(string materno)
        {
            string letra;
            if (materno != "X") 
            {
                letra = materno.Substring(0, 1);
                if (letra == "ñ" || letra == "Ñ")
                {
                    letra = "X";
                }
            }
            else
            {
                letra= "X";
            }
               
            //string dosLetras = letra;
            return letra.ToUpper();
        }

        private string inicialN(string nombre)
        {
            string[] palabras = nombre.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string clave;
            if (palabras.Length >= 2)
            {
                if (Aplican(palabras[0]))
                {
                    //Console.WriteLine("No Aplica");
                    clave = palabras[1];
                }
                else
                {
                    //Console.WriteLine("Aplica");
                    clave = palabras[0];

                }
                //Console.WriteLine(clave);
            }
            else
            {
                //Console.WriteLine(nombre); 
                clave = nombre;
            }
            //Console.WriteLine(clave);
            clave = clave.Substring(0,1);
            return clave.ToUpper();
        }

        public static bool Aplican(string palabra)
        {
            // Convertimos la palabra y los elementos del arreglo a minúsculas para hacer la comparación no sensible a mayúsculas.
            string palabraMinuscula = palabra.ToLower();

            string[] lista = new string[] { "Maria", "MA.", "MA", "JOSE", "J.", "J" };

            bool valor = true;
            foreach (string elemento in lista)
            {
                valor = false;
                if (elemento.ToLower() == palabraMinuscula)
                {
                    valor= true;
                    break;
                }
            }
            //valor = false;
            return valor;
        }

        public void Agregar(E_RFC rfc)
        {
            string paterno, materno, nombre, letras;
            
            if (string.IsNullOrWhiteSpace(rfc.apellidoPaterno))
            {
                rfc.apellidoPaterno = "X";
                paterno = inicialP(rfc.apellidoPaterno);
                materno = tomar2M(rfc.apellidoMaterno);
                nombre = inicialN(rfc.nombre);
                letras =  materno+paterno+ nombre;
            }
            else {
                paterno = inicialP(rfc.apellidoPaterno);
                if (string.IsNullOrWhiteSpace(rfc.apellidoMaterno))
                {
                    rfc.apellidoMaterno = "X";
                    materno = "X";
                    materno = inicialM(rfc.apellidoMaterno);
                }
                else 
                {
                    materno = inicialM(rfc.apellidoMaterno);
                }
                
                nombre = inicialN(rfc.nombre);
                letras = paterno + materno + nombre;
            }
            //nombre = inicialN(rfc.nombre);
            //letras = paterno + materno + nombre;

            letras.ToUpper();
            //string palabraMinuscula = letras.ToLower();
            List<string> lista = new List<string> {"BUEI","CACA","CAGA","CAKA","COGE","COJE","COJO","FETO","JOTO",
            "KACO","KAGO","KOJO","KULO","MAMO","MEAS","MION","MULA","PEDO","PUTA","QULO","BUEY","CACO",
            "CAGO","CAKO","COJA","COJI","CULO","GUEY","KACA","KAGA","KOGE","KAKA","MAME","MEAR","MEON",
            "MOCO","PEDA","PENE","PUTO","RATA"};

            //bool salir = false;

            foreach (string elemento in lista)
            {
                //Console.WriteLine(elemento);

                // Condición para salir del bucle
                if (elemento == letras)
                {
                    letras = letras.Substring(0, 3) + "X";
                    //salir = true;
                    break;  // Sale del bucle
                }
            }
            string fecha = rfc.fechaNacimiento.ToString("yy-MM-dd");

            string digitos = "";

            foreach (char caracter in fecha)
            {
                if (char.IsDigit(caracter))
                {
                    digitos += caracter;
                }
            }

            rfc.RFC = letras.ToUpper()+digitos;
            //rfc.RFC = letras;
            D_RFC datos = new D_RFC();
            datos.Agregar(rfc);
        }

        public List<E_RFC> ObtenerTodos()
        {
            D_RFC datos = new D_RFC();
            return datos.ObtenerTodos();
        }
        public void Eliminar(int idRFC)
        {
            D_RFC datos = new D_RFC();
            datos.Eliminar(idRFC);
        }

        public E_RFC obtenerRFCPorID(int idRFC)
        {
            D_RFC datos = new D_RFC();
            return datos.obtenerRFCPorId(idRFC);
            //int contador = datos;
        }

        public void Editar(E_RFC rfc)
        {
            D_RFC datos = new D_RFC();
            datos.Editar(rfc);
        }

        public List<E_RFC> BuscarUsuario(string texto)
        {
            D_RFC datos = new D_RFC();
            return datos.Buscar(texto);
        }
    }
}
