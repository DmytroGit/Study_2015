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
        private CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities();


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetailsDateToDate()
        {
            ViewBag.Text = "Отчет за период !Post";
            return View();
        }

        public ActionResult DetailsCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DetailsDateToDate(string NameStart,string NameFinish)
        {
            try
            {
                var list = context.Orders.
                    Include(c => c.Products).
                    Include(c => c.Customers);
                
                    ViewBag.Text = "Отчет за период Post";

                    return View(list.ToList());
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult DetailsCustomer(int? IdUser, string NameUser, string FamilyUser)
        {
            try
            {
                using (CustomersOrdersProducts_DBEntities context = new CustomersOrdersProducts_DBEntities())
                {
                    var list = context.Orders.
                            Include(c => c.Products).
                            Include(c => c.Customers);

                    list.ToList();

                    ViewBag.Text = "Отчет по покупателям";

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