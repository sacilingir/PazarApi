using Microsoft.EntityFrameworkCore;
using PazarApi.Application.Interfaces.Repositories;
using PazarApi.Domain.Common;

namespace PazarApi.Persistence.Repositories
{
    public class WriteRepository<T>:IWriteRepository<T> where T : class,IEntityBase,new()
    {
        private readonly DbContext dbContext;
        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public async Task HardUpdateAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
    }
}
