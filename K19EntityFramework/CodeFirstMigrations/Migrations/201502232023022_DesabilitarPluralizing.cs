namespace CodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesabilitarPluralizing : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Editoras", newName: "Editora");
            RenameTable(name: "dbo.Livroes", newName: "Livros");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Livros", newName: "Livroes");
            RenameTable(name: "dbo.Editora", newName: "Editoras");
        }
    }
}
