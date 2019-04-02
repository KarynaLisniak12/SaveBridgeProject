using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class BuildingConstructionRepository : BaseRepository<BuildingConstruction>, IBuildingConstructionRepository
    {
        public BuildingConstructionRepository(SaveBridgeContext dbContext) 
            : base(dbContext)
        {
            
        }
    }
}