using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleSystem.Core.Entities
{
    public class Message
    {
        public long Id { get; set; }

        [ForeignKey(nameof(Journey))]
        public long JourneyId { get; set; }

        public string Details { get; set; }

        public Journey Journey { get; set; }
    }
}