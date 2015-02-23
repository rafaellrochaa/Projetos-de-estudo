namespace CodeFirstMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLivro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        id_Editora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Editoras", t => t.id_Editora, cascadeDelete: true)
                .Index(t => t.id_Editora);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livroes", "id_Editora", "dbo.Editoras");
            DropIndex("dbo.Livroes", new[] { "id_Editora" });
            DropTable("dbo.Livroes");
        }
    }
}
