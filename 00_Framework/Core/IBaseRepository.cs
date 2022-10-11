using System.Linq.Expressions;

namespace Framework.Core
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : EntityBase, new()
    {
        //TEntity Add(TEntity entity);
        void Add(TEntity entity);
        TEntity? Get(TKey key);
        IQueryable<TEntity> GetAll();
        bool Exists(Expression<Func<TEntity, bool>> predicate);
        //void Delete(int id);
        void SaveChange();
    }
}
