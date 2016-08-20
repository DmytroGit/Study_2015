using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication32.Models;

namespace WebApplication32.Controllers
{
    public class HomeController : Controller
    {
        PhoneModel p = PhoneModel.GetPhone();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PhoneDisplayEdit()
        {
            return View(p);
        }
        [HttpPost]
        public ActionResult PhoneDisplayEdit(string codeCountry, string codeSity, string numberAbonent)
        {
            p.codeCountry = codeCountry;
            p.codeSity = codeSity;
            p.numberAbonent = numberAbonent;

            return View(p);
        }
    }
}