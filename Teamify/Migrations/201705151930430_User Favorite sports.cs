namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserFavoritesports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SportUserProfiles",
                c => new
                    {
                        Sport_SportId = c.Int(nullable: false),
                        UserProfile_UserProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sport_SportId, t.UserProfile_UserProfileId })
                .ForeignKey("dbo.Sports", t => t.Sport_SportId)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_UserProfileId)
                .Index(t => t.Sport_SportId)
                .Index(t => t.UserProfile_UserProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportUserProfiles", "UserProfile_UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.SportUserProfiles", "Sport_SportId", "dbo.Sports");
            DropIndex("dbo.SportUserProfiles", new[] { "UserProfile_UserProfileId" });
            DropIndex("dbo.SportUserProfiles", new[] { "Sport_SportId" });
            DropTable("dbo.SportUserProfiles");
        }
    }
}
