using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clase14s.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vision()
        {
            ViewBag.Message = "Bienvenido al apartado de Vision.";

            DateTime fechaLocal = DateTime.Now.Date;
            ViewBag.FechaLocal = fechaLocal;

            return View();
        }
    }
}