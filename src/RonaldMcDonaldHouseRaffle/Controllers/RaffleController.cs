using RonaldMcDonaldHouseRaffle.Data;
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
            var test = _context.Contestants.ToList();
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Details";

            return View();
        }
    }
}