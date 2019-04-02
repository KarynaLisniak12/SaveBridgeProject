using System;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IBuildingConstructionRepository
    {
        void Add(BuildingConstruction buildingConstruction);

        BuildingConstruction GetById(Guid id);

        void Update(BuildingConstruction buildingConstruction);

        void Delete(Guid id);
    }
}