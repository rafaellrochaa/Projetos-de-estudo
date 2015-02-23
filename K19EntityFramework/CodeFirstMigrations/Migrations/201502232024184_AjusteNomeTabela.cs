namespace CodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteNomeTabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Editora", newName: "Editoras");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Editoras", newName: "Editora");
        }
    }
}
