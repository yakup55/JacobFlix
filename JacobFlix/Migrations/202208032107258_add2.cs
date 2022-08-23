namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorumlars", "FilimBilgisi_FilimID", "dbo.FilimBilgisis");
            DropIndex("dbo.Yorumlars", new[] { "FilimBilgisi_FilimID" });
            RenameColumn(table: "dbo.Yorumlars", name: "FilimBilgisi_FilimID", newName: "FilimID");
            AlterColumn("dbo.Yorumlars", "FilimID", c => c.Int(nullable: false));
            CreateIndex("dbo.Yorumlars", "FilimID");
            AddForeignKey("dbo.Yorumlars", "FilimID", "dbo.FilimBilgisis", "FilimID", cascadeDelete: true);
            DropColumn("dbo.Yorumlars", "flimid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorumlars", "flimid", c => c.Int(nullable: false));
            DropForeignKey("dbo.Yorumlars", "FilimID", "dbo.FilimBilgisis");
            DropIndex("dbo.Yorumlars", new[] { "FilimID" });
            AlterColumn("dbo.Yorumlars", "FilimID", c => c.Int());
            RenameColumn(table: "dbo.Yorumlars", name: "FilimID", newName: "FilimBilgisi_FilimID");
            CreateIndex("dbo.Yorumlars", "FilimBilgisi_FilimID");
            AddForeignKey("dbo.Yorumlars", "FilimBilgisi_FilimID", "dbo.FilimBilgisis", "FilimID");
        }
    }
}
