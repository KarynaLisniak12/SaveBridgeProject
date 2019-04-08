using System;

namespace SaveBridge.ViewModels.Pressure
{
    public class PressureViewModel
    {
        public Guid Id { get; set; }

        public Guid BuildingConstructionId { get; set; }

        public double Value { get; set; }

        public DateTime MeasurementDate { get; set; }
    }
}