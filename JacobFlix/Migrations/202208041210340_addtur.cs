namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turs",
                c => new
                    {
                        TurID = c.Int(nullable: false, identity: true),
                        TurName = c.String(),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TurID);
            
            AddColumn("dbo.FilimBilgisis", "TursID", c => c.Int(nullable: false));
            AddColumn("dbo.FilimBilgisis", "Turs_TurID", c => c.Int());
            CreateIndex("dbo.FilimBilgisis", "Turs_TurID");
            AddForeignKey("dbo.FilimBilgisis", "Turs_TurID", "dbo.Turs", "TurID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilimBilgisis", "Turs_TurID", "dbo.Turs");
            DropIndex("dbo.FilimBilgisis", new[] { "Turs_TurID" });
            DropColumn("dbo.FilimBilgisis", "Turs_TurID");
            DropColumn("dbo.FilimBilgisis", "TursID");
            DropTable("dbo.Turs");
        }
    }
}
