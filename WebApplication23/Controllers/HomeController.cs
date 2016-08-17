using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication23.Models;

namespace WebApplication23.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserView()
        {
            UserModel userModel = new UserModel();

            userModel.Name = "Ваше имя";
            userModel.Old = 0;
            userModel.Phone = "Телефон";
            userModel.Sity = "Город";
            userModel.Date = DateTime.Now;

            return View(userModel);
        }

        [HttpPost]
        public ActionResult Create(UserModel userModel)
        {
            Debug.WriteLine("Имя: " + userModel.Name);
            Debug.WriteLine("Возраст: " + userModel.Old);
            Debug.WriteLine("Телефон: " + userModel.Phone);
            Debug.WriteLine("Город: " + userModel.Sity);
            Debug.WriteLine("Дата: " + userModel.Date);

            return View();
        }
    }
}