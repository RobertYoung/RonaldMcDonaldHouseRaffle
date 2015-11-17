using RonaldMcDonaldHouseRaffle.Data;
using RonaldMcDonaldHouseRaffle.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RonaldMcDonaldHouseRaffle.Controllers
{
    public class RaffleController : Controller
    {
        private RMHRContext _context = new RMHRContext();

        public RaffleController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Details([Bind(Include = "ContestantId,FirstName,Surname,Address1,Address2,City,Postcode,PhoneNumber")] ContestantDetails contestantDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Contestants.Add(contestantDetails);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contestantDetails);
        }
    }
}