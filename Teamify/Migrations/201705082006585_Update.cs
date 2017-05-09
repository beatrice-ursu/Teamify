namespace Teamify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserProfiles", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.UserProfiles", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserProfiles", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.UserProfiles", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
