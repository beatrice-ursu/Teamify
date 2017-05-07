namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddSportRequests", "SportRules", c => c.String());
            DropColumn("dbo.AddSportRequests", "SprotRules");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddSportRequests", "SprotRules", c => c.String());
            DropColumn("dbo.AddSportRequests", "SportRules");
        }
    }
}
