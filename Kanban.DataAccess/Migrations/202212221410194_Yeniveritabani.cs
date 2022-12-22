namespace Kanban.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yeniveritabani : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        NameSurname = c.String(),
                        TaskStates = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        DeletedBy = c.String(),
                        ModifiedBy = c.String(),
                        Status = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        DeletedBy = c.String(maxLength: 50),
                        ModifiedBy = c.String(maxLength: 50),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "UserID", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
        }
    }
}
