using System.Collections.Generic;

namespace SaveBridge.Entities
{
    public class BuildingConstructionType : Base
    {
        public string Title { get; set; }

        public virtual IEnumerable<BuildingConstruction> BuildingConstructions { get; set; }
    }
}