using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaWebPracticaClase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Nuestros contactos son los siguientes:";

            return View();
        }

        public ActionResult Principal()
        {
            ViewBag.Message = "´Bienvenidos a la pagina principal.";
            DateTime fechaLocal = DateTime.Now;
            ViewBag.FechaLocal = fechaLocal;
            return View();
        }

        public ActionResult Categorías()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}