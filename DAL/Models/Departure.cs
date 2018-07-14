namespace AirportRESRfulApi.DAL.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Departure : Entity
    {
        [Required, MaxLength(8)]
        public string FlightNumber { set; get; }
        [Required]
        public DateTime DepartureTime { set; get; }
        [Required]
        public int FlightId { set; get; }
        public Flight Flight { get; set; }

        public Plane Plane { set; get; }

        public Crew Crew { set; get; }
    }
}
