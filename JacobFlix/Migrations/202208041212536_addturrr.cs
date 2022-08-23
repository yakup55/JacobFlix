namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addturrr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilimBilgisis", "Turs_TurID", "dbo.Turs");
            DropIndex("dbo.FilimBilgisis", new[] { "Turs_TurID" });
            RenameColumn(table: "dbo.FilimBilgisis", name: "Turs_TurID", newName: "TurID");
            AlterColumn("dbo.FilimBilgisis", "TurID", c => c.Int(nullable: false));
            CreateIndex("dbo.FilimBilgisis", "TurID");
            AddForeignKey("dbo.FilimBilgisis", "TurID", "dbo.Turs", "TurID", cascadeDelete: true);
            DropColumn("dbo.FilimBilgisis", "TursID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FilimBilgisis", "TursID", c => c.Int(nullable: false));
            DropForeignKey("dbo.FilimBilgisis", "TurID", "dbo.Turs");
            DropIndex("dbo.FilimBilgisis", new[] { "TurID" });
            AlterColumn("dbo.FilimBilgisis", "TurID", c => c.Int());
            RenameColumn(table: "dbo.FilimBilgisis", name: "TurID", newName: "Turs_TurID");
            CreateIndex("dbo.FilimBilgisis", "Turs_TurID");
            AddForeignKey("dbo.FilimBilgisis", "Turs_TurID", "dbo.Turs", "TurID");
        }
    }
}
