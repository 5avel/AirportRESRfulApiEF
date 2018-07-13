using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class StewardessesRepository : IRepository<Stewardess>
    {
        private AirportContext _airportContext;
        public StewardessesRepository(AirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Stewardess Create(Stewardess entity)
        {
            _airportContext.Stewardesses.Add(entity);
            return entity;
        }

        public IEnumerable<Stewardess> Create(IEnumerable<Stewardess> entitys)
        {
            _airportContext.Stewardesses.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Stewardesses.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Stewardesses.Remove(itemToRemove) != null;
        }

        public bool Delete(Stewardess entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Stewardess> Find(Func<Stewardess, bool> predicate)
        {
            return _airportContext.Stewardesses?.Where(predicate);
        }

        public IEnumerable<Stewardess> GetAll()
        {
            return _airportContext.Stewardesses;
        }

        public Stewardess GetById(int id)
        {
            return _airportContext.Stewardesses?.FirstOrDefault(t => t.Id == id);
        }

        public Stewardess Update(Stewardess entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Stewardesses?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Stewardesses.Remove(updatedEntity) != null)
            {
                _airportContext.Stewardesses.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
