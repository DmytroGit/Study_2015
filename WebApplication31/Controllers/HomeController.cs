﻿using System;
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
        public ActionResult DetailsDateToDate(DateTime NameStart, DateTime NameFinish)
        {
            try
            {
                //var list = context.Orders.
                //    Include(c => c.Products).
                //    Include(c => c.Customers);

                var newContext = context.Orders.ToList();

                var list =
                    (from myList in newContext
                     where
                            myList.DateOrder >= NameStart &&
                            myList.DateOrder <= NameFinish
                     select myList).ToList();

                ViewBag.Text = "Отчет за период Post";
                ViewBag.CountOrder = 10;
                ViewBag.SummPrice = 101;

                return View();
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult DetailsCustomer(int? IdUser, string FirstName, string LastName)
        {
            try
            {
                var newContext = context.Orders.ToList();

                //var list =
                //    (from myList in newContext
                //     select myList).Sum();

                var list =
                    (from myList in newContext
                     where
                            myList.Customers.Id == IdUser ||
                            myList.Customers.FirstName.Trim().ToLower() == FirstName.ToLower() ||
                            myList.Customers.LastName.Trim().ToLower() == LastName.ToLower()

                     select myList).ToList();

                ViewBag.Text = "Отчет по покупателям";
                ViewBag.SummOrdersCustomer = 89;

                return View(list);
            }
            catch (Exception exp)
            {
                ViewBag.Error = exp.Message;
                return View("Error");
            }
        }
    }
}