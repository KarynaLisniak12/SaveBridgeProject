using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface ICountryService
    {
        void Create(Country country);

        IEnumerable<Country> GetAll();

        void Delete(Guid id);
    }
}