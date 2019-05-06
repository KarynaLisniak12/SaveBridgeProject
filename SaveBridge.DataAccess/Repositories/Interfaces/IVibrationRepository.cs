using SaveBridge.Entities;
using System;
using System.Collections.Generic;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IVibrationRepository
    {
        void Add(Vibration pressure);

        IEnumerable<Vibration> GetByBuildingConstructionId(Guid id);

        Vibration GetLastByBuildingId(Guid id);
    }
}