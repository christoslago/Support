using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Support.Models;

namespace Support.Controllers
{
    public class TechniciansController : Controller
    {
        private TechniciansDBContext db = new TechniciansDBContext();

        // GET: Technicians
        public ActionResult Index()
        {
            return View(db.Technicians.ToList());
        }

        // GET: Technicians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technicians technicians = db.Technicians.Find(id);
            if (technicians == null)
            {
                return HttpNotFound();
            }
            return View(technicians);
        }

        // GET: Technicians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Technicians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Firstname,Lastname,Age,YearsService,Address")] Technicians technicians)
        {
            if (ModelState.IsValid)
            {
                db.Technicians.Add(technicians);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(technicians);
        }

        // GET: Technicians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technicians technicians = db.Technicians.Find(id);
            if (technicians == null)
            {
                return HttpNotFound();
            }
            return View(technicians);
        }

        // POST: Technicians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Firstname,Lastname,Age,YearsService,Address")] Technicians technicians)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technicians).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(technicians);
        }

        // GET: Technicians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technicians technicians = db.Technicians.Find(id);
            if (technicians == null)
            {
                return HttpNotFound();
            }
            return View(technicians);
        }

        // POST: Technicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Technicians technicians = db.Technicians.Find(id);
            db.Technicians.Remove(technicians);
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
