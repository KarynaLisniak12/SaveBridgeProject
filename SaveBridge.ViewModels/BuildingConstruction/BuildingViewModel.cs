using System;

namespace SaveBridge.ViewModels.BuildingConstruction
{
    public class BuildingViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public double BreakdownPercent { get; set; }
    }
}