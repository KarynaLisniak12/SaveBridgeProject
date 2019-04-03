﻿using System;

namespace SaveBridge.Entities
{
    public class Renovation : Base
    {
        public Guid BuildingConstructionId { get; set; }

        public DateTime MeasurementDate { get; set; }

        public string Description { get; set; }

        public BuildingConstruction BuildingConstruction { get; set; }
    }
}