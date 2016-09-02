using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29.Models;
using WebApplication29.Models.EF;

namespace WebApplication29.Controllers
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
            return View();
        }
        public ActionResult DetailsCustomer()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _DetailsDateToDate()
        {
            return PartialView("_DetailDateToDate");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult _DetailsDateToDate(DetailsDateToDateModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newContext = context.Orders.ToList();

                    //Количество продаж
                    var qyeryCountOrdersProducts = newContext
                        .Where(emp => emp.DateOrder >= model.StartDate)
                        .Where(emp => emp.DateOrder <= model.FinishDate)
                        .Select(emp => emp.CountProduct)
                        .Sum();


                    //Количество продаж
                    var qyerySumPriceProducts = newContext
                        .Where(emp => emp.DateOrder >= model.StartDate)
                        .Where(emp => emp.DateOrder <= model.FinishDate)
                        .Select(emp => emp.CountProduct * emp.Products.Price)
                        .Sum();

                    ViewBag.CountOrder = qyeryCountOrdersProducts;
                    ViewBag.SummPrice = qyerySumPriceProducts;
                }
                return PartialView("_DetailDateToDate");
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }

        [ChildActionOnly]
        public ActionResult _DetailsCustomer()
        {
            ViewBag.Id = new SelectList(context.Products, "Id", "Id");
            ViewBag.FirstName = new SelectList(context.Customers, "FirstName", "FirstName");
            ViewBag.LastName = new SelectList(context.Customers, "LastName", "LastName");

            return PartialView("_DetailsCustomer");
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult _DetailsCustomer(DetailsCustomerModel model)
        {
            return PartialView("_DetailsCustomer");
        }

        [HttpPost]
        public ActionResult DetailsDateToDate(DetailsDateToDateModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DetailsCustomer(DetailsCustomerModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newContext = context.Orders.ToList();

                    //Количество продаж по пользователю
                    var qyerySumOrdersCustomer = newContext
                        .Where(emp => emp.Customers.FirstName.Trim() == model.FirstName)
                        .Select(emp => emp.CountProduct).Sum();


                    var list =
                        (from myList in newContext
                         where
                                myList.Customers.Id == model.Id ||
                                myList.Customers.FirstName.Trim().ToLower() == model.FirstName.ToLower() ||
                                myList.Customers.LastName.Trim().ToLower() == model.LastName.ToLower()

                         select myList).ToList();

                    ViewBag.SummOrdersCustomer = qyerySumOrdersCustomer;

                    return View(list);
                }
                return View();
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }
    }
}