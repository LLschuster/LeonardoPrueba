using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeonardoPerezPrueba.Models;
using LeonardoPerezPrueba.Models.personViewModel;

namespace LeonardoPerezPrueba.Controllers
{
    public class personasController : Controller
    {
        private databaseContext db = new databaseContext();

        // GET: personas
        public ActionResult Index()
        {
            var personas = db.personas.Include(p => p.Sexo);
            return View(personas.ToList());
        }

        // GET: personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona Dpersona = db.personas.Find(id);
            if (Dpersona == null)
            {
                return HttpNotFound();
            }
            var personData = new personViewModel
            {
                persona = Dpersona,
                sexos = db.sexos.ToList()
            };
            //ViewBag.sexoId = new SelectList(db.sexos, "id", "Nsexo");
            return View(personData);
            
        }

        // GET: personas/Create
        public ActionResult Create()
        {
            var personData = new personViewModel
            {
                sexos = db.sexos.ToList()
            };
            //ViewBag.sexoId = new SelectList(db.sexos, "id", "Nsexo");
            return View(personData);
            
        }

        // POST: personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,edad,sexoId")] persona persona)
        {
            if (ModelState.IsValid)
            {
                db.personas.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sexoId = new SelectList(db.sexos, "id", "Nsexo", persona.sexoId);
            return View(persona);
        }

        // GET: personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona Dpersona = db.personas.Find(id);
            if (Dpersona == null)
            {
                return HttpNotFound();
            }
            var personData = new personViewModel
            {
                persona = Dpersona,
                sexos = db.sexos.ToList()
            };
            //ViewBag.sexoId = new SelectList(db.sexos, "id", "Nsexo");
            return View(personData);
            
        }

        // POST: personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,edad,sexoId")] persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sexoId = new SelectList(db.sexos, "id", "Nsexo", persona.sexoId);
            return View(persona);
        }

        // GET: personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            persona persona = db.personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            persona persona = db.personas.Find(id);
            db.personas.Remove(persona);
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
