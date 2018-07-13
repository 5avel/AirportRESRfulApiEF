using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL 
{
    public class PlaneTypsRepository : IRepository<PlaneType>
    {
        private IAirportContext _airportContext;
        public PlaneTypsRepository(IAirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public PlaneType Create(PlaneType entity)
        {
            _airportContext.PlaneTyps.Add(entity);
            return entity;
        }

        public IEnumerable<PlaneType> Create(IEnumerable<PlaneType> entitys)
        {
            _airportContext.PlaneTyps.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.PlaneTyps.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.PlaneTyps.Remove(itemToRemove);
        }

        public bool Delete(PlaneType entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<PlaneType> Find(Func<PlaneType, bool> predicate)
        {
            return _airportContext.PlaneTyps?.Where(predicate);
        }

        public IEnumerable<PlaneType> GetAll()
        {
            return _airportContext.PlaneTyps;
        }

        public PlaneType GetById(int id)
        {
            return _airportContext.PlaneTyps?.FirstOrDefault(t => t.Id == id);
        }

        public PlaneType Update(PlaneType entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.PlaneTyps?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.PlaneTyps.Remove(updatedEntity))
            {
                _airportContext.PlaneTyps.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
