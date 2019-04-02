using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaveBridge.DataAccess.Repositories
{
    public class VibrationRepository : BaseRepository<Vibration>, IVibrationRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public VibrationRepository(SaveBridgeContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Vibration> GetByBuildingConstructionId(Guid id)
        {
            var vibrationValues = _dbContext.Vibrations
                .Where(item => item.BuildingConstructionId == id);
            return vibrationValues;
        }
    }
}