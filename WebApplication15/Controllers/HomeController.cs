using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                ViewBag.Id = id;
            }
            else
            {
                ViewBag.Id = null;
            }

            return View();
        }

        //[Authorize]
        public ActionResult Test()
        {
            return View();
        }
    }
}