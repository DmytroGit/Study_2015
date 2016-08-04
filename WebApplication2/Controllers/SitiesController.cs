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
    public class SitiesController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: Sities
        public ActionResult Index()
        {
            return View(db.Sities.ToList());
        }

        // GET: Sities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sities sities = db.Sities.Find(id);
            if (sities == null)
            {
                return HttpNotFound();
            }
            return View(sities);
        }

        // GET: Sities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Sity")] Sities sities)
        {
            if (ModelState.IsValid)
            {
                db.Sities.Add(sities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sities);
        }

        // GET: Sities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sities sities = db.Sities.Find(id);
            if (sities == null)
            {
                return HttpNotFound();
            }
            return View(sities);
        }

        // POST: Sities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Sity")] Sities sities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sities);
        }

        // GET: Sities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sities sities = db.Sities.Find(id);
            if (sities == null)
            {
                return HttpNotFound();
            }
            return View(sities);
        }

        // POST: Sities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sities sities = db.Sities.Find(id);
            db.Sities.Remove(sities);
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
