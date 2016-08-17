using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Registration()
        {
            RegistrationModel registrationModel = new RegistrationModel();

            registrationModel.Login = "Новый логин";
            registrationModel.Password = "Новый пароль";
            registrationModel.PasswordConfirm = "Повтор нового пароля";
            registrationModel.Email = "Новый email";

            return View(registrationModel);
        }

        [HttpPost]
        public ActionResult Registration(string Login, string Password, string PasswordConfirm, string Email)
        {
            //TODO реализовать запись в файл
            return View();
        }
        public ActionResult Login()
        {
            LoginModel loginModel = new LoginModel();

            loginModel.Login = "Введите логин";
            loginModel.Password = "Введите пароль";

            return View(loginModel);
        }

        [HttpPost]
        public ActionResult Login(string Login, string Password)
        {
            //var file = new FileStream(@"E:\Login.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //var writer = new StreamWriter(file, Encoding.GetEncoding(1251));
            //writer.WriteLine("new1");
            //writer.Seek(SeekOrigin.End);
            //writer.Close();
            //TODO реализовать запись в файл
            return View();
        }
    }
}





















