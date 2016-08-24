using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication33.Models;

namespace WebApplication33.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Order model)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }

            return View();
        }
    }
}