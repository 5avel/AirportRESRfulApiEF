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
    public class FlightsService : IFlightsService
    {

        private IRepository<Flight> _repository;
        private IMapper _mapper;
        private IValidator<FlightDto> _validator;
        private ITicketsService _ticketsService;

        public FlightsService(IRepository<Flight> repository,
            IMapper mapper,
            IValidator<FlightDto> validator,
            ITicketsService ticketsService)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
            _ticketsService = ticketsService;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<FlightDto> Get()
        {
            var entity = _repository.GetAll();
            return _mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDto>>(entity);
        }

        public FlightDto GetByFlightNumberAndDate(string flightNumber, DateTime flightDate)
        {
            var entity = _repository.Find(f => f.FlightNumber == flightNumber & f.DepartureTime == flightDate).FirstOrDefault();
            return _mapper.Map<Flight, FlightDto>(entity);
        }

        public FlightDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Flight, FlightDto>(entity);
        }

        public FlightDto Make(FlightDto entity)
        {

            if (_validator.Validate(entity).IsValid != true) return null;


            var makedEntity = _mapper.Map<FlightDto, Flight>(entity);

            var tickets = GenerateTickets(makedEntity.Id, makedEntity.FlightNumber);

            _ticketsService.Make(tickets);

            return _mapper.Map<Flight, FlightDto>(_repository.Create(makedEntity));
        }

        public FlightDto Update(FlightDto entity)
        {
            var updatedEntity = _mapper.Map<FlightDto, Flight>(entity);
            return _mapper.Map<Flight, FlightDto>(_repository.Update(updatedEntity));
        }

        private List<TicketDto> GenerateTickets(int flightId, string flightNumber)
        {
            List<TicketDto> tickets = new List<TicketDto>();
            int startID = 0;
            
            for (int i = 1; i <= 80; i++)
            {
                tickets.Add(
                    new TicketDto
                    {
                        Id = ++startID,
                        FlightId = flightId,
                        FlightNumber = flightNumber,
                        IsSold = false,
                        PlaseNumber = tickets.Count + 1,
                        Price = 200
                    });
            }
            return tickets;
        }
    }
}
