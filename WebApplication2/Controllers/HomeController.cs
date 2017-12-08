using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["temp"] = "shit";
            TempData.Keep();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var temp = TempData["temp"];
            TempData.Keep("temp");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var temp = TempData["temp"];
            return View();
        }
        public ActionResult Chat()
        {
            TempData["temp"] = "shit";
            return View();
        }
    }
}