using System;
using System.Collections.Generic;

namespace SaveBridge.Entities
{
    public class City : Base
    {
        public Guid CountryId { get; set; }

        public string Title { get; set; }

        public virtual Country Country { get; set; }

        public virtual IEnumerable<BuildingConstruction> BuildingConstructions { get; set; }
    }
}