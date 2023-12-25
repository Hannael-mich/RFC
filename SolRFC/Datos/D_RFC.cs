using Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    
    public class D_RFC
    {
        protected string CadenaConexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        static int contador = 0;
        public void Agregar (E_RFC rfc)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("agregaRFC", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", rfc.nombre);
                comando.Parameters.AddWithValue("@apellidoPaterno", rfc.apellidoPaterno);
                comando.Parameters.AddWithValue("@apellidoMaterno", rfc.apellidoMaterno);
                comando.Parameters.AddWithValue("@fechaNacimiento", rfc.fechaNacimiento);


                D_RFC datos = new D_RFC();

                comando.Parameters.AddWithValue("@RFC", rfc.RFC);
                

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<E_RFC> ObtenerTodos() 
        {
            //int contador=0;
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            List<E_RFC> lista = new List<E_RFC>();
            try
            {
                conexion.Open();
                //string query = "select ID, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento FROM RFC";
                SqlCommand comando = new SqlCommand("obtenerRFC", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    E_RFC rfc = new E_RFC();

                    rfc.ID = Convert.ToInt32(reader["ID"]);
                    rfc.nombre = reader["nombre"].ToString();
                    rfc.apellidoPaterno = reader["apellidoPaterno"].ToString();
                    rfc.apellidoMaterno = reader["apellidoMaterno"].ToString();
                    rfc.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    rfc.RFC = reader["RFC"].ToString();


                    contador += contador;
                    rfc.contador = contador;
                    lista.Add(rfc);
                    
                    
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Eliminar(int idRFC)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("eliminarRFC", conexion);
                comando.Parameters.AddWithValue("@ID", idRFC);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_RFC obtenerRFCPorId(int idRFC)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            //Creando un objeto de la clase empleado
            E_RFC obj = new E_RFC();
            try
            {
                conexion.Open();
                
                SqlCommand comando = new SqlCommand("obtenerRFCPorId", conexion);
                comando.Parameters.AddWithValue("@ID", idRFC);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    //Asignamos sus propiedades 
                    obj.ID = Convert.ToInt32(reader["ID"]);//Convierte el tipo object a int
                    obj.nombre = reader["nombre"].ToString();//Convierte el tipo object a string 
                    obj.apellidoPaterno = reader["apellidoPaterno"].ToString();//Convierte el tipo object a string 
                    obj.apellidoMaterno = reader["apellidoMaterno"].ToString();//Convierte el tipo object a string 
                    obj.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);//Convierte el tipo object a DateTime    
                    //obj.RFC = reader["RFC"].ToString();

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Editar(E_RFC rfc)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("editarRFCPorId", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", rfc.nombre);

                if (string.IsNullOrEmpty(rfc.apellidoPaterno)){ 
                    rfc.apellidoPaterno = " ";
                }

                if (string.IsNullOrEmpty(rfc.apellidoPaterno)){ 
                    rfc.apellidoMaterno = " ";
                }
                comando.Parameters.AddWithValue("@apellidoPaterno", rfc.apellidoPaterno);
                comando.Parameters.AddWithValue("@apellidoMaterno", rfc.apellidoMaterno);
                comando.Parameters.AddWithValue("@fechaNacimiento", rfc.fechaNacimiento);
                //comando.Parameters.AddWithValue("@RFC", rfc.RFC);

                //string paterno = inicialP(rfc.apellidoPaterno);
                //string materno = inicialM(rfc.apellidoMaterno);
                //string nombre = inicialN(rfc.nombre);
                //string letras = paterno + materno + nombre;

                string paterno, materno, nombre, letras;

                if (string.IsNullOrWhiteSpace(rfc.apellidoPaterno))
                {
                    rfc.apellidoPaterno = "X";
                    paterno = inicialP(rfc.apellidoPaterno);
                    materno = tomar2M(rfc.apellidoMaterno);
                    nombre = inicialN(rfc.nombre);
                    letras = materno + paterno + nombre;
                }
                else
                {
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

                rfc.RFC = letras.ToUpper() + digitos;
                //rfc.RFC = letras;
                //D_RFC datos = new D_RFC();
                //datos.Agregar(rfc);
                comando.Parameters.AddWithValue("@RFC", rfc.RFC);
                comando.Parameters.AddWithValue("@ID", rfc.ID);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<E_RFC> Buscar(string texto)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            List<E_RFC> lista = new List<E_RFC>();
            try
            {
                conexion.Open();
                //Para un stored Procedure tenemos que pasar el NOMBRE del procedure y la conexion
                SqlCommand comando = new SqlCommand("buscarRFC", conexion);
                //Indicador que es un stored procedure
                comando.CommandType = CommandType.StoredProcedure;
                //Si el stored procedure necesita parametros, hay agregarlos
                comando.Parameters.AddWithValue("@texto", texto);

                //Objeto SQLDataReader para leer el conjunto de resultados que devuelve el SELECT
                SqlDataReader reader = comando.ExecuteReader();
                //Recorremos el conjunto de resultados par llenar la lista
                while (reader.Read())
                {
                    //Creando un objeto de la clase empleado
                    E_RFC obj = new E_RFC();
                    //Asignamos sus propiedades 
                    obj.ID = Convert.ToInt32(reader["ID"]);//Convierte el tipo object a int
                    obj.nombre = reader["nombre"].ToString();//Convierte el tipo object a string 
                    obj.apellidoPaterno = reader["apellidoPaterno"].ToString();
                    obj.apellidoMaterno = reader["apellidoMaterno"].ToString();
                    obj.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);//Convierte el tipo object a DateTime 
                    obj.RFC = reader["RFC"].ToString();
                    //Agregando el objeto a la lista
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
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
                    valor = true;
                    break;
                }
            }
            //valor = true;
            return valor;
        }

        public string inicialP(string paterno)
        {
            string dosLetras, palabra, letra2;
            if (paterno != "X") //Invertir el valor de la variable booleana IsNullOrWhiteSpace
            {
                string letra1 = paterno.Substring(0, 1);

                palabra = paterno.ToLower();
                letra2 = "X";
                for (int i = 1; i < palabra.Length - 1; i++) //string elemento in lista
                {
                    char caracter = palabra[i];

                    // Verifica si el carácter es una vocal
                    if ("aeiou".Contains(caracter))
                    {
                        letra2 = caracter.ToString();
                        break;
                    }
                }

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
                letra = "X";
            }

            //string dosLetras = letra;
            return letra.ToUpper();
        }

        private string inicialN(string nombre)
        {
            string[] palabras = nombre.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string clave;
            if (palabras.Length == 2)
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
            clave = clave.Substring(0, 1);
            return clave.ToUpper();
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
    }
}
