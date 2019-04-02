using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> 
        where T : class
    {
        private readonly SaveBridgeContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(SaveBridgeContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public void Update(T item)
        {
            _dbSet.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            T item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
        }
    }
}