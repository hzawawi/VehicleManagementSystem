namespace VehicleSystem.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVehicleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Make = c.String(),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicle");
        }
    }
}
