using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public class FlightsRepository : IRepository<Flight>
    {
        private IAirportContext _airportContext;
        public FlightsRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Flight Create(Flight entity)
        {
            _airportContext.Flights.Add(entity);
            return entity;
        }

        public IEnumerable<Flight> Create(IEnumerable<Flight> entitys)
        {
            _airportContext.Flights.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Flights.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Flights.Remove(itemToRemove);
        }

        public bool Delete(Flight entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Flight> Find(Func<Flight, bool> predicate)
        {
            return _airportContext.Flights?.Where(predicate);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _airportContext.Flights;
        }

        public Flight GetById(int id)
        {
            return _airportContext.Flights?.FirstOrDefault(t => t.Id == id);
        }

        public Flight Update(Flight entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Flights?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Flights.Remove(updatedEntity))
            {
                _airportContext.Flights.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
