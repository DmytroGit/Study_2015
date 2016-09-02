using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication53.Filters;

namespace WebApplication53.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MyFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}