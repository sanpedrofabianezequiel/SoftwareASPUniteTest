using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Mensaje = "Bienvenidos al sitio de Operas";
            ViewBag.Now = DateTime.Now;

            return View();
        }
    }
}