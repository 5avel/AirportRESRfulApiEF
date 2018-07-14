using AirportRESRfulApi.DAL.Models;
using System.Threading.Tasks;

namespace AirportRESRfulApi.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Set<TEntity>() where TEntity : Entity;

        int SaveChages();

        Task<int> SaveChangesAsync();

        T GetRepository<T>() where T : IRepository<Entity>;
    }
}
