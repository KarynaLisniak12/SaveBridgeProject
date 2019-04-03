using System;
using System.Collections.Generic;
using System.Linq;
using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class BuildingConstructionRepository : BaseRepository<BuildingConstruction>, IBuildingConstructionRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public BuildingConstructionRepository(SaveBridgeContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BuildingConstruction> GetByCityId(Guid id)
        {
            var buildings = _dbContext.BuildingConstructions
                .Where(item => item.CityId == id);
            return buildings;
        }
    }
}