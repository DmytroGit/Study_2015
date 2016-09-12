using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication82.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double? a, double? b, string submit)
        {
            if (a != null && b != null & submit != null && submit != String.Empty)
            {
                double rez = 0;

                switch (submit)
                {
                    case "+":
                        rez = (double)a + (double)b;
                        break;
                    case "-":
                        rez = (double)a - (double)b;
                        break;
                    case "*":
                        rez = (double)a * (double)b;
                        break;
                    case "/":
                        rez = (double)a / (double)b;
                        break;
                    default:
                        break;
                }
                
                ViewBag.rez = rez;
            }

            return View();
        }
    }
}