using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication86.Models;

namespace WebApplication86.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PhoneModel phoneModel = new PhoneModel();
            phoneModel.codeCountry = 100;
            phoneModel.codeSity = 200;
            phoneModel.numAbonent = 504030;

            return View(phoneModel);
        }

        [HttpPost]
        public ActionResult Index(PhoneModel model)
        {
            return View(model);
        }
    }
}