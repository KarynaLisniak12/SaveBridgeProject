using System;

namespace SaveBridge.ViewModels.BuildingConstruction
{
    public class UpdateBuildingViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public Guid CityId { get; set; }
    }
}