using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication69.Models;

namespace WebApplication69.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> product = new List<Product>();

            product.Add(new Product() { Id = 1, Name = "Продукт 1", Description = "Описание продукта 1", Price = 11 });
            product.Add(new Product() { Id = 2, Name = "Продукт 2", Description = "Описание продукта 2", Price = 12 });
            product.Add(new Product() { Id = 3, Name = "Продукт 3", Description = "Описание продукта 3", Price = 13 });
            product.Add(new Product() { Id = 4, Name = "Продукт 4", Description = "Описание продукта 4", Price = 14 });
            product.Add(new Product() { Id = 5, Name = "Продукт 5", Description = "Описание продукта 5", Price = 15 });
            product.Add(new Product() { Id = 6, Name = "Продукт 6", Description = "Описание продукта 6", Price = 16 });
            product.Add(new Product() { Id = 7, Name = "Продукт 7", Description = "Описание продукта 7", Price = 17 });
            product.Add(new Product() { Id = 8, Name = "Продукт 8", Description = "Описание продукта 8", Price = 18 });

            return View(product);
        }
    }
}