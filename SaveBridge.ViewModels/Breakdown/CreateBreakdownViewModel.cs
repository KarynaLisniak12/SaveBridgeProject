using System;

namespace SaveBridge.ViewModels.Breakdown
{
    public class CreateBreakdownViewModel
    {
        public Guid BuildingConstructionId { get; set; }

        public string Reason { get; set; }
    }
}