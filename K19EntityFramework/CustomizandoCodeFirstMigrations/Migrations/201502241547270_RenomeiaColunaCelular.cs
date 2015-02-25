namespace CustomizandoCodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenomeiaColunaCelular : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pessoas", "TelefoneCelular");
            RenameColumn("dbo.Pessoas", "Celular", "TelefoneCelular");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "TelefoneCelular", c => c.String());
            RenameColumn("dbo.Pessoas", "TelefoneCelular","Celular");
        }
    }
}
