using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication83.Models;

namespace WebApplication83.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var modelList = ListProduct.GetListProduct();
            
            return View(modelList);
        }
    }
}