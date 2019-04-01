﻿using System;

namespace SaveBridge.Entities
{
    public class Vibration : Base
    {
        public Guid BuildingConstructionId { get; set; }

        public double Value { get; set; }

        public DateTime MeasurementDate { get; set; }

        public virtual BuildingConstruction BuildingConstruction { get; set; }
    }
}