using System;

namespace SaveBridge.ViewModels.Vibration
{
    public class CreateVibrationViewModel
    {
        public Guid BuildingConstructionId { get; set; }

        public double Value { get; set; }

        public DateTime MeasurementDate { get; set; }
    }
}