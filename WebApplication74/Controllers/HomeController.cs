using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication74.Models;

namespace WebApplication74.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _ListPartial(int num = 1)
        {
            IEnumerable<TestModel> list = TestModel.GetList.Take(num);

            return PartialView(list);
        }
    }
}