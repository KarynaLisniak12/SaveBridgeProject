using System;

namespace SaveBridge.ViewModels.Pressure
{
    public class CreatePressureViewModel
    {
        public Guid BuildingConstructionId { get; set; }

        public double Value { get; set; }

        public DateTime MeasurementDate { get; set; }
    }
}