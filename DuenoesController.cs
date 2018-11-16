using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClinicaAnimales.Models;

namespace ClinicaAnimales.Controllers
{
    public class DuenoesController : Controller
    {
        private ClinicaAnimalesContext db = new ClinicaAnimalesContext();

        // GET: Duenoes
        public ActionResult Index()
        {
            return View(db.Duenoes.ToList());
        }

        // GET: Duenoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dueno dueno = db.Duenoes.Find(id);
            if (dueno == null)
            {
                return HttpNotFound();
            }
            return View(dueno);
        }

        // GET: Duenoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Duenoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido")] Dueno dueno)
        {
            if (ModelState.IsValid)
            {
                db.Duenoes.Add(dueno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dueno);
        }

        // GET: Duenoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dueno dueno = db.Duenoes.Find(id);
            if (dueno == null)
            {
                return HttpNotFound();
            }
            return View(dueno);
        }

        // POST: Duenoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido")] Dueno dueno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dueno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dueno);
        }

        // GET: Duenoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dueno dueno = db.Duenoes.Find(id);
            if (dueno == null)
            {
                return HttpNotFound();
            }
            return View(dueno);
        }

        // POST: Duenoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dueno dueno = db.Duenoes.Find(id);
            db.Duenoes.Remove(dueno);
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
