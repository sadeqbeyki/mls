using System.Linq.Expressions;

namespace Framework.Core
{
    public interface IRepository<TKey, T> where T : class
    {
        T Get(TKey key);
        List<T> GetAll();
        void Add(T item);
        bool Exists(Expression<Func<T, bool>> predicate);
        void SaveChange();
    }
}
