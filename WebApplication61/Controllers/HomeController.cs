using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication61.Models.EF;

namespace WebApplication61.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            TestMToMEntities context = new TestMToMEntities();

            var listOutCSharp = context.Courses
                .SelectMany(
                    course => course.Students/*,
                    (course, student) => new {
                        StudentName = student.Student,
                        CourseName = course.Course
                    }*/).ToList();

           
            return View(listOutCSharp);
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
    }
}