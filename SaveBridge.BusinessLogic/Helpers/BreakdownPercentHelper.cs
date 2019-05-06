using System.Linq;
using SaveBridge.BusinessLogic.Constants;
using SaveBridge.BusinessLogic.Models;

namespace SaveBridge.BusinessLogic.Helpers
{
    public static class BreakdownPercentHelper
    {
        public static double CountBreakdownPercent(double pressureValue, double vibrationValue)
        {
            if (IsAbsoluteBreakdownPercent(pressureValue, vibrationValue))
            {
                return 100;
            }

            BoundaryState highPressureLimit = GetBreakdownPercentRange(pressureValue, true);
            BoundaryState highVibrationLimit = GetBreakdownPercentRange(vibrationValue, false);

            double breakdownPressurePercent = (pressureValue * highPressureLimit.Percent) / highPressureLimit.Value;
            double breakdownVibrationPercent = (vibrationValue * highVibrationLimit.Percent) / highVibrationLimit.Value;

            double breakdownPercent = (breakdownVibrationPercent + breakdownPressurePercent) / 2;
            return breakdownPercent;
        }

        private static bool IsAbsoluteBreakdownPercent(double pressureValue, double vibrationValue)
        {
            if (pressureValue <= ConstantsDimension.MinPressureValue ||
                vibrationValue <= ConstantsDimension.MinVibrationValue ||
                pressureValue >= ConstantsDimension.MaxPressureValue ||
                vibrationValue >= ConstantsDimension.MaxVibrationValue)
            {
                return true;
            }
            return false;
        }

        private static BoundaryState GetBreakdownPercentRange(double pressureValue, bool isPressure)
        {
            BoundaryState highLimit = null;

            var boundaryStates = isPressure ? ConstantsDimension.BreakdownPressureBoundaryStates
                : ConstantsDimension.BreakdownVibrationBoundaryStates;
            boundaryStates = boundaryStates.OrderBy(item => item.Value).ToList();

            foreach (var state in boundaryStates)
            {
                if (pressureValue <= state.Value)
                {
                    highLimit = state;
                    break;
                }
            }
            return highLimit;
        }
    }
}