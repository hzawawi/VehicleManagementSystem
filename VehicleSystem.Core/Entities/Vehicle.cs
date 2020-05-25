using System.Collections.Generic;

namespace VehicleSystem.Core.Entities
{
    public class Vehicle
    {
        public long Id { get; set; }

        public string Make { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public ICollection<Sensor> Sensors { get; set; }
    }
}
