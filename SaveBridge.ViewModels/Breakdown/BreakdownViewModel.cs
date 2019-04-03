using System;

namespace SaveBridge.ViewModels.Breakdown
{
    public class BreakdownViewModel
    {
        public Guid Id { get; set; }

        public Guid BuildingConstructionId { get; set; }

        public string Reason { get; set; }

        public double BreakdownPercent { get; set; }
    }
}