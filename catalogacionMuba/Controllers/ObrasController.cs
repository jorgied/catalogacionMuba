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
using catalogacionMuba.ViewModels;

namespace catalogacionMuba.Controllers
{
    public class ObrasController : Controller
    {
        private ContextMuba db = new ContextMuba();

        // GET: Obras
        public ActionResult Index()
        {
            return View(db.Obra.ToList());
        }

        // GET: Obras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obra.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // GET: Obras/Create
        public ActionResult Create()
        {
            ObraVM obraVM = new ObraVM();
            obraVM.Obra = new Obra();
            obraVM.Localizacions = db.Localizacion.ToList();
            obraVM.Propietarios = db.Propietario.ToList();
            return View(obraVM);
        }

        // POST: Obras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Include = "Cod_obra,Cod_reg,Cod_mues,Titulo,Coleccion,Conjunto,Serie,Autor,Nacionalidad,Origen,Fecha,Fechado,RegimenPrioridad,Procedencia,Premios,tecnica,Soporte,DescPreiconografica,DimencionMarco,DimSoporte,DimSinMarco,Tamaño,Inscripciones,EstadoIntegridad,EstadooConservacionObra,EstadooConservacionMarco,ObservacionConservacion,FotoFrente,FotoPost,ObservacionesObra,AnalisisObra,Bibliografia,Responsable,FechaCatalogacion, Id_loc, ID_prop")]*/ ObraVM obravm)
            {
            Obra obra = new Obra();
            obra = obravm.Obra;
            if (ModelState.IsValid)
            {
                db.Obra.Add(obra);
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obra);
        }

        // GET: Obras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obra.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // POST: Obras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cod_obra,Cod_reg,Cod_mues,Titulo,Coleccion,Conjunto,Serie,Autor,Nacionalidad,Origen,Fecha,Fechado,RegimenPrioridad,Procedencia,Premios,tecnica,Soporte,DescPreiconografica,DimencionMarco,DimSoporte,DimSinMarco,Tamaño,Inscripciones,EstadoIntegridad,EstadooConservacionObra,EstadooConservacionMarco,ObservacionConservacion,FotoFrente,FotoPost,ObservacionesObra,AnalisisObra,Bibliografia,Responsable,FechaCatalogacion")] Obra obra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obra);
        }

        // GET: Obras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Obra obra = db.Obra.Find(id);
            if (obra == null)
            {
                return HttpNotFound();
            }
            return View(obra);
        }

        // POST: Obras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Obra obra = db.Obra.Find(id);
            db.Obra.Remove(obra);
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
