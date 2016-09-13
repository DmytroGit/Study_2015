using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication85.Models;

namespace WebApplication85.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            User userModel = new User();
            
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            Debug.WriteLine(model.name);
            Debug.WriteLine(model.old);

            return View();
        }
    }
}