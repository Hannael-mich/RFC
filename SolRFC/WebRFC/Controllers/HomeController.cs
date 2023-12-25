using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRFC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Consulta");
        }

        public ActionResult IrAgregar()
        {
            return View("VistaAgregar");
        }
        public ActionResult Agregar (E_RFC rfc)
        {
            //string RFC;
            try
            {
                N_RFC negocio = new N_RFC();
                negocio.Agregar(rfc);
                TempData["mensaje"] = $"El RFC es: {rfc.RFC}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return View("TuRFC");
        }

        public ActionResult IrBaseDatos()
        {
            List<E_RFC> lista = new List<E_RFC>();
            try
            {
                N_RFC negocio = new N_RFC();
                lista = negocio.ObtenerTodos();
                //TempData["mensaje"] = "Se agrego correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return View("BaseDatos", lista);
            
        }

        public ActionResult Eliminar(int idRFC)
        {
            try
            {
                N_RFC negocio= new N_RFC();
                negocio.Eliminar(idRFC);
                TempData["mensaje"] = $"Se elimino correctamente el RFC con id {idRFC}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
            }
            return RedirectToAction("IrBaseDatos");
        }

        public ActionResult ObtenerParaEditar(int idRFC)
        {
            try
            {
                N_RFC negocio = new N_RFC();

                E_RFC rfc = negocio.obtenerRFCPorID(idRFC);
                return View("Editar", rfc);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.StackTrace;
                return RedirectToAction("IrBaseDatos");
            }
        }

        public ActionResult Editar(E_RFC rfc)
        {
            try
            {
                N_RFC negocio = new N_RFC();
                negocio.Editar(rfc);

                TempData["mensaje"] = $"Se edito correctamente el empleado con el id {rfc.ID}";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;

            }
            return RedirectToAction("IrBaseDatos");
        }

        public ActionResult Buscar(string texto)
        {
            List<E_RFC> lista = new List<E_RFC>();
            try
            {
                N_RFC negocio = new N_RFC();
                lista = negocio.BuscarUsuario(texto);
                return View("BaseDatos", lista);
                
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("BaseDatos");
            }
        }

    }
}