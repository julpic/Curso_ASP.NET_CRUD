using Curso_ASP.NET_CRUD.Dato;
using Curso_ASP.NET_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_ASP.NET_CRUD.Controllers
{
    public class VehiculoController : Controller
    {
        VehiculoAdmin admin = new VehiculoAdmin();
        // GET: Vehiculo
        public ActionResult Index()
        {
            IEnumerable<vehiculo> lista = admin.Consultar();
            ViewBag.mensaje = "";
            return View(lista);
        }

        public ActionResult Guardar()
        {
            ViewBag.mensaje = "";
            return View();
        }

        public ActionResult Nuevo(vehiculo modelo)
        {
            admin.Guardar(modelo);
            ViewBag.mensaje = "Vehiculo guardado";
            return View("Guardar",modelo);
        }

        public ActionResult Detalle(int id=0)
        {
            vehiculo modelo = admin.Consultar(id);
            return View(modelo);
        }
        public ActionResult Modificar(int id=0)
        {
            ViewBag.mensaje = "";
            vehiculo modelo = admin.Consultar(id);
            return View(modelo);
        }

        public ActionResult Actualizar(vehiculo modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje = "Vehiculo modificado";
            return View("Modificar", modelo);
        }
        public ActionResult Eliminar(int id = 0)
        {
            vehiculo modelo = new vehiculo()
            {
                Id = id,
            };
            admin.Eliminar(modelo);
            ViewBag.mensaje = "Vehiculo eliminado";
            IEnumerable<vehiculo> lista = admin.Consultar();
            return View("Index",lista);

        }
    }
}