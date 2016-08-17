using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Главная страница.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О нас.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Новости.";

            return View();
        }


        public ActionResult Enter()
        {
            ViewBag.Message = "Вход.";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Регистрация.";

            return View();
        }
    }
}