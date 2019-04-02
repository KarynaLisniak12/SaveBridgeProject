using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IVibrationRepository
    {
        void Add(Vibration pressure);

        IEnumerable<Vibration> GetByBuildingConstructionId(Guid id);
    }
}