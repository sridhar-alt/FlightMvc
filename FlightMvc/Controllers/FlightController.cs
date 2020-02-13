using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using FlightData;
using Repository;

namespace FlightMvc.Controllers
{
    public class FlightController : Controller
    {
        // GET: Flight
        public ActionResult DisplayFlight()
        {
            IEnumerable<Flight> flight = FlightRepository.GetDetails();
            ViewBag.flight = flight;
            ViewData["flight"] = flight;
            TempData["flight"] = flight;
            return View();
        }
    }
}