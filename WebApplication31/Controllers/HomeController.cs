using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication31.Models.EF;
using System.Data;
using System.Data.Entity;

namespace WebApplication31.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetailsDateToDate()
        {
            try
            {
                using (CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities())
                {
                    var list = context.Orders.
                        Include(c => c.Products).
                        Include(c => c.Customers);

                    list.ToList();

                    ViewBag.Text = "Отчет за период по покупателям";

                    return View(list);
                }
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }

        public ActionResult DetailsCustomer()
        {
            try
            {
                using (CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities())
                {
                    var list = context.Orders.
                            Include(c => c.Products).
                            Include(c => c.Customers);

                    list.ToList();

                    ViewBag.Text = "Отчет по продаже";

                    return View(list);
                }   
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }  
        }
    }
}