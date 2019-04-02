using System;
using System.Collections.Generic;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T item);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Update(T item);

        void Delete(Guid id);
    }
}