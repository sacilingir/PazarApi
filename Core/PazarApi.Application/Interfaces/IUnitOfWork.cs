using PazarApi.Application.Interfaces.Repositories;
using PazarApi.Domain.Common;

namespace PazarApi.Application.Interfaces
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T:class,IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
