namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addisimdegistirme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FilimBilgisis", "FilimDerecesi", c => c.Double(nullable: false));
            AddColumn("dbo.FilimBilgisis", "FilimTur", c => c.String());
            AddColumn("dbo.FilimBilgisis", "FilimSure", c => c.Double(nullable: false));
            AddColumn("dbo.FilimBilgisis", "FilimYonetmen", c => c.String());
            AddColumn("dbo.FilimBilgisis", "FilimCikisTarihi", c => c.String());
            DropColumn("dbo.FilimBilgisis", "ElestirmenDerece");
            DropColumn("dbo.FilimBilgisis", "Tur");
            DropColumn("dbo.FilimBilgisis", "Sure");
            DropColumn("dbo.FilimBilgisis", "Yonetmen");
            DropColumn("dbo.FilimBilgisis", "CikisTarihi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FilimBilgisis", "CikisTarihi", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Yonetmen", c => c.String());
            AddColumn("dbo.FilimBilgisis", "Sure", c => c.Double(nullable: false));
            AddColumn("dbo.FilimBilgisis", "Tur", c => c.String());
            AddColumn("dbo.FilimBilgisis", "ElestirmenDerece", c => c.Double(nullable: false));
            DropColumn("dbo.FilimBilgisis", "FilimCikisTarihi");
            DropColumn("dbo.FilimBilgisis", "FilimYonetmen");
            DropColumn("dbo.FilimBilgisis", "FilimSure");
            DropColumn("dbo.FilimBilgisis", "FilimTur");
            DropColumn("dbo.FilimBilgisis", "FilimDerecesi");
        }
    }
}
