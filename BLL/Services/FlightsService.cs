using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using System;
using FluentValidation;

namespace AirportRESRfulApi.BLL.Services
{
    public class FlightsService : Service<Flight, FlightDto>, IFlightsService
    {


        public FlightsService(IUnitOfWork repository, IMapper mapper) : base(repository, mapper)
        {

        }

        public FlightDto GetByFlightNumberAndDate(string flightNumber, DateTime flightDate)
        {
            var result = _repository.Get(x => x.FlightNumber == flightNumber & x.DepartureTime == flightDate).SingleOrDefault();
            return _mapper.Map<Flight, FlightDto>(result);
        }
    }
}
