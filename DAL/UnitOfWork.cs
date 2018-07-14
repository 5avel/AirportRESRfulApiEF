using System;
using System.Reflection;
using System.Threading.Tasks;
using AirportRESRfulApi.DAL.Interfaces;
using AirportRESRfulApi.DAL.Models;

namespace AirportRESRfulApi.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AirportContext context;

        public UnitOfWork(AirportContext context)
        {
            this.context = context;
        }
        

        public int SaveChages()
        {
            return context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public IRepository<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return new Repository<TEntity>(context);
        }

        public T GetRepository<T>() where T : IRepository<Entity>
        {
            foreach (Type type in this.GetType().GetTypeInfo().Assembly.GetTypes())
            {
                if (typeof(T).GetTypeInfo().IsAssignableFrom(type) && type.GetTypeInfo().IsClass)
                {
                    T repository = (T)Activator.CreateInstance(type);

                    //repository.SetStorageContext(this.StorageContext);
                    return repository;
                }
            }

            return default(T);
        }
    }
}
