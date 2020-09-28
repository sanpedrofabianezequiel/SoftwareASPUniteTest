using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        public ActionResult Index()
        {
            //creamos una nueva opera
            Opera nueva = new Opera()
            {
                Title = "Fantasia nro3",
                Year = 1782,
                Composer = "Mozart"

            };

            //Creamos una instancia dbcontext
            OperaDBContext db = new OperaDBContext();

            //manejo de la coleccion operas

            db.Operas.Add(nueva);

            //insertamos la opera en base de datos
            db.SaveChanges();


            return View(db.Operas.ToList());
        }
    }
}