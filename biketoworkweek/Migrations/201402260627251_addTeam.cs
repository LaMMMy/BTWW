namespace biketoworkweeklogger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        RiderID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        TeamID = c.Int(nullable: false),
                        UserID = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.RiderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Riders");
        }
    }
}
