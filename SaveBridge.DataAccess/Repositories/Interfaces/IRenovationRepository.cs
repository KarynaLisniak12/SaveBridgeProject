using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IRenovationRepository
    {
        void Add(Renovation breakdown);

        IEnumerable<Renovation> GetByBuildingConstructionId(Guid id);

        void Update(Renovation breakdown);
    }
}