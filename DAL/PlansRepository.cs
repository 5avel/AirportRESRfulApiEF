using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL
{
    public class PlansRepository : IRepository<Plane>
    {
        private IAirportContext _airportContext;
        public PlansRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public Plane Create(Plane entity)
        {
            _airportContext.Planes.Add(entity);
            return entity;
        }

        public IEnumerable<Plane> Create(IEnumerable<Plane> entitys)
        {
            _airportContext.Planes.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Planes.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Planes.Remove(itemToRemove);
        }

        public bool Delete(Plane entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Plane> Find(Func<Plane, bool> predicate)
        {
            return _airportContext.Planes?.Where(predicate);
        }

        public IEnumerable<Plane> GetAll()
        {
            return _airportContext.Planes;
        }

        public Plane GetById(int id)
        {
            return _airportContext.Planes?.FirstOrDefault(t => t.Id == id);
        }

        public Plane Update(Plane entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Planes?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.Planes.Remove(updatedEntity))
            {
                _airportContext.Planes.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
