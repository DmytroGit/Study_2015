using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models.EF;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (TestMVCEntities context = new TestMVCEntities())
            {
                //var order = context.Peoples.Include(s => s.)
            }

            return View();
        }
    }
}