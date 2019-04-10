using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IBuildingConstructionRepository
    {
        void Add(BuildingConstruction buildingConstruction);

        IEnumerable<BuildingConstruction> GetByCityId(Guid id);

        BuildingConstruction GetById(Guid id);

        void Update(BuildingConstruction buildingConstruction);

        void Delete(Guid id);
    }
}