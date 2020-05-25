namespace VehicleSystem.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        JourneyId = c.Long(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Journey", t => t.JourneyId, cascadeDelete: true)
                .Index(t => t.JourneyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Message", "JourneyId", "dbo.Journey");
            DropIndex("dbo.Message", new[] { "JourneyId" });
            DropTable("dbo.Message");
        }
    }
}
