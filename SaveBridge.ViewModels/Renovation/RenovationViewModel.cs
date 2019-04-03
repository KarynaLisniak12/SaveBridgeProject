using System;

namespace SaveBridge.ViewModels.Renovation
{
    public class RenovationViewModel
    {
        public Guid Id { get; set; }

        public Guid BuildingConstructionId { get; set; }

        public DateTime MeasurementDate { get; set; }

        public string Description { get; set; }
    }
}