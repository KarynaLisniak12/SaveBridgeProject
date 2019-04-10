using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.City;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services
{
    public class CityService : ICityService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public CityService(IMapper mapper, IUnitOfWorks unitOfWorks)
        {
            _mapper = mapper;
            _unitOfWorks = unitOfWorks;
        }

        public void Create(CreateCityViewModel model)
        {
            var city = _mapper.Map<CreateCityViewModel, City>(model);

            _unitOfWorks.CityRepository.Add(city);
            _unitOfWorks.Save();
        }

        public IEnumerable<CityViewModel> GetByCountryId(Guid id)
        {
            var result = _unitOfWorks.CityRepository.GetByCountryId(id);

            var cities = _mapper.Map<IEnumerable<City>, IEnumerable<CityViewModel>>(result);
            return cities;
        }

        public void Delete(Guid id)
        {
            _unitOfWorks.CityRepository.Delete(id);
            _unitOfWorks.Save();
        }
    }
}