using AirportRESRfulApi.Shared.DTO;
using System;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Interfaces
{
    public interface IFlightsService
    {
        IEnumerable<FlightDto> Get();
        FlightDto GetById(int id);
        FlightDto GetByFlightNumberAndDate(string flightNumber, DateTime flightDate);
        FlightDto Make(FlightDto entity);
        FlightDto Update(FlightDto entity);
        bool Delete(int id);
    }
}
