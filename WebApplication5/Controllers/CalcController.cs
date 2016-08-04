using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Add(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Rezult = x + y;
            }

            return View("CalcRezult");
        }
        public ActionResult Mul(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Rezult = x * y;
            }

            return View("CalcRezult");
        }
        public ActionResult Sub(int? x, int? y)
        {
            if (x != null && y != null)
            {
                ViewBag.Rezult = x - y;
            }

            return View("CalcRezult");
        }
        public ActionResult Div(int? x, int? y)
        {
            if (x != null && y != null && y !=0)
            {
                ViewBag.Rezult = x / y;
            }

            return View("CalcRezult");
        }
    }
}