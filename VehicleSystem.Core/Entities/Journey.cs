using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleSystem.Core.Entities
{
    public class Journey
    {
        public long Id { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public long VehicleId { get; set; }

        [ForeignKey(nameof(Driver))]
        public long DriverId { get; set; }

        public string OriginalSource { get; set; }

        public string Destination { get; set; }

        public DateTime CompletedOn { get; set; }

        public Vehicle Vehicle { get; set; }

        public Driver Driver { get; set; }
    }
}