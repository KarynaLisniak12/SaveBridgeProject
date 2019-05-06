using System;

namespace SaveBridge.ViewModels.BuildingConstruction
{
    public class BuildingViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public string CityId { get; set; }

        public string Address { get; set; }

        public double CurrentBreakdownPercent { get; set; }
    }
}