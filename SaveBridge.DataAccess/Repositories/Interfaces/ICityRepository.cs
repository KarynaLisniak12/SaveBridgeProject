using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface ICityRepository
    {
        void Add(City city);

        IEnumerable<City> GetByCountryId(Guid id);

        void Delete(Guid id);
    }
}