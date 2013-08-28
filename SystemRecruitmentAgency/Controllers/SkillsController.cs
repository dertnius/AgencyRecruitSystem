using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemRecruitmentAgency.Models;
using SystemRecruitmentAgency.DAL;

namespace SystemRecruitmentAgency.Controllers
{
    public class SkillsController : Controller
    {
        private AgencyContext db = new AgencyContext();

        //
        // GET: /Skills/

        public ActionResult Index()
        {
            return View(db.Technologies.ToList());
        }

        //
        // GET: /Skills/Details/5

        public ActionResult Details(int id = 0)
        {
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // GET: /Skills/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Skills/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Technologies.Add(technology);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(technology);
        }

        //
        // GET: /Skills/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // POST: /Skills/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technology).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(technology);
        }

        //
        // GET: /Skills/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        //
        // POST: /Skills/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Technology technology = db.Technologies.Find(id);
            db.Technologies.Remove(technology);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}