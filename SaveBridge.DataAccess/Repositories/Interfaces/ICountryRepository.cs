using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface ICountryRepository
    {
        void Add(Country country);

        IEnumerable<Country> GetAll();

        void Delete(Guid id);
    }
}