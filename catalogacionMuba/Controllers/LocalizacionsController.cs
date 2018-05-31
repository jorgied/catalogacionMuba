using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using catalogacionMuba.Models;
using catalogacionMuba.Models.Context;

namespace catalogacionMuba.Controllers
{
    public class LocalizacionsController : Controller
    {
        private ContextMuba db = new ContextMuba();

        // GET: Localizacions
        public ActionResult Index()
        {
            return View(db.Localizacion.ToList());
        }

        // GET: Localizacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localizacion localizacion = db.Localizacion.Find(id);
            if (localizacion == null)
            {
                return HttpNotFound();
            }
            return View(localizacion);
        }

        // GET: Localizacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Localizacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_loc,Direccion,Telefono,email,Ubicacion,Observacion")] Localizacion localizacion)
        {
            if (ModelState.IsValid)
            {
                db.Localizacion.Add(localizacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localizacion);
        }

        // GET: Localizacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localizacion localizacion = db.Localizacion.Find(id);
            if (localizacion == null)
            {
                return HttpNotFound();
            }
            return View(localizacion);
        }

        // POST: Localizacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_loc,Direccion,Telefono,email,Ubicacion,Observacion")] Localizacion localizacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localizacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localizacion);
        }

        // GET: Localizacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localizacion localizacion = db.Localizacion.Find(id);
            if (localizacion == null)
            {
                return HttpNotFound();
            }
            return View(localizacion);
        }

        // POST: Localizacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Localizacion localizacion = db.Localizacion.Find(id);
            db.Localizacion.Remove(localizacion);
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
