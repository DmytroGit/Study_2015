using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication57.Models.EF;

namespace WebApplication57.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult GEtUserAndRoles()
        {
            Entities context = new Entities();
            var list = context.
                
                AspNetUserClaims
                
                .ToList();


            return View(list);
        }
    }
}