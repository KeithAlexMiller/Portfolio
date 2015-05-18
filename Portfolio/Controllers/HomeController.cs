using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Keith Miller";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Journey";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "I'd love to hear from you!";

            return View();
        }
        public ActionResult Work()
        {
            ViewBag.Message = "My Resumé";

            return View();
        }
    }
}