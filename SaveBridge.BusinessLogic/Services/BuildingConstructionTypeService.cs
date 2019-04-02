using AutoMapper;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.Entities;
using SaveBridge.ViewModels.BuildingConstructionType;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services
{
    public class BuildingConstructionTypeService : IBuildingConstructionTypeService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;

        public BuildingConstructionTypeService(IUnitOfWorks unitOfWorks, IMapper mapper)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
        }

        public void Create(CreateBuildingTypeViewModel model)
        {
            BuildingConstructionType buildingConstructionType = _mapper
                .Map<CreateBuildingTypeViewModel, BuildingConstructionType>(model);

            _unitOfWorks.BuildingConstructionTypeRepository.Add(buildingConstructionType);
        }

        public IEnumerable<BuildingTypeViewModel> GetAll()
        {
            var result = _unitOfWorks.BuildingConstructionTypeRepository.GetAll();
            
            var buildingTypes = _mapper.Map<IEnumerable<BuildingConstructionType>, 
                IEnumerable<BuildingTypeViewModel>>(result);
            return buildingTypes;
        }

        public void Delete(Guid id)
        {
            _unitOfWorks.BuildingConstructionTypeRepository.Delete(id);
        }

        public void Update(UpdateBuildingTypeViewModel model)
        {
            var buildingConstructionType = _mapper.Map<UpdateBuildingTypeViewModel, 
                BuildingConstructionType>(model);

            _unitOfWorks.BuildingConstructionTypeRepository.Update(buildingConstructionType);
        }
    }
}