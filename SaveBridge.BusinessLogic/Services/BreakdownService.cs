using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Breakdown;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services
{
    public class BreakdownService : IBreakdownService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _unitOfWorks;

        public BreakdownService(IMapper mapper, IUnitOfWorks unitOfWorks)
        {
            _mapper = mapper;
            _unitOfWorks = unitOfWorks;
        }

        public void Create(CreateBreakdownViewModel model)
        {
            var breakdown = _mapper.Map<CreateBreakdownViewModel, 
                Breakdown>(model);

            _unitOfWorks.BreakdownRepository.Add(breakdown);
        }

        public IEnumerable<BreakdownViewModel> GetByBuildingConstructionId(Guid id)
        {
            var result = _unitOfWorks.BreakdownRepository.GetByBuildingConstructionId(id);

            var breakdowns = _mapper.Map<IEnumerable<Breakdown>, 
                IEnumerable<BreakdownViewModel>>(result);
            return breakdowns;
        }

        public void Update(UpdateBreakdownViewModel model)
        {
            var breakdown = _mapper.Map<UpdateBreakdownViewModel, Breakdown>(model);

            _unitOfWorks.BreakdownRepository.Update(breakdown);
        }
    }
}