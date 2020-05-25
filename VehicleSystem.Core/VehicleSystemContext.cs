using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VehicleSystem.Core.Entities;

namespace VehicleSystem.Core
{
    public class VehicleSystemContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
