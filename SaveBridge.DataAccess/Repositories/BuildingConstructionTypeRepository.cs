using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class BuildingConstructionTypeRepository : BaseRepository<BuildingConstructionType>, IBuildingConstructionTypeRepository
    {
        public BuildingConstructionTypeRepository(SaveBridgeContext dbContext) : base(dbContext)
        {

        }
    }
}