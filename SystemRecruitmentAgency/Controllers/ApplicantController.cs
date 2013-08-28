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
    public class ApplicantController : Controller
    {
        private AgencyContext db = new AgencyContext();

        //
        // GET: /Applicant/

        public ActionResult Index()
        {
            return View(db.Applicants.ToList());
        }

        //
        // GET: /Applicant/Details/5

        public ActionResult Details(int id = 0)
        {
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        //
        // GET: /Applicant/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Applicant/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        //
        // GET: /Applicant/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        //
        // POST: /Applicant/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        //
        // GET: /Applicant/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        //
        // POST: /Applicant/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
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