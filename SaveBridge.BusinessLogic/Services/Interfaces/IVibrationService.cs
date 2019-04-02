using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IVibrationService
    {
        void Create(Vibration pressure);

        IEnumerable<Vibration> GetByBuildingConstructionId(Guid id);
    }
}