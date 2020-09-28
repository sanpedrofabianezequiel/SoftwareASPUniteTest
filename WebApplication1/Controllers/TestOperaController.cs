using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [MyFilterAction]
    public class TestOperaController : Controller
    {
        //EF
        private OperaDBContext db = new OperaDBContext();

        // GET: TestOpera
        public ActionResult Index()
        {
            return View(db.Operas.ToList());
        }

        // GET: TestOpera/Create
        public ActionResult create()
        {
            Opera opera = new Opera();

            return View("create", opera);
        }

        // Post: TestOpera/Create/opera
        [HttpPost]
        public ActionResult create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Operas.Add(opera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("create", opera);
            }
           
        }

        //GET TestOpera/Details/1
        public ActionResult Details(int id)
        {
            Opera opera = db.Operas.Find(id);

            if (opera != null)
            {
                return View("Details", opera);
            }
            else
            {
                return HttpNotFound();
            }

            
        }

        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    //base.OnActionExecuting(filterContext);

        //    Debug.WriteLine("filtro de acción - OnActionExecuting");
        //}

        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    //base.OnActionExecuted(filterContext);
        //    Debug.WriteLine("filtro de acción - OnActionExecuted");
        //}
    }
}