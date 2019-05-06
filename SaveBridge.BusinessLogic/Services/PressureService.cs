using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Pressure;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services
{
    public class PressureService : IPressureService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public PressureService(IMapper mapper, IUnitOfWorks unitOfWorks)
        {
            _mapper = mapper;
            _unitOfWorks = unitOfWorks;
        }

        public void Create(CreatePressureViewModel model)
        {
            Pressure pressure = _mapper.Map<CreatePressureViewModel, Pressure>(model);

            _unitOfWorks.PressureRepository.Add(pressure);
            _unitOfWorks.Save();
        }

        public IEnumerable<PressureViewModel> GetByBuildingConstructionId(Guid id)
        {
            var result = _unitOfWorks.PressureRepository.GetByBuildingConstructionId(id);

            var pressures = _mapper.Map<IEnumerable<Pressure>, IEnumerable<PressureViewModel>>(result);
            return pressures;
        }
    }
}