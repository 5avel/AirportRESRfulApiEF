namespace AirportRESRfulApi.DAL.Models
{

    using System.ComponentModel.DataAnnotations;
    public class Ticket: Entity
    {
        [Required]
        public int FlightId { set; get; }
        public Flight Flight { get; set; }

        [Required, MaxLength(8)]
        public string FlightNumber { set; get; }
        [Required]
        public decimal Price { set; get; }
        [Required]
        public int PlaseNumber { set; get; }
        [Required]
        public bool IsSold { set; get; }
    }
}