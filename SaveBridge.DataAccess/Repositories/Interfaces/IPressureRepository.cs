using SaveBridge.Entities;
using System;
using System.Collections.Generic;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IPressureRepository
    {
        void Add(Pressure pressure);

        IEnumerable<Pressure> GetByBuildingConstructionId(Guid id);

        Pressure GetLastByBuildingId(Guid id);
    }
}