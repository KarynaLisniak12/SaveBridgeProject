using System;

namespace SaveBridge.BusinessLogic.Services.Interfaces
{
    public interface IStatisticService
    {
        void GetBuildingBreakdownStatistic(Guid buildingId);

        void GetBreakdownStatistic();

        void GetBuildingTemperatureStatistic(Guid buildingId);

        void GetBuildingVibrationStatistic(Guid buildingId);
    }
}
