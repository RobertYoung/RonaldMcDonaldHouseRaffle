using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RonaldMcDonaldHouseRaffle.Data;
using RonaldMcDonaldHouseRaffle.Data.Entities;

namespace RonaldMcDonaldHouseRaffle.Controllers
{
    public class ContestantDetailsController : Controller
    {
        private RMHRContext db = new RMHRContext();

        // GET: ContestantDetails
        public ActionResult Index()
        {
            return View(db.Contestants.ToList());
        }

        // GET: ContestantDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantDetails contestantDetails = db.Contestants.Find(id);
            if (contestantDetails == null)
            {
                return HttpNotFound();
            }
            return View(contestantDetails);
        }

        // GET: ContestantDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContestantDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContestantId,FirstName,Surname,Address1,Address2,City,Postcode,PhoneNumber")] ContestantDetails contestantDetails)
        {
            if (ModelState.IsValid)
            {
                db.Contestants.Add(contestantDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contestantDetails);
        }

        // GET: ContestantDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantDetails contestantDetails = db.Contestants.Find(id);
            if (contestantDetails == null)
            {
                return HttpNotFound();
            }
            return View(contestantDetails);
        }

        // POST: ContestantDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContestantId,FirstName,Surname,Address1,Address2,City,Postcode,PhoneNumber")] ContestantDetails contestantDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contestantDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contestantDetails);
        }

        // GET: ContestantDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContestantDetails contestantDetails = db.Contestants.Find(id);
            if (contestantDetails == null)
            {
                return HttpNotFound();
            }
            return View(contestantDetails);
        }

        // POST: ContestantDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContestantDetails contestantDetails = db.Contestants.Find(id);
            db.Contestants.Remove(contestantDetails);
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
