using System;
using System.Collections.Generic;
using AirportRESRfulApi.DAL.Models;

namespace AirportRESRfulApi.DAL.Interfaces
{
    public interface ITicketRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
    }
}
