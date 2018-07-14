namespace AirportRESRfulApi.DAL.Models
{
    public class Ticket: Entity
    {
        public int FlightId { set; get; }
        public Flight Flight { get; set; }

        public string FlightNumber { set; get; }
        public decimal Price { set; get; }
        public int PlaseNumber { set; get; }
        public bool IsSold { set; get; }
    }
}