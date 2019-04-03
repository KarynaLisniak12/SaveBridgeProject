using SaveBridge.ViewModels.Breakdown;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IBreakdownService
    {
        void Create(CreateBreakdownViewModel breakdown);

        IEnumerable<BreakdownViewModel> GetByBuildingConstructionId(Guid id);

        void Update(UpdateBreakdownViewModel breakdown);
    }
}