using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IBuildingConstructionTypeRepository
    {
        void Add(BuildingConstructionType buildingConstructionType);

        IEnumerable<BuildingConstructionType> GetAll();

        void Delete(Guid id);

        void Update(BuildingConstructionType buildingConstructionType);
    }
}