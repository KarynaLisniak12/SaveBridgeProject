using System;
using System.Collections.Generic;

namespace SaveBridge.Entities
{
    public class BuildingConstruction : Base
    {
        public Guid BuildingConstructionTypeId { get; set; }

        public string Title { get; set; }

        public Guid CityId { get; set; }

        public string Address { get; set; }

        public double CurrentBreakdownPercent { get; set; }

        public City City { get; set; }

        public virtual BuildingConstructionType BuildingConstructionType { get; set; }

        public virtual IEnumerable<Breakdown> Breakdowns { get; set; }

        public virtual IEnumerable<Renovation> Renovations { get; set; }

        public virtual IEnumerable<Pressure> Pressures { get; set; }

        public virtual IEnumerable<Vibration> Vibrations { get; set; }
    }
}