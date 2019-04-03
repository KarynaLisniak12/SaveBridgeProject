using System;
using System.Collections.Generic;
using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.BuildingConstruction;

namespace SaveBridge.BusinessLogic.Services
{
    public class BuildingConstructionService : IBuildingConstructionService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;

        public BuildingConstructionService(IUnitOfWorks unitOfWorks, IMapper mapper)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
        }

        public void Create(CreateBuildingViewModel model)
        {
            BuildingConstruction buildingConstruction = _mapper
                .Map<CreateBuildingViewModel, BuildingConstruction>(model);

            _unitOfWorks.BuildingConstructionRepository.Add(buildingConstruction);
        }

        public IEnumerable<BuildingViewModel> GetByCityId(Guid id)
        {
            var buildings = _unitOfWorks.BuildingConstructionRepository.GetByCityId(id);

            var result = _mapper.Map<IEnumerable<BuildingConstruction>, 
                IEnumerable<BuildingViewModel>>(buildings);
            return result;
        }

        public void Update(UpdateBuildingViewModel model)
        {
            var buildingConstruction = _mapper.Map<UpdateBuildingViewModel, 
                BuildingConstruction>(model);

            _unitOfWorks.BuildingConstructionRepository.Update(buildingConstruction);
        }

        public void Delete(Guid id)
        {
            _unitOfWorks.BuildingConstructionRepository.Delete(id);
        }
    }
}