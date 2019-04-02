using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge.DataAccess.EF.Interfaces
{
    public interface IUnitOfWorks
    {
        IBuildingConstructionRepository BuildingConstructionRepository { get; set; }

        void Save();
    }
}