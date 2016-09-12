using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication75.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string a = Request.QueryString["id"];
            
            if (a == null)
            {
                ViewBag.rez = "Данные не предоставлены.";

                return View();
            }
            else
            {
                //ViewBag.rez = "Данные.";

                return Content(a, "text/plaint", Encoding.UTF8);
            }  
        }
    }
}