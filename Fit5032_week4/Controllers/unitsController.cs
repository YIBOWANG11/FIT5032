using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fit5032_week4.Models;

namespace Fit5032_week4.Controllers
{
    public class unitsController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: units
        public ActionResult Index()
        {
            var unitSet = db.unitSet.Include(u => u.student);
            return View(unitSet.ToList());
        }

        // GET: units/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unit unit = db.unitSet.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            return View(unit);
        }

        // GET: units/Create
        public ActionResult Create()
        {
            ViewBag.studentId = new SelectList(db.studentSet, "Id", "FirstName");
            return View();
        }

        // POST: units/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Decription,studentId")] unit unit)
        {
            if (ModelState.IsValid)
            {
                db.unitSet.Add(unit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.studentId = new SelectList(db.studentSet, "Id", "FirstName", unit.studentId);
            return View(unit);
        }

        // GET: units/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unit unit = db.unitSet.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            ViewBag.studentId = new SelectList(db.studentSet, "Id", "FirstName", unit.studentId);
            return View(unit);
        }

        // POST: units/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Decription,studentId")] unit unit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.studentId = new SelectList(db.studentSet, "Id", "FirstName", unit.studentId);
            return View(unit);
        }

        // GET: units/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unit unit = db.unitSet.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            return View(unit);
        }

        // POST: units/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            unit unit = db.unitSet.Find(id);
            db.unitSet.Remove(unit);
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
