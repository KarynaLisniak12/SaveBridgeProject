using System;

namespace SaveBridge.ViewModels.Vibration
{
    public class VibrationViewModel
    {
        public Guid Id { get; set; }

        public Guid BuildingConstructionId { get; set; }

        public double Value { get; set; }

        public DateTime MeasurementDate { get; set; }
    }
}