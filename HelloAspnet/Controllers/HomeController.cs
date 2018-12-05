#define TRACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloAspnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine("Display Index page");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            System.Diagnostics.Trace.WriteLine("Display About page");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            System.Diagnostics.Trace.WriteLine("Display Contact page");

            if (new Random().Next(10) == 5)
            {
                throw new ArgumentOutOfRangeException("param", "This is a random error. Try later.");
            }

            return View();
        }
    }
}