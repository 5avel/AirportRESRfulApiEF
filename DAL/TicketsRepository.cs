using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AirportRESRfulApi.DAL
{
    public class TicketsRepository : IRepository<Ticket>
    {
        private AirportContext _airportContext;
        public TicketsRepository(AirportContext context)
        {
            _airportContext = context;
        }
        public Ticket Create(Ticket entity)
        {
            _airportContext.Tickets.Add(entity);
            _airportContext.SaveChanges();
            return entity;
        }

        public IEnumerable<Ticket> Create(IEnumerable<Ticket> entitys)
        {
            _airportContext.Tickets.AddRange(entitys);
            _airportContext.SaveChanges();
            return entitys;
        }

        public bool Delete(int id)
        {
            var itemToRemove = _airportContext.Tickets.FirstOrDefault(t => t.Id == id);
            if (itemToRemove == null) return false;
            return _airportContext.Tickets.Remove(itemToRemove) != null;
        }

        public bool Delete(Ticket entity)
        {
            if (entity == null) return false;
            return Delete(entity.Id);
        }

        public IEnumerable<Ticket> Find(Func<Ticket, bool> predicate)
        {
            return _airportContext.Tickets?.Where(predicate);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _airportContext.Tickets;
        }

        public Ticket GetById(int id)
        {
            return _airportContext.Tickets?.FirstOrDefault(t => t.Id == id);
        }

        public Ticket Update(Ticket entity)
        {
            if (entity == null) return null;

            var updatedEntity = _airportContext.Tickets?.FirstOrDefault(t => t.Id == entity.Id);
            if (updatedEntity == null) return null;

            if(_airportContext.Tickets.Remove(updatedEntity) != null)
            {
                _airportContext.Tickets.Add(entity);
                return entity;
            }
            return null;
        }
    }
}
