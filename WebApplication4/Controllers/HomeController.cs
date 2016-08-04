using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product() { Id = 10, Name = "Name1", Price = 10.00m, Description = "text1" });
            list.Add(new Product() { Id = 11, Name = "Name2", Price = 11.12m, Description = "text2" });
            list.Add(new Product() { Id = 12, Name = "Name3", Price = 12.50m, Description = "text3" });
            list.Add(new Product() { Id = 13, Name = "Name4", Price = 13.00m, Description = "text4" });
            list.Add(new Product() { Id = 14, Name = "Name5", Price = 14.20m, Description = "text5" });
            list.Add(new Product() { Id = 15, Name = "Name6", Price = 15.00m, Description = "text6" });
            
            return View(list);
        }
    }
}