using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Samarth Interests";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Samarth Home";

            return View();
        }
    }
}