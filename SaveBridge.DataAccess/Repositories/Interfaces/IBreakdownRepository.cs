using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories.Interfaces
{
    public interface IBreakdownRepository
    {
        void Add(Breakdown breakdown);

        IEnumerable<Breakdown> GetByBuildingConstructionId(Guid id);

        void Update(Breakdown breakdown);
    }
}