using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Enter(string login, string password)
        {
            ViewBag.Message = "Вход.";

            if (login != String.Empty && password != String.Empty && password != null && password != null)
            {
                //TODO запись в файл
                var stream = new FileStream(@"F:\Projects\Study_2015\WebApplication76\Enter.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(stream, Encoding.GetEncoding(1251));

                writer.WriteLine("Логин:  " + login);
                writer.WriteLine("Пароль: " + password);
                writer.WriteLine(new string('-', 30));

                stream.Seek(0, SeekOrigin.End);

                writer.Close();
            }
            
            return View();
        }

        public ActionResult Register(string login, string password, string passwordTwo, string email)
        {
            ViewBag.Message = "Регистрация.";

            //TODO запись в файл
            if (login != String.Empty && password != String.Empty && passwordTwo != String.Empty && email != String.Empty && login != null && password != null && passwordTwo != null && email != null)
            {
                //TODO запись в файл
                var stream = new FileStream(@"F:\Projects\Study_2015\WebApplication76\Register.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine("Логин:  " + login);
                writer.WriteLine("Пароль: " + password);
                writer.WriteLine("Повтор пароля:  " + passwordTwo);
                writer.WriteLine("Почта: " + email);
                writer.WriteLine(new string('-', 30));

                stream.Seek(0, SeekOrigin.End);

                writer.Close();
            }

            return View();
        }
    }
}