using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product() { ID = 1, Name = "text1", Price = 10.0m, CreatedDate = DateTime.Now });
            list.Add(new Product() { ID = 2, Name = "text2", Price = 11.05m, CreatedDate = DateTime.Now });
            list.Add(new Product() { ID = 3, Name = "text3", Price = 12.6m, CreatedDate = DateTime.Now });
            list.Add(new Product() { ID = 4, Name = "text4", Price = 14.56m, CreatedDate = DateTime.Now });


            return View(list);
        }
    }
}