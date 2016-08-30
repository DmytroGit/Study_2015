using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication48.Models;

namespace WebApplication48.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public ActionResult Test()
        {
            PartialTestModel model = new PartialTestModel();

            return PartialView("_PartialTest", model);
        }

        [HttpPost]
        public ActionResult Test(PartialTestModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }

            return View("Index");
        }
    }
}