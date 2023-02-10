using DrivingApp.Core;
using DrivingApp.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrivingApp.Infrastructure
{
    public abstract class BaseRepository<TEntity, TPrimaryKey> : IBaseRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity
    { // you need efcore nutget package to have dbContext class, and confgure dbsets in separate class

        protected readonly DatabaseContext DatabaseContext; //convention to private var with _databaseContext
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
            DbSet = DatabaseContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await DbSet.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await DbSet.AddRangeAsync(entities, cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default)
        {
            return await DbSet.FindAsync(id, cancellationToken);
        }

        public void Remove(TEntity entity)
        {
             DbSet.Remove(entity);
        }

        public async Task RemoveByIdAsync(TPrimaryKey id, bool isSoft = true, CancellationToken cancellationToken = default)
        {

            throw new NotImplementedException();
            //todo: 

            //await DbSet.Where(e => e.Id.Equals(id)).ExecuteDeleteAsync(cancellationToken);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            DbSet.UpdateRange(entities);
        }
    }
}
