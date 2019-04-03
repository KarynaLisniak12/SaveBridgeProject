using System;

namespace SaveBridge.ViewModels.Renovation
{
    public class CreateRenovationViewModel
    {
        public Guid BuildingConstructionId { get; set; }

        public DateTime MeasurementDate { get; set; }

        public string Description { get; set; }
    }
}