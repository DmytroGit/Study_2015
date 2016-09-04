using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication64.Models;

namespace WebApplication64.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
       
        public ActionResult _GetDataPartial(int? Id, int? Idd)
        {
            var data = TestModel.GetArray();

            if (Id != null)
            {
                var rezQuery =
                    data.Where(x => x.Id > Id).Where(x=>x.Id< Idd);

                return PartialView(rezQuery);
            }

            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}