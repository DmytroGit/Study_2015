using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication88.Models;

namespace WebApplication88.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Test> list = new List<Test>();

            list.Add(new Test { id = 1, name = "name 1" });
            list.Add(new Test { id = 2, name = "name 2" });
            list.Add(new Test { id = 3, name = "name 3" });
            list.Add(new Test { id = 4, name = "name 4" });
            list.Add(new Test { id = 5, name = "name 5" });

            var query =
                from l in list
                where l.id > 2
                select l;

            return View(query);
        }
    }
}