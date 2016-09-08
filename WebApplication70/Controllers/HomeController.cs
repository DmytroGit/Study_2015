using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication70.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.rez = x + " + " + y + " = " + (x + y);
            }

            return View("Index");
        }
        public ActionResult Mul(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.rez = x + " * " + y + " = " + x * y;
            }

            return View("Index");
        }

        public ActionResult Sub(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.rez = x + " - " + y + " = " + (x - y);
            }

            return View("Index");
        }

        public ActionResult Div(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.rez = x + " / " + y + " = " + x / y;
            }

            return View("Index");
        }
    }
}