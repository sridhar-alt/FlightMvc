using FlightData;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Repository
{
    public class FlightRepository
    {
        public static List<Flight> flight = new List<Flight>();
        static FlightRepository()
        {
            flight.Add(new Flight { Flight_Id=1,Flight_Name="Air India",Flight_Number=1002,Flight_Amount=1200});
            flight.Add(new Flight { Flight_Id = 2, Flight_Name = "Air Asia", Flight_Number = 1004, Flight_Amount = 1222 });
            flight.Add(new Flight { Flight_Id = 3, Flight_Name = "sri", Flight_Number = 1302, Flight_Amount = 1222 });
            flight.Add(new Flight { Flight_Id = 4, Flight_Name = "India", Flight_Number = 1056, Flight_Amount = 1120 });
        }
        public static IEnumerable<Flight> GetDetails()
        {
            return flight;
        }
        public static Flight FindFlightId(int flightId)
        {
            Flight fli = new Flight();
           foreach(Flight flightobj in flight)
            {
                if(flightobj.Flight_Id==flightId)
                {
                    return flightobj;
                }
            }
            return fli;
        }

        public static void UpdateFlight(int filght_Id, int flight_Amount, string flight_Name, int flight_Number)
        {
            Flight flightOb = FindFlightId(filght_Id);
            flight.Remove(flightOb);
            flight.Add(new Flight { Flight_Id = filght_Id, Flight_Name = flight_Name, Flight_Number = flight_Number, Flight_Amount = flight_Amount });
        }

        public static void DeleteFlight(int filght_Id)
        {
            Flight flightOb = FindFlightId(filght_Id);
            flight.Remove(flightOb);
        }
    }
}
