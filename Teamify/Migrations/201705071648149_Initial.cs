namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddSportRequests",
                c => new
                    {
                        AddSportRequestId = c.Int(nullable: false, identity: true),
                        SportName = c.String(nullable: false),
                        SportDescription = c.String(nullable: false),
                        SprotRules = c.String(),
                        RequestStatus = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(nullable: false, maxLength: 128),
                        UpdatedBy_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AddSportRequestId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        Bio = c.String(),
                        Rating = c.Single(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(nullable: false, maxLength: 128),
                        UpdatedBy_Id = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.UserProfileId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Rules = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(nullable: false, maxLength: 128),
                        UpdatedBy_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SportId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UpdatedBy_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.UpdatedBy_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Sports", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AddSportRequests", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AddSportRequests", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserProfiles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserProfiles", "UpdatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserProfiles", "CreatedBy_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Sports", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.Sports", new[] { "CreatedBy_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.UserProfiles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.UserProfiles", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.UserProfiles", new[] { "CreatedBy_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AddSportRequests", new[] { "UpdatedBy_Id" });
            DropIndex("dbo.AddSportRequests", new[] { "CreatedBy_Id" });
            DropTable("dbo.Sports");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AddSportRequests");
        }
    }
}
