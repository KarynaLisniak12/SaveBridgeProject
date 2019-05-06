using System;
using System.Collections.Generic;
using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Renovation;

namespace SaveBridge.BusinessLogic.Services
{
    public class RenovationService : IRenovationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public RenovationService(IMapper mapper, IUnitOfWorks unitOfWorks)
        {
            _mapper = mapper;
            _unitOfWorks = unitOfWorks;
        }

        public void Create(CreateRenovationViewModel model)
        {
            var breakdown = _mapper.Map<CreateRenovationViewModel, Renovation>(model);

            _unitOfWorks.RenovationRepository.Add(breakdown);
            _unitOfWorks.Save();
        }

        public IEnumerable<RenovationViewModel> GetByBuildingConstructionId(Guid id)
        {
            var result = _unitOfWorks.RenovationRepository.GetByBuildingConstructionId(id);

            var renovations = _mapper.Map<IEnumerable<Renovation>, 
                IEnumerable<RenovationViewModel>>(result);
            return renovations;
        }

        public void Update(UpdateRenovationViewModel model)
        {
            var renovations = _mapper.Map<UpdateRenovationViewModel, Renovation>(model);

            _unitOfWorks.RenovationRepository.Update(renovations);
            _unitOfWorks.Save();
        }
    }
}