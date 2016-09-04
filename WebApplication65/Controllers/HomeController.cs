using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication65.Models;

namespace WebApplication65.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = OrdersDatabase.Orders;



            return View(data);
        }
        //GetAllOrderCustomer

        public ActionResult GetAllOrderCustomer(string Customer)
        {
            var data = OrdersDatabase.Orders;

            if (Customer != null)
            {
                data = data.Where(x => x.Customer == Customer);
            }

            return PartialView(data);
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