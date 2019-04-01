using System;

namespace SaveBridge.Entities
{
    public class Breakdown : Base
    {
        public Guid BuildingConstructionId { get; set; }

        public string Reason { get; set; }

        public double BreakdownPercent { get; set; }

        public BuildingConstruction BuildingConstruction { get; set; }
    }
}