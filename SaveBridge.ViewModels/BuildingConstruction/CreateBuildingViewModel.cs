using System;

namespace SaveBridge.ViewModels.BuildingConstruction
{
    public class CreateBuildingViewModel
    {
        public string Title { get; set; }

        public Guid CityId { get; set; }

        public string Address { get; set; }
    }
}