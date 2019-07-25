using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LcmTool.Models;

namespace LcmTool.Controllers
{
    public class StatusesTypesController : Controller
    {
        private LifecycleManagementEntities db = new LifecycleManagementEntities();

        // GET: StatusesTypes
        public ActionResult Index()
        {
            return View(db.StatusesTypes.ToList());
        }

        // GET: StatusesTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusesType statusesType = db.StatusesTypes.Find(id);
            if (statusesType == null)
            {
                return HttpNotFound();
            }
            return View(statusesType);
        }

        // GET: StatusesTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusesTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusID,StatusTypeName")] StatusesType statusesType)
        {
            if (ModelState.IsValid)
            {
                db.StatusesTypes.Add(statusesType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusesType);
        }

        // GET: StatusesTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusesType statusesType = db.StatusesTypes.Find(id);
            if (statusesType == null)
            {
                return HttpNotFound();
            }
            return View(statusesType);
        }

        // POST: StatusesTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusID,StatusTypeName")] StatusesType statusesType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusesType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusesType);
        }

        // GET: StatusesTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusesType statusesType = db.StatusesTypes.Find(id);
            if (statusesType == null)
            {
                return HttpNotFound();
            }
            return View(statusesType);
        }

        // POST: StatusesTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusesType statusesType = db.StatusesTypes.Find(id);
            db.StatusesTypes.Remove(statusesType);
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
