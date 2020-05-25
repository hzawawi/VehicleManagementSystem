using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VehicleSystem.Core.Entities;

namespace VehicleSystem.Core
{
    public class VehicleSystemContext : DbContext
    {
        public VehicleSystemContext() : base("VehicleSystem")
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
