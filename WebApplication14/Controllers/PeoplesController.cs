using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models.EF;

namespace WebApplication14.Controllers
{
    public class PeoplesController : Controller
    {
        private TestMVCEntities db = new TestMVCEntities();

        // GET: Peoples
        public ActionResult Index()
        {
            var peoples = db.Peoples.Include(p => p.Sities);
            return View(peoples.ToList());
        }

        // GET: Peoples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peoples peoples = db.Peoples.Find(id);
            if (peoples == null)
            {
                return HttpNotFound();
            }
            return View(peoples);
        }

        // GET: Peoples/Create
        public ActionResult Create()
        {
            ViewBag.Sities_Id = new SelectList(db.Sities, "Id", "Sity");
            return View();
        }

        // POST: Peoples/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,People,Sities_Id")] Peoples peoples)
        {
            if (ModelState.IsValid)
            {
                db.Peoples.Add(peoples);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Sities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Sities_Id);
            return View(peoples);
        }

        // GET: Peoples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peoples peoples = db.Peoples.Find(id);
            if (peoples == null)
            {
                return HttpNotFound();
            }
            ViewBag.Sities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Sities_Id);
            return View(peoples);
        }

        // POST: Peoples/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,People,Sities_Id")] Peoples peoples)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peoples).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Sities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Sities_Id);
            return View(peoples);
        }

        // GET: Peoples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peoples peoples = db.Peoples.Find(id);
            if (peoples == null)
            {
                return HttpNotFound();
            }
            return View(peoples);
        }

        // POST: Peoples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Peoples peoples = db.Peoples.Find(id);
            db.Peoples.Remove(peoples);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
