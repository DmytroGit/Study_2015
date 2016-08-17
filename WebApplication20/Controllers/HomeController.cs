using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication20.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Arifm(int? a, int? b, string myButton)
        {
            try
            {
                if (a != null && b != null && myButton != null)
                {
                    switch (myButton)
                    {
                        case "+":
                            ViewBag.Rezult = a + b;
                            break;
                        case "-":
                            ViewBag.Rezult = a - b;
                            break;
                        case "*":
                            ViewBag.Rezult = a * b;
                            break;
                        case "/":
                            ViewBag.Rezult = a / b;
                            break;
                    }

                    return View("Index");
                }
                else
                {
                    return View("Error");
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