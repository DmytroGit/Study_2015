using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();//загруска лок дисков

            return View(drives);
        }


        public ActionResult Index1(string id)
        {
            string[] drives = Directory.GetDirectories(@"E:");//загруска лок дисков
            

            return View(drives);
        }
    }
}