using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleSystem.Core.Entities
{
    public class Sensor
    {
        public long Id { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public long VehicleId { get; set; }

        public SensorType SensorType { get; set; }

        public float Value { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}