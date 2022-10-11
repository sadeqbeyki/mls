using Framework.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Framework.DAL
{
    public class RepositoryBase<TKey, TEntity> : IBaseRepository<TKey, TEntity>
        where TEntity : EntityBase, new()
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            //dbset entity in context
            //_dbContext.Set<TEntity>().Add(entity);
            //_dbContext.SaveChanges();
            //return entity;
            _dbContext.Add(entity);
        }

        //public void Delete(int id)
        //{
            //TEntity entity = new TEntity
            //{
            //    Id = id
            //};
            //_dbContext.Remove();
            //_dbContext.SaveChanges();

        //}

        public bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Any(predicate);
        }

        public TEntity? Get(TKey key)
        {
            return _dbContext.Find<TEntity>(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }
        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }
    }
}
