using System.Collections.Generic;

namespace SaveBridge.Entities
{
    public class Country : Base
    {
        public string Title { get; set; }

        public virtual IEnumerable<City> Cities { get; set; }
    }
}