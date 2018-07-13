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
    public class TicketsService : ITicketsService
    {
        private IRepository<Ticket> _repository;
        private IRepository<Flight> _flightsRepository;
        private IMapper _mapper;
        private IValidator<TicketDto> _ticketsValidator;
        public TicketsService(IRepository<Ticket> repository,
            IMapper mapper,
            IRepository<Flight> flightsRepository,
            IValidator<TicketDto> ticketValidator)
        {
            _repository = repository;
            _mapper = mapper;
            _flightsRepository = flightsRepository;
            _ticketsValidator = ticketValidator;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<TicketDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(entity);
        }


        public TicketDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Ticket, TicketDto>(entity);
        }

        public IEnumerable<TicketDto> GetNotSoldSByFlightIdAndDate(string flightNumber, DateTime flightDate)
        {
            Flight flight = _flightsRepository.Find(x => x.FlightNumber == flightNumber & x.DepartureTime == flightDate).FirstOrDefault();

            if (flight == null) return null;

            var entity = _repository.Find(t => t.FlightId == flight.Id);
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(entity);
        }

        public TicketDto BayById(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null) return null;

            if (entity.IsSold == true) return null; // Уже был продан

            entity.IsSold = true;
            var result = _repository.Update(entity);

            if (result == null) return null;

            return _mapper.Map<Ticket, TicketDto>(result);
        }

        public TicketDto ReturnById(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null) return null;

            if (entity.IsSold == false) return null;  // Уже был возвращен

            entity.IsSold = false;
            var result = _repository.Update(entity);

            if (result == null) return null;

            return _mapper.Map<Ticket, TicketDto>(result);
        }


        public TicketDto Make(TicketDto entity)
        {
            if (_ticketsValidator.Validate(entity).IsValid != true) return null;

            var makedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Create(makedEntity));
        }

        public IEnumerable<TicketDto> Make(IEnumerable<TicketDto> entitys)
        {
            

            var makedEntitys = _mapper.Map<IEnumerable<TicketDto>, IEnumerable<Ticket>>(entitys);
            return _mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDto>>(_repository.Create(makedEntitys));
        }

        public TicketDto Update(TicketDto entity)
        {
            if (new TicketsValidator().Validate(entity).IsValid != true) return null;

            var updatedEntity = _mapper.Map<TicketDto, Ticket>(entity);
            return _mapper.Map<Ticket, TicketDto>(_repository.Update(updatedEntity));
        }



    }
}
