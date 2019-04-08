using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Vibration;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services
{
    public class VibrationService : IVibrationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public VibrationService(IMapper mapper, IUnitOfWorks unitOfWorks)
        {
            _mapper = mapper;
            _unitOfWorks = unitOfWorks;
        }

        public void Create(CreateVibrationViewModel model)
        {
            Vibration vibration = _mapper.Map<CreateVibrationViewModel, Vibration>(model);

            _unitOfWorks.VibrationRepository.Add(vibration);
        }

        public IEnumerable<VibrationViewModel> GetByBuildingConstructionId(Guid id)
        {
            var result = _unitOfWorks.VibrationRepository.GetByBuildingConstructionId(id);

            var vibrations = _mapper.Map<IEnumerable<Vibration>, IEnumerable<VibrationViewModel>>(result);
            return vibrations;
        }
    }
}