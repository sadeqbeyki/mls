﻿using AppFramework.Application;
using AppFramework.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppFramework.Infrastructure
{
    public class BaseRepository<TKey, TEntity> : IBaseRepository<TKey, TEntity>
        where TEntity : BaseEntity, new()
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return (entity);
        }

        public void Delete(int key)
        {
            TEntity entity = new()
            {
                Id = key
            };
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

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


    }
}
