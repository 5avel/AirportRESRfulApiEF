using AirportRESRfulApi.BLL.Interfaces;
using AirportRESRfulApi.BLL.Validations;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using FluentValidation;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AirportRESRfulApi.BLL.Services
{
    public class TicketsService : Service<Ticket, TicketDto>, ITicketsService
    {

        public TicketsService(IUnitOfWork repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public TicketDto BayById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TicketDto> GetNotSoldSByFlightIdAndDate(string flightNumber, DateTime flightDate)
        {
            throw new NotImplementedException();
        }

        public bool Make(IEnumerable<TicketDto> entitys)
        {
            throw new NotImplementedException();
        }

        public TicketDto ReturnById(int id)
        {
            throw new NotImplementedException();
        }



        //public IEnumerable<TicketDto> GetNotSoldSByFlightIdAndDate(string flightNumber, DateTime flightDate)
        //{
        //    Flight flight = _flightsRepository.GetAll().Where(x => x.FlightNumber == flightNumber & x.DepartureTime == flightDate).FirstOrDefault();

        //    if (flight == null) return null;

        //    var entity = _repository.GetAll().Where(t => t.FlightId == flight.Id);
        //    return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(entity);
        //}

        //public TicketDto BayById(int id)
        //{
        //    var entity = _repository.GetById(id);

        //    if (entity == null) return null;

        //    if (entity.IsSold == true) return null; // Уже был продан

        //    entity.IsSold = true;
        //    var result = _repository.Update(entity);

        //    if (result == null) return null;

        //    return _mapper.Map<Ticket, TicketDto>(result);
        //}

        //public TicketDto ReturnById(int id)
        //{
        //    var entity = _repository.GetById(id);

        //    if (entity == null) return null;

        //    if (entity.IsSold == false) return null;  // Уже был возвращен

        //    entity.IsSold = false;
        //    var result = _repository.Update(entity);

        //    if (result == null) return null;

        //    return _mapper.Map<Ticket, TicketDto>(result);
        //}


    }
}
