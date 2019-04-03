using SaveBridge.ViewModels.BuildingConstructionType;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IBuildingConstructionTypeService
    {
        void Create(CreateBuildingTypeViewModel buildingConstructionType);

        IEnumerable<BuildingTypeViewModel> GetAll();

        void Delete(Guid id);

        void Update(UpdateBuildingTypeViewModel buildingConstructionType);
    }
}