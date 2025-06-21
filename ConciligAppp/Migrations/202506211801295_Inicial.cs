namespace ConciligAppp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArquivoImportadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeArquivo = c.String(),
                        DataImportacao = c.DateTime(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(),
                        CPF = c.String(),
                        NumeroContrato = c.String(),
                        Produto = c.String(),
                        DataVencimento = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArquivoImportadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArquivoImportadoes", t => t.ArquivoImportadoId, cascadeDelete: true)
                .Index(t => t.ArquivoImportadoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        SenhaHash = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArquivoImportadoes", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Contratoes", "ArquivoImportadoId", "dbo.ArquivoImportadoes");
            DropIndex("dbo.Contratoes", new[] { "ArquivoImportadoId" });
            DropIndex("dbo.ArquivoImportadoes", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Contratoes");
            DropTable("dbo.ArquivoImportadoes");
        }
    }
}
