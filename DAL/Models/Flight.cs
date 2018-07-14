namespace AirportRESRfulApi.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Flight : Entity
    {
        [MaxLength(8)]
        public string FlightNumber { set; get; }
        [MaxLength(50)]
        public string DeparturePoint { set; get; }
        public DateTime DepartureTime { set; get; }
        [MaxLength(50)]
        public string DestinationPoint { set; get; }
        public DateTime ArrivalTime { set; get; }

        public ICollection<Ticket> Tickets { set; get; }

        public Departure Departure { set; get; }
    }
}
