namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBaseEntity : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Activities", name: "CreatedBy_Id", newName: "CreatedById");
            RenameColumn(table: "dbo.Activities", name: "UpdatedBy_Id", newName: "UpdatedById");
            RenameColumn(table: "dbo.Comments", name: "CreatedBy_Id", newName: "CreatedById");
            RenameColumn(table: "dbo.Comments", name: "UpdatedBy_Id", newName: "UpdatedById");
            RenameColumn(table: "dbo.UserProfiles", name: "CreatedBy_Id", newName: "CreatedById");
            RenameColumn(table: "dbo.UserProfiles", name: "UpdatedBy_Id", newName: "UpdatedById");
            RenameColumn(table: "dbo.Sports", name: "CreatedBy_Id", newName: "CreatedById");
            RenameColumn(table: "dbo.Sports", name: "UpdatedBy_Id", newName: "UpdatedById");
            RenameColumn(table: "dbo.AddSportRequests", name: "CreatedBy_Id", newName: "CreatedById");
            RenameColumn(table: "dbo.AddSportRequests", name: "UpdatedBy_Id", newName: "UpdatedById");
            RenameIndex(table: "dbo.Activities", name: "IX_CreatedBy_Id", newName: "IX_CreatedById");
            RenameIndex(table: "dbo.Activities", name: "IX_UpdatedBy_Id", newName: "IX_UpdatedById");
            RenameIndex(table: "dbo.Comments", name: "IX_CreatedBy_Id", newName: "IX_CreatedById");
            RenameIndex(table: "dbo.Comments", name: "IX_UpdatedBy_Id", newName: "IX_UpdatedById");
            RenameIndex(table: "dbo.UserProfiles", name: "IX_CreatedBy_Id", newName: "IX_CreatedById");
            RenameIndex(table: "dbo.UserProfiles", name: "IX_UpdatedBy_Id", newName: "IX_UpdatedById");
            RenameIndex(table: "dbo.Sports", name: "IX_CreatedBy_Id", newName: "IX_CreatedById");
            RenameIndex(table: "dbo.Sports", name: "IX_UpdatedBy_Id", newName: "IX_UpdatedById");
            RenameIndex(table: "dbo.AddSportRequests", name: "IX_CreatedBy_Id", newName: "IX_CreatedById");
            RenameIndex(table: "dbo.AddSportRequests", name: "IX_UpdatedBy_Id", newName: "IX_UpdatedById");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AddSportRequests", name: "IX_UpdatedById", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.AddSportRequests", name: "IX_CreatedById", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Sports", name: "IX_UpdatedById", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Sports", name: "IX_CreatedById", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.UserProfiles", name: "IX_UpdatedById", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.UserProfiles", name: "IX_CreatedById", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Comments", name: "IX_UpdatedById", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Comments", name: "IX_CreatedById", newName: "IX_CreatedBy_Id");
            RenameIndex(table: "dbo.Activities", name: "IX_UpdatedById", newName: "IX_UpdatedBy_Id");
            RenameIndex(table: "dbo.Activities", name: "IX_CreatedById", newName: "IX_CreatedBy_Id");
            RenameColumn(table: "dbo.AddSportRequests", name: "UpdatedById", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.AddSportRequests", name: "CreatedById", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Sports", name: "UpdatedById", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Sports", name: "CreatedById", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.UserProfiles", name: "UpdatedById", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.UserProfiles", name: "CreatedById", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Comments", name: "UpdatedById", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Comments", name: "CreatedById", newName: "CreatedBy_Id");
            RenameColumn(table: "dbo.Activities", name: "UpdatedById", newName: "UpdatedBy_Id");
            RenameColumn(table: "dbo.Activities", name: "CreatedById", newName: "CreatedBy_Id");
        }
    }
}
