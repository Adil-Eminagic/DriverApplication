

using DrivingApp.Core;

namespace DrivingApp.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntity, in TPrimaryKey> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default);

        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        Task RemoveByIdAsync(TPrimaryKey id, bool isSoft = true, CancellationToken cancellationToken = default);//directly removes

    }
}

//We add cancellation token in async methods, it allows to cancel method when user close tab of application
//If i have understood well we put IEnumerbale interface beacuse thher will come list which won't allow to change data
//of objects in list
//We don't have to specify access modifiers in interface
//Methods which are not Task cann't be async
