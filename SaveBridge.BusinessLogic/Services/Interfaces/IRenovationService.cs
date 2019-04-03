using SaveBridge.ViewModels.Renovation;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IRenovationService
    {
        void Create(CreateRenovationViewModel breakdown);

        IEnumerable<RenovationViewModel> GetByBuildingConstructionId(Guid id);

        void Update(UpdateRenovationViewModel breakdown);
    }
}