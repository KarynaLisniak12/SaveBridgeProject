using System;
using System.Collections.Generic;
using SaveBridge.Entities;
using SaveBridge.ViewModels.City;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface ICityService
    {
        void Create(CreateCityViewModel city);

        IEnumerable<CityViewModel> GetAll();

        void Delete(Guid id);
    }
}