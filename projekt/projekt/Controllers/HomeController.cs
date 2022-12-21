using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projekt.Models;

namespace projekt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new List<Zugskompositionen> {
                new Zugskompositionen(new Rollmaterial()),
                new Zugskompositionen(new Rollmaterial())
            };
               
            return View(data);
        }
            
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rollmaterial()
        {
            // Retrieve data from tables and create list of MyModel objects
            var data = new List<Zugskompositionen> {
                new Zugskompositionen(new Rollmaterial()),
                new Zugskompositionen(new Rollmaterial())
            };

            return View(data);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Profile(int id)
        {
            return View();
        }
    }
}