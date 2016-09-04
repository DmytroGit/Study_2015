using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication62.Models;
using WebApplication62.Models.EF;

namespace WebApplication62.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //LINQ выражение + передача в представление
            TestMToMEntities context = new TestMToMEntities();

            var list = from students in context.Students
                       from courses in students.Courses
                       select new TestModel()
                       {
                           StudentName = students.Student,
                           CourseName = courses.Course
                       };
            
            return View(list);
        }
    }
}