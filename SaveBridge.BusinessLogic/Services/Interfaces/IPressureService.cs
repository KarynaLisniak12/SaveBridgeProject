using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IPressureService
    {
        void Create(Pressure pressure);

        IEnumerable<Pressure> GetByBuildingConstructionId(Guid id);
    }
}