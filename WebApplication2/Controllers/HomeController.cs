using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.EF;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Peoples()
        {
            using (Database1Entities context = new Database1Entities())
            {
                List<Peoples> list = context.Peoples.ToList();

                return View(list);
            }
        }

        public ActionResult Sities()
        {
            using (Database1Entities context = new Database1Entities())
            {
                List<Sities> list = context.Sities.ToList();

                return View(list);
            }
        }

        public ActionResult Combine()
        {
            using (Database1Entities context = new Database1Entities())
            {
                List<Sities> list = context.Sities.ToList();

                //var orders = context.Sities
                //    .Include(o => o.Sities)
                //    .Include(o => o.Sities);

                return View(list);
            }
        }
    }
}