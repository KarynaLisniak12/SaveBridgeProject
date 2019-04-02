using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IBreakdownService
    {
        void Create(Breakdown breakdown);

        IEnumerable<Breakdown> GetByBuildingConstructionId(Guid id);

        void Update(Breakdown breakdown);
    }
}