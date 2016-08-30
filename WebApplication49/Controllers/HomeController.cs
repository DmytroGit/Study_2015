using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication49.Models;

namespace WebApplication49.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ValidTest model)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }

            return View();
        }

        [ChildActionOnly]
        public ActionResult IndexP()
        {
            return PartialView("_DateToDate");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult IndexP(ValidTest model)
        {
            if (ModelState.IsValid)
            {
                return PartialView("_DateToDate");
            }

            return PartialView("_DateToDate");
        }
    }
}