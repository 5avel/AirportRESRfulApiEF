namespace AirportRESRfulApi.DAL.Models
{
    using System;
    using System.Collections.Generic;

    public class Departure : Entity
    {
        public int Flightid { set; get; }
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }
        public Plane Plane { set; get; }
        public Crew Crew { set; get; }
    }
}
