namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Comments", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.UserProfiles", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Sports", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.AddSportRequests", "IsActive", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddSportRequests", "IsActive");
            DropColumn("dbo.Sports", "IsActive");
            DropColumn("dbo.UserProfiles", "IsActive");
            DropColumn("dbo.Comments", "IsActive");
            DropColumn("dbo.Activities", "IsActive");
        }
    }
}
