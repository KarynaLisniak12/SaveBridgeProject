using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.ViewModels.Country;
using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public void Create(CreateCountryViewModel model)
        {
            var country = _mapper.Map<CreateCountryViewModel, Country>(model);

            _unitOfWorks.CountryRepository.Add(country);
        }

        public IEnumerable<CountryViewModel> GetAll()
        {
            var result = _unitOfWorks.CountryRepository.GetAll();

            var countries = _mapper.Map<IEnumerable<Country>, 
                IEnumerable<CountryViewModel>>(result);
            return countries;
        }

        public void Delete(Guid id)
        {
            _unitOfWorks.CountryRepository.Delete(id);
        }
    }
}