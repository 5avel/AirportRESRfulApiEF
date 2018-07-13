using System;
namespace AirportRESRfulApi.Shared.DTO
{
    public class DepartureDto : BaseDto
    {
        public int Flightid { set; get; }
        public string FlightNumber { set; get; }
        public DateTime DepartureTime { set; get; }
    }
}
