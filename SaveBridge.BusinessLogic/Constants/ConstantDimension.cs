using System.Collections.Generic;
using SaveBridge.BusinessLogic.Models;

namespace SaveBridge.BusinessLogic.Constants
{
    public static class ConstantsDimension
    {
        public const double MinPressureValue = 10;
        public const double MaxPressureValue = 60;

        public const double MinVibrationValue = 10;
        public const double MaxVibrationValue = 60;

        public static readonly List<BoundaryState> BreakdownPressureBoundaryStates = new List<BoundaryState>()
        {
            new BoundaryState()
            {
                Percent = 100,
                Value = 10
            },
            new BoundaryState()
            {
                Percent = 50,
                Value = 25
            },
            new BoundaryState()
            {
                Percent = 50,
                Value = 50
            },
            new BoundaryState()
            {
                Percent = 100,
                Value = 60
            }
        };

        public static readonly List<BoundaryState> BreakdownVibrationBoundaryStates = new List<BoundaryState>()
        {
            new BoundaryState()
            {
                Percent = 100,
                Value = 10
            },
            new BoundaryState()
            {
                Percent = 50,
                Value = 25
            },
            new BoundaryState()
            {
                Percent = 50,
                Value = 50
            },
            new BoundaryState()
            {
                Percent = 100,
                Value = 60
            }
        };
    }
}