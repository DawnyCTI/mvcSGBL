using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Generos()
        {
            return View();
        }
        public ActionResult Prestamos()
        {
            return View();
        }
        public ActionResult Libros()
        {
            return View();
        }
        public ActionResult Reservas()
        {
            return View();
        }
    }
}