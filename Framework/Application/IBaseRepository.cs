using AppFramework.Domain;
using System.Linq.Expressions;

namespace AppFramework.Application
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : BaseEntity, new()
    {
        TEntity Add(TEntity entity);
        TEntity? Get(TKey key);
        IQueryable<TEntity> GetAll();
        bool Exists(Expression<Func<TEntity, bool>> predicate);
        TEntity Update(TEntity entity);
        void Delete(int key);
        //void SaveChange();
    }
}
