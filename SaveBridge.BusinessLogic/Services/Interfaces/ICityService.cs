using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface ICityService
    {
        void Create(City city);

        IEnumerable<City> GetAll();

        void Delete(Guid id);
    }
}