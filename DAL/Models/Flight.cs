namespace AirportRESRfulApi.DAL.Models
{
    using System;
    using System.Collections.Generic;

    public class Flight : Entity
    {
        public Departure Departure { set; get; }
        public string FlightNumber { set; get; } 
        public string DeparturePoint { set; get; }
        public DateTime DepartureTime { set; get; }
        public string DestinationPoint { set; get; }
        public DateTime ArrivalTime { set; get; }
        public List<Ticket> Tickets { set; get; }
    }
}
