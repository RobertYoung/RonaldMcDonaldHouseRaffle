using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RonaldMcDonaldHouseRaffle.Controllers
{
    public class RaffleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Details";

            return View();
        }
    }
}