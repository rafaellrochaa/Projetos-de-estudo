namespace CustomizandoCodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovaConfig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Celular", c => c.String());
            DropColumn("dbo.Pessoas", "TelefoneCelular");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "TelefoneCelular", c => c.String());
            DropColumn("dbo.Pessoas", "Celular");
        }
    }
}
