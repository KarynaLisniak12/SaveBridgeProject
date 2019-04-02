using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaveBridge.DataAccess.Repositories
{
    public class PressureRepository : BaseRepository<Pressure>, IPressureRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public PressureRepository(SaveBridgeContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pressure> GetByBuildingConstructionId(Guid id)
        {
            var pressureValues = _dbContext.Pressures
                .Where(item => item.BuildingConstructionId == id);
            return pressureValues;
        }
    }
}