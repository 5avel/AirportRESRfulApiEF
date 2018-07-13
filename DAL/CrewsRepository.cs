using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class CrewsRepository : IRepository<Crew>
    {
        private IAirportContext _airportContext;
        public CrewsRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Crew Create(Crew entity)
        {
            _airportContext.Crews.Add(entity);
            return entity;
        }

        public IEnumerable<Crew> Create(IEnumerable<Crew> entitys)
        {
            _airportContext.Crews.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Crews.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Crews.Remove(itemToRemove);
        }

        public bool Delete(Crew entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Crew> Find(Func<Crew, bool> predicate)
        {
            return _airportContext.Crews?.Where(predicate);
        }

        public IEnumerable<Crew> GetAll()
        {
            return _airportContext.Crews;
        }

        public Crew GetById(int id)
        {
            return _airportContext.Crews?.FirstOrDefault(t => t.Id == id);
        }

        public Crew Update(Crew entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Crews?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Crews.Remove(updatedEntity))
            {
                _airportContext.Crews.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
