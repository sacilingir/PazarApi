using PazarApi.Domain.Common;

namespace PazarApi.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class,IEntityBase,new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task HardUpdateAsync(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
