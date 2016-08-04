using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.EF;

namespace WebApplication2.Controllers
{
    public class PeoplesController : Controller
    {
        private Database1Entities db = new Database1Entities();

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
            ViewBag.Cities_Id = new SelectList(db.Sities, "Id", "Sity");
            return View();
        }

        // POST: Peoples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Old,Cities_Id")] Peoples peoples)
        {
            if (ModelState.IsValid)
            {
                db.Peoples.Add(peoples);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Cities_Id);
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
            ViewBag.Cities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Cities_Id);
            return View(peoples);
        }

        // POST: Peoples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Old,Cities_Id")] Peoples peoples)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peoples).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cities_Id = new SelectList(db.Sities, "Id", "Sity", peoples.Cities_Id);
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
