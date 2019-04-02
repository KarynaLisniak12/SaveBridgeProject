using System;
using System.Collections.Generic;
using SaveBridge.Entities;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IRenovationService
    {
        void Create(Renovation breakdown);

        IEnumerable<Renovation> GetByBuildingConstructionId(Guid id);

        void Update(Renovation breakdown);
    }
}