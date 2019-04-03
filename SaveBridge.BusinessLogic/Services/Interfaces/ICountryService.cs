using SaveBridge.ViewModels.Country;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface ICountryService
    {
        void Create(CreateCountryViewModel country);

        IEnumerable<CountryViewModel> GetAll();

        void Delete(Guid id);
    }
}