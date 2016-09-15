using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication87.Models.EF;

namespace WebApplication87.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrdersDateToDate(DateTime? start, DateTime? finish)
        {
            if (start != null && finish != null)
            {
                Customers_DBEntities context = new Customers_DBEntities();

                List<Orders> list = context.Orders.ToList();

                var queryCount = list
                    .Where(x => x.OrderDateOrder >= start)
                    .Where(x => x.OrderDateOrder <= finish)
                    .Sum(x => x.OrderCountProduct);

                var queryPrice = list
                    .Where(x => x.OrderDateOrder >= start)
                    .Where(x => x.OrderDateOrder <= finish)
                    .Sum(x => x.OrderCountProduct * x.Products.ProductPrice);

                ViewBag.CountOrders = queryCount;
                ViewBag.CountPrice = queryPrice;
            }

            return View();
        }

        public ActionResult OrdersUser(string user)
        {
            if (user != null)
            {
                Customers_DBEntities context = new Customers_DBEntities();

                List<Orders> list = context.Orders.ToList();

                //для ViewBag.CountPrice
                var queryPrice = list
                    .Where(x => x.Users.UserFirstName == user)
                    .Sum(x => x.OrderCountProduct * x.Products.ProductPrice);
                
                ViewBag.CountPrice = queryPrice;

                //для Model
                var modelQuery = list
                    .Where(x => x.Users.UserFirstName == user);
                
                return View(modelQuery);
            }

            return View();
        }
    }
}