namespace VehicleSystem.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriverAndJourneyAndSensorsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Driver",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.Long(nullable: false),
                        LastName = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journey",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        VehicleId = c.Long(nullable: false),
                        DriverId = c.Long(nullable: false),
                        OriginalSource = c.String(),
                        Destination = c.String(),
                        CompletedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Driver", t => t.DriverId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId)
                .Index(t => t.DriverId);
            
            CreateTable(
                "dbo.Sensor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        VehicleId = c.Long(nullable: false),
                        SensorType = c.Int(nullable: false),
                        Value = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicle", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journey", "VehicleId", "dbo.Vehicle");
            DropForeignKey("dbo.Sensor", "VehicleId", "dbo.Vehicle");
            DropForeignKey("dbo.Journey", "DriverId", "dbo.Driver");
            DropIndex("dbo.Sensor", new[] { "VehicleId" });
            DropIndex("dbo.Journey", new[] { "DriverId" });
            DropIndex("dbo.Journey", new[] { "VehicleId" });
            DropTable("dbo.Sensor");
            DropTable("dbo.Journey");
            DropTable("dbo.Driver");
        }
    }
}
