using Giorno1Oggetti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Giorno1.Controllers
{
    public class HomeController : Controller
    {
        private Giorno1Context db = new Giorno1Context();

        public ActionResult Index()
        {
            ViewBag.ElencoContatti = db.Contacts.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Titolo = "Corso ASPNET MVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Benvenuto()
        {
            return View();
        }
    }
}