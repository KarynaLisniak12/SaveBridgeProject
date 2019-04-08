using SaveBridge.ViewModels.Pressure;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IPressureService
    {
        void Create(CreatePressureViewModel pressure);

        IEnumerable<PressureViewModel> GetByBuildingConstructionId(Guid id);
    }
}