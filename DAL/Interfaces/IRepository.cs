using AirportRESRfulApi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AirportRESRfulApi.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate);
        TEntity Create(TEntity entity);
        IEnumerable<TEntity> Create( IEnumerable<TEntity> entitys);
        TEntity Update(TEntity entity);
        bool Delete(int id);
        bool Delete(TEntity entity);
    }
}
