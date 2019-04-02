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

        public void CreateBuildingConstruction(CreateBuildingConstruction model)
        {
            BuildingConstruction buildingConstruction = _mapper
                .Map<CreateBuildingConstruction, BuildingConstruction>(model);

            _unitOfWorks.BuildingConstructionRepository.Add(buildingConstruction);
        }
    }
}