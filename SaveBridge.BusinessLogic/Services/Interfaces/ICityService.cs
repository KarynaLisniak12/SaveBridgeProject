using SaveBridge.ViewModels.City;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface ICityService
    {
        void Create(CreateCityViewModel city);

        IEnumerable<CityViewModel> GetByCountryId(Guid id);

        void Delete(Guid id);
    }
}