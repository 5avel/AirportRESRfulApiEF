using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class PilotsRepository : IRepository<Pilot>
    {
        private IAirportContext _airportContext;
        public PilotsRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Pilot Create(Pilot entity)
        {
            _airportContext.Pilots.Add(entity);
            return entity;
        }

        public IEnumerable<Pilot> Create(IEnumerable<Pilot> entitys)
        {
            _airportContext.Pilots.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Pilots.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Pilots.Remove(itemToRemove);
        }

        public bool Delete(Pilot entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Pilot> Find(Func<Pilot, bool> predicate)
        {
            return _airportContext.Pilots?.Where(predicate);
        }

        public IEnumerable<Pilot> GetAll()
        {
            return _airportContext.Pilots;
        }

        public Pilot GetById(int id)
        {
            return _airportContext.Pilots?.FirstOrDefault(t => t.Id == id);
        }

        public Pilot Update(Pilot entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Pilots?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Pilots.Remove(updatedEntity))
            {
                _airportContext.Pilots.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
