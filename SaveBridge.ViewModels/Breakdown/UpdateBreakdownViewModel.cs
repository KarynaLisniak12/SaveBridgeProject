using System;

namespace SaveBridge.ViewModels.Breakdown
{
    public class UpdateBreakdownViewModel
    {
        public Guid Id { get; set; }

        public Guid BuildingConstructionId { get; set; }

        public string Reason { get; set; }
    }
}