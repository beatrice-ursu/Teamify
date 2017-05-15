namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefineActivity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        MinPlayers = c.Int(nullable: false),
                        MaxPlayers = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        MinPlayersRating = c.Single(),
                        Description = c.String(),
                        Location = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                        UserProfile_UserProfileId = c.Int(),
                        UserProfile_UserProfileId1 = c.Int(),
                        CreatedBy_Id = c.String(nullable: false, maxLength: 128),
                        Sport_SportId = c.Int(nullable: false),
                        UpdatedBy_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ActivityId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_UserProfileId)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_UserProfileId1)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Sports", t => t.Sport_SportId)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.User_Id)
                .Index(t => t.UserProfile_UserProfileId)
                .Index(t => t.UserProfile_UserProfileId1)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Sport_SportId)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Activity_ActivityId = c.Int(nullable: false),
                        CreatedBy_Id = c.String(nullable: false, maxLength: 128),
                        UpdatedBy_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Activities", t => t.Activity_ActivityId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.Activity_ActivityId)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            AddColumn("dbo.UserProfiles", "Activity_ActivityId", c => c.Int());
            AddColumn("dbo.UserProfiles", "Activity_ActivityId1", c => c.Int());
            CreateIndex("dbo.UserProfiles", "Activity_ActivityId");
            CreateIndex("dbo.UserProfiles", "Activity_ActivityId1");
            AddForeignKey("dbo.UserProfiles", "Activity_ActivityId", "dbo.Activities", "ActivityId");
            AddForeignKey("dbo.UserProfiles", "Activity_ActivityId1", "dbo.Activities", "ActivityId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Activities", "Sport_SportId", "dbo.Sports");
            DropForeignKey("dbo.UserProfiles", "Activity_ActivityId1", "dbo.Activities");
            DropForeignKey("dbo.UserProfiles", "Activity_ActivityId", "dbo.Activities");
            DropForeignKey("dbo.Activities", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Activities", "UserProfile_UserProfileId1", "dbo.UserProfiles");
            DropForeignKey("dbo.Activities", "UserProfile_UserProfileId", "dbo.UserProfiles");
            DropForeignKey("dbo.Activities", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Activity_ActivityId", "dbo.Activities");
            DropIndex("dbo.UserProfiles", new[] { "Activity_ActivityId1" });
            DropIndex("dbo.UserProfiles", new[] { "Activity_ActivityId" });
            DropIndex("dbo.Comments", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Comments", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Comments", new[] { "Activity_ActivityId" });
            DropIndex("dbo.Activities", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Activities", new[] { "Sport_SportId" });
            DropIndex("dbo.Activities", new[] { "CreatedBy_Id" });
            DropIndex("dbo.Activities", new[] { "UserProfile_UserProfileId1" });
            DropIndex("dbo.Activities", new[] { "UserProfile_UserProfileId" });
            DropIndex("dbo.Activities", new[] { "User_Id" });
            DropColumn("dbo.UserProfiles", "Activity_ActivityId1");
            DropColumn("dbo.UserProfiles", "Activity_ActivityId");
            DropTable("dbo.Comments");
            DropTable("dbo.Activities");
        }
    }
}
