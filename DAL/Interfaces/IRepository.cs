using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AirportRESRfulApi.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);
        void Create(TEntity entity, string createdBy = null);
        void Create(IEnumerable<TEntity> entitys, string createdBy = null);
        void Update(TEntity entity, string modifiedBy = null);
        void Delete(object id);
        void Delete(TEntity entity);
    }
}
