using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication73.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _ProductListPartial()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product { ID = 1, Name = "name1", Price = 11, CreatedDate = DateTime.Parse("2011-01-10") });
            list.Add(new Product { ID = 2, Name = "name2", Price = 12, CreatedDate = DateTime.Parse("2012-01-10") });
            list.Add(new Product { ID = 3, Name = "name3", Price = 13, CreatedDate = DateTime.Parse("2013-01-10") });
            list.Add(new Product { ID = 4, Name = "name4", Price = 14, CreatedDate = DateTime.Parse("2014-01-10") });
            list.Add(new Product { ID = 5, Name = "name5", Price = 15, CreatedDate = DateTime.Parse("2015-01-10") });

            return View(list);
        }


    }
}