using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdventureWorks.Common.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<int> Commit();

        Task<TEntity> Get<TEntityId>(TEntityId id) where TEntityId : struct;
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> Add(TEntity entity);
        Task<IEnumerable<TEntity>> AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
