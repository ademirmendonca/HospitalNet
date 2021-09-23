using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalBLL;
using HospitalModels;

namespace HospitalNetWeb.Controllers
{
    public class TipoExameController : Controller
    {
        private HospitalContext db = new HospitalContext();
        private TipoExameBLL tipoExameBLL = new TipoExameBLL();

        // GET: TipoExame
        public ActionResult Index()
        {
            return View(db.TipoExames.ToList());
        }

        // GET: TipoExame/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // GET: TipoExame/Create
        public ActionResult Create()
        {
            return View(new TipoExame());
        }

        // POST: TipoExame/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoExame,NomeTipoExame,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.TipoExames.Add(tipoExame);
                tipoExameBLL.Incluir(tipoExame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoExame);
        }

        // GET: TipoExame/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoExame,NomeTipoExame,Descricao")] TipoExame tipoExame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoExame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoExame);
        }

        // GET: TipoExame/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoExame tipoExame = db.TipoExames.Find(id);
            if (tipoExame == null)
            {
                return HttpNotFound();
            }
            return View(tipoExame);
        }

        // POST: TipoExame/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TipoExame tipoExame = db.TipoExames.Find(id);
            db.TipoExames.Remove(tipoExame);
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
