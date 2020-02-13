using FlightData;
using System.Collections.Generic;
using System.Collections;

namespace Repository
{
    public class FlightRepository
    {
        public static List<Flight> flight = new List<Flight>();
        static FlightRepository()
        {
            flight.Add(new Flight { Filght_Id=1,Flight_Name="Air India",Flight_Number=1002,Flight_Amount=1200});
            flight.Add(new Flight { Filght_Id = 2, Flight_Name = "Air Asia", Flight_Number = 1004, Flight_Amount = 1222 });
            flight.Add(new Flight { Filght_Id = 3, Flight_Name = "sri", Flight_Number = 1302, Flight_Amount = 1222 });
            flight.Add(new Flight { Filght_Id = 4, Flight_Name = "India", Flight_Number = 1056, Flight_Amount = 1120 });
        }
        public static IEnumerable<Flight> GetDetails()
        {
            return flight;
        }
    }
}
