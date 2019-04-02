using SaveBridge.Entities;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IBuildingConstructionTypeService
    {
        void Create(BuildingConstructionType buildingConstructionType);

        IEnumerable<BuildingConstructionType> GetAll();

        void Delete(Guid id);

        void Update(BuildingConstructionType buildingConstructionType);
    }
}