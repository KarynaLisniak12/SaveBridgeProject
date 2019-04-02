using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaveBridge.DataAccess.Repositories
{
    public class RenovationRepository : BaseRepository<Renovation>, IRenovationRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public RenovationRepository(SaveBridgeContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Renovation> GetByBuildingConstructionId(Guid id)
        {
            var renovations = _dbContext.Renovations
                .Where(item => item.BuildingConstructionId == id);
            return renovations;
        }
    }
}