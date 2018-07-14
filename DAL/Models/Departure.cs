namespace AirportRESRfulApi.DAL.Models
{
    using System;
    public class Departure : Entity
    {
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }

        public int FlightId { set; get; }
        public Flight Flight { get; set; }

        public Plane Plane { set; get; }

        public Crew Crew { set; get; }
    }
}
