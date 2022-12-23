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
            var zugskompositionen = new List<Zugskompositionen> {
                new Zugskompositionen(new Rollmaterial("Lok", "2021", 288.00, "MBL", "", "LGB", "22222", "", "Dampflok", "Emma", "", "Lummerland", "", "E", "2019")),
            };

            zugskompositionen[0].rollmaterial.Add(new Rollmaterial("Personenwagen", "2022", 698.00, "MBL", "", "LGB", "36685", "01", "Salonwagen", "Pullman Express", "Creme-Blau", "RhB", "As", "1141", "2022"));
            zugskompositionen[0].rollmaterial.Add(new Rollmaterial("Personenwagen", "2022", 698.00, "MBL", "", "LGB", "36685", "02", "Salonwagen", "Pullman Express", "Creme-Blau", "RhB", "As", "1141", "2022"));
            zugskompositionen[0].rollmaterial.Add(new Rollmaterial("Güterwagen", "2022", 199.00, "MBL", "", "LGB", "44925", "", "Rungenwagen", "4 Achsen / Doppelrungen", "Braun", "RhB", "Sp-W", "8355", "2022"));
            return View(zugskompositionen);
        }
            
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rollmaterial()
        {
            // Retrieve data from tables and create list of MyModel objects
            var rollmaterial = new List<Rollmaterial> {
                new Rollmaterial("Personenwagen", "2022", 698.00, "MBL", "", "LGB", "36685", "01", "Salonwagen", "Pullman Express", "Creme-Blau", "RhB", "As", "1141", "2022"),
                new Rollmaterial("Personenwagen", "2022", 698.00, "MBL", "", "LGB", "36685", "02", "Salonwagen", "Pullman Express", "Creme-Blau", "RhB", "As", "1141", "2022"),
                new Rollmaterial("Lok", "2021", 288.00, "MBL", "", "LGB", "22222", "", "Dampflok", "Emma", "", "Lummerland", "", "E", "2019"),
                new Rollmaterial("Güterwagen", "2022", 199.00, "MBL", "", "LGB", "44925", "", "Rungenwagen", "4 Achsen / Doppelrungen", "Braun", "RhB", "Sp-W", "8355", "2022")
            };

            return View(rollmaterial);
        }

        [HttpPost]
        public ActionResult AddRollmaterial()
        {
            // Check if the form was submitted
            if (Request.Form["formAddRollmaterial"] != null)
            {
                
            }

            return View();
        }

        public ActionResult Profile(int id)
        {
            return View();
        }
    }
}