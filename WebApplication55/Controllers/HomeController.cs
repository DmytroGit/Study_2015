using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication55.Models;

namespace WebApplication55.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ApplicationDbContext context = new ApplicationDbContext();

            ////////////////////////////////////////////
            //var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //// создаем две роли
            //var role1 = new IdentityRole { Name = "admin" };
            //var role2 = new IdentityRole { Name = "user" };
            //var role3 = new IdentityRole { Name = "moderator" };

            //// добавляем роли в бд
            //roleManager.Create(role1);
            //roleManager.Create(role2);
            //roleManager.Create(role3);

            //// создаем пользователей
            //var admin = new ApplicationUser { Email = "somemail@mail.ru", UserName = "somemail@mail.ru" };
            //string password = "ad46D_ewr3";
            //var result = userManager.Create(admin, password);

            //// если создание пользователя прошло успешно
            //if (result.Succeeded)
            //{
            //    // добавляем для пользователя роль
            //    userManager.AddToRole(admin.Id, role1.Name);
            //    userManager.AddToRole(admin.Id, role2.Name);
            //}

            ////base.Seed(context);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult AdminPanel()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "moderator")]
        public ActionResult ModeratorPanel()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "user")]
        public ActionResult UserPanel()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult AllPanel()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}