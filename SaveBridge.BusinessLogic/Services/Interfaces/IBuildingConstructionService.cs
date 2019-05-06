using SaveBridge.ViewModels.BuildingConstruction;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IBuildingConstructionService
    {
        void Create(CreateBuildingViewModel buildingConstruction);

        IEnumerable<BuildingViewModel> GetAll();

        IEnumerable<BuildingViewModel> GetByCityId(Guid id);

        void Update(UpdateBuildingViewModel buildingConstruction);

        void Delete(Guid id);
    }
}