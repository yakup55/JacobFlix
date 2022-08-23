namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yorumlars", "DegerlendirmeId", c => c.Int(nullable: false));
            DropColumn("dbo.Yorumlars", "degerlendirmeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorumlars", "degerlendirmeeId", c => c.Int(nullable: false));
            DropColumn("dbo.Yorumlars", "DegerlendirmeId");
        }
    }
}
