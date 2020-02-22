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
            return View(flight);
        }
        public ActionResult AddFlight()
        {
            return View("AddFlight");
        }
        [HttpPost]
        public ActionResult AddFlightPost()
        {
            Flight flight = new Flight();
            //UpdateModel<Flight>(flight);
            TryUpdateModel<Flight>(flight);
            FlightRepository.flight.Add(flight);
            TempData["message"] = "Added Successful";
            return RedirectToAction("DisplayFlight");
        }
        public ActionResult EditFlight(int FlightId)
        {
            Flight flight=FlightRepository.FindFlightId(FlightId);
            return View(flight);
        }
        public ActionResult UpdateFlights([Bind(Include="Flightid,FlightName")]FlightEntity flight)
        {
            FlightRepository.UpdateFlight(flight);
            TempData["Message"] = "Updated Successfully";
            return RedirectToAction("DisplayFlight");
        }

        public ActionResult DeleteFlight(int flightId)
        {
            FlightRepository.DeleteFlight(flightId);
            TempData["Message"] = "Deleted Successfully";
            return RedirectToAction("DisplayFlight");
        }
    }
}
