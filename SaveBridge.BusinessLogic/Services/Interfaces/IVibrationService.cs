using SaveBridge.ViewModels.Vibration;
using System;
using System.Collections.Generic;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IVibrationService
    {
        void Create(CreateVibrationViewModel pressure);

        IEnumerable<VibrationViewModel> GetByBuildingConstructionId(Guid id);
    }
}