using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportRESRfulApi.DAL
{
    public class DeparturesRepository : IRepository<Departure>
    {
        private IAirportContext _airportContext;
        public DeparturesRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Departure Create(Departure entity)
        {
            _airportContext.Departures.Add(entity);
            return entity;
        }

        public IEnumerable<Departure> Create(IEnumerable<Departure> entitys)
        {
            _airportContext.Departures.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Departures.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Departures.Remove(itemToRemove);
        }

        public bool Delete(Departure entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Departure> Find(Func<Departure, bool> predicate)
        {
            return _airportContext.Departures?.Where(predicate);
        }

        public IEnumerable<Departure> GetAll()
        {
            return _airportContext.Departures;
        }

        public Departure GetById(int id)
        {
            return _airportContext.Departures?.FirstOrDefault(t => t.Id == id);
        }

        public Departure Update(Departure entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Departures?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Departures.Remove(updatedEntity))
            {
                _airportContext.Departures.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
