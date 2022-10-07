using Framework.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Framework.DAL
{
    public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly DbContext _dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T item)
        {
           _dbContext.Add(item);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Any(predicate);
        }

        public T Get(TKey key)
        {
            return _dbContext.Find<T>(key);
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }
    }
}
