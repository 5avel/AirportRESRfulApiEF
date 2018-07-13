using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportRESRfulApi.DAL 
{
    public class PlaneTypsRepository : IRepository<PlaneType>
    {
        private AirportContext _airportContext;
        public PlaneTypsRepository(AirportContext airportContext)
        {
            _airportContext = airportContext;
        }

        public PlaneType Create(PlaneType entity)
        {
            _airportContext.PlaneTypes.Add(entity);
            _airportContext.SaveChanges();
            return entity;
        }

        public IEnumerable<PlaneType> Create(IEnumerable<PlaneType> entitys)
        {
            _airportContext.PlaneTypes.AddRange(entitys);
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.PlaneTypes.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.PlaneTypes.Remove(itemToRemove) != null;
        }

        public bool Delete(PlaneType entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<PlaneType> Find(Func<PlaneType, bool> predicate)
        {
            return _airportContext.PlaneTypes?.Where(predicate);
        }

        public IEnumerable<PlaneType> GetAll()
        {
            return _airportContext.PlaneTypes;
        }

        public PlaneType GetById(int id)
        {
            return _airportContext.PlaneTypes?.FirstOrDefault(t => t.Id == id);
        }

        public PlaneType Update(PlaneType entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.PlaneTypes?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if (_airportContext.PlaneTypes.Remove(updatedEntity) != null)
            {
                _airportContext.PlaneTypes.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
