using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication76.Models;

namespace WebApplication76.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Домашняя";


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

            var enterModel = new LoginModel();

            enterModel.login = "";
            enterModel.password = "";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Регистрация.";

            RegistrationModel registerModel = new RegistrationModel();

            registerModel.login = "";
            registerModel.password = "";
            registerModel.passwordTwo = "";
            registerModel.email = "";

            return View();
        }

        [HttpPost]
        public ActionResult Enter(LoginModel model)
        {
            ViewBag.Message = "Вход.";
            //login != String.Empty && password != String.Empty && password != null && password != null
            if (model.login != String.Empty && model.password != String.Empty && model.password != null && model.password != null)
            {
                //TODO запись в файл
                var stream = new FileStream(@"F:\Projects\Study_2015\WebApplication76\Enter.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(stream, Encoding.GetEncoding(1251));

                writer.WriteLine("Логин:  " + model.login);
                writer.WriteLine("Пароль: " + model.password);
                writer.WriteLine(new string('-', 30));

                stream.Seek(0, SeekOrigin.End);

                writer.Close();
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {
            ViewBag.Message = "Регистрация.";

            //TODO запись в файл
            if (model.login != String.Empty && model.password != String.Empty && model.passwordTwo != String.Empty && model.email != String.Empty && model.login != null && model.password != null && model.passwordTwo != null && model.email != null)
            {
                //TODO запись в файл
                var stream = new FileStream(@"F:\Projects\Study_2015\WebApplication76\Register.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine("Логин:  " + model.login);
                writer.WriteLine("Пароль: " + model.password);
                writer.WriteLine("Повтор пароля:  " + model.passwordTwo);
                writer.WriteLine("Почта: " + model.email);
                writer.WriteLine(new string('-', 30));

                stream.Seek(0, SeekOrigin.End);

                writer.Close();
            }

            return View();
        }
    }
}