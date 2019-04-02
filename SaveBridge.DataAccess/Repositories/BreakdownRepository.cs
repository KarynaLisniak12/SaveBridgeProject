using System;
using System.Collections.Generic;
using System.Linq;
using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class BreakdownRepository : BaseRepository<Breakdown>, IBreakdownRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public BreakdownRepository(SaveBridgeContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Breakdown> GetByBuildingConstructionId(Guid id)
        {
            var breakdowns = _dbContext.Breakdowns
                .Where(item => item.BuildingConstructionId == id);
            return breakdowns;
        }
    }
}