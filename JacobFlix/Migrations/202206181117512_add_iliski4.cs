namespace JacobFlix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_iliski4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.İletisim", "Telefon", c => c.String(maxLength: 11));
            DropColumn("dbo.Degerlendirmes", "flimid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Degerlendirmes", "flimid", c => c.Int(nullable: false));
            AlterColumn("dbo.İletisim", "Telefon", c => c.Int(nullable: false));
        }
    }
}
