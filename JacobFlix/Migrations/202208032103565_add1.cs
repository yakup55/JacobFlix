namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yorumlars", "flimid", c => c.Int(nullable: false));
            AddColumn("dbo.FilimBilgisis", "Ad", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Resim", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Konu", c => c.String());
            AddColumn("dbo.FilimBilgisis", "İzle", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Fragman", c => c.String());
            AddColumn("dbo.FilimBilgisis", "ElestirmenDerece", c => c.Double(nullable: false));
            AddColumn("dbo.FilimBilgisis", "Tur", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Sure", c => c.Double(nullable: false));
            AddColumn("dbo.FilimBilgisis", "Yonetmen", c => c.String());
            AddColumn("dbo.FilimBilgisis", "CikisTarihi", c => c.String());
            CreateIndex("dbo.Yorumlars", "flimid");
            AddForeignKey("dbo.Yorumlars", "flimid", "dbo.FilimBilgisis", "FilimID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorumlars", "flimid", "dbo.FilimBilgisis");
            DropIndex("dbo.Yorumlars", new[] { "flimid" });
            DropColumn("dbo.FilimBilgisis", "CikisTarihi");
            DropColumn("dbo.FilimBilgisis", "Yonetmen");
            DropColumn("dbo.FilimBilgisis", "Sure");
            DropColumn("dbo.FilimBilgisis", "Tur");
            DropColumn("dbo.FilimBilgisis", "ElestirmenDerece");
            DropColumn("dbo.FilimBilgisis", "Fragman");
            DropColumn("dbo.FilimBilgisis", "İzle");
            DropColumn("dbo.FilimBilgisis", "Konu");
            DropColumn("dbo.FilimBilgisis", "Resim");
            DropColumn("dbo.FilimBilgisis", "Ad");
            DropColumn("dbo.Yorumlars", "flimid");
        }
    }
}
