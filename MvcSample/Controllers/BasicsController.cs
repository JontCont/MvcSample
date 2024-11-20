using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcSample.Models;

namespace MvcSample.Controllers
{
    public class BasicsController : Controller
    {
        private MvcSampleEntities1 db = new MvcSampleEntities1();

        // GET: Basics
        public ActionResult Index()
        {
            return View(db.Basic.ToList());
        }

        // GET: Basics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            return View(basic);
        }

        // GET: Basics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Basics/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Memo")] Basic basic)
        {
            if (ModelState.IsValid)
            {
                db.Basic.Add(basic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basic);
        }

        // GET: Basics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            return View(basic);
        }

        // POST: Basics/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Memo")] Basic basic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basic);
        }

        // GET: Basics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basic basic = db.Basic.Find(id);
            if (basic == null)
            {
                return HttpNotFound();
            }
            return View(basic);
        }

        // POST: Basics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Basic basic = db.Basic.Find(id);
            db.Basic.Remove(basic);
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
