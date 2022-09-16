using System;
using System.Collections.Generic;

namespace console.Models
{
    public partial record class Earthquake
    {
        public long? EarthquakeId { get; set; }
        public string? OccurredOn { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public long? Depth { get; set; }
        public long? Magnitude { get; set; }
        public string? CalculationMethod { get; set; }
        public string? NetworkId { get; set; }
        public string? Place { get; set; }
        public string? Cause { get; set; }
    }
}
