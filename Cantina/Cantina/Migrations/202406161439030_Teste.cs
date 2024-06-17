namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nif = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        Reserva_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_id)
                .Index(t => t.Reserva_id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QtdDisponivel = c.Int(nullable: false),
                        PrecoEstudante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoProfessor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reserva_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_id)
                .Index(t => t.Reserva_id);
            
            CreateTable(
                "dbo.Pratos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(),
                        tipo = c.String(),
                        ativo = c.Boolean(nullable: false),
                        Reserva_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_id)
                .Index(t => t.Reserva_id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataHora = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.ItensFatura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faturas", t => t.FaturaId, cascadeDelete: true)
                .Index(t => t.FaturaId);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumHoras = c.Int(nullable: false),
                        ReservaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.ReservaId, cascadeDelete: true)
                .Index(t => t.ReservaId);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        clienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.clienteId)
                .Index(t => t.clienteId);
            
            CreateTable(
                "dbo.MenuExtra",
                c => new
                    {
                        Menu_Id = c.Int(nullable: false),
                        Extra_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_Id, t.Extra_Id })
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .Index(t => t.Menu_Id)
                .Index(t => t.Extra_Id);
            
            CreateTable(
                "dbo.PratoMenu",
                c => new
                    {
                        Prato_id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prato_id, t.Menu_Id })
                .ForeignKey("dbo.Pratos", t => t.Prato_id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Prato_id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadores", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NumEstudante = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadores", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professores", "Id", "dbo.Clientes");
            DropForeignKey("dbo.Funcionarios", "Id", "dbo.Utilizadores");
            DropForeignKey("dbo.Estudantes", "Id", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "Id", "dbo.Utilizadores");
            DropForeignKey("dbo.Pratos", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Multas", "ReservaId", "dbo.Reservas");
            DropForeignKey("dbo.Menus", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Extras", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "clienteId", "dbo.Clientes");
            DropForeignKey("dbo.ItensFatura", "FaturaId", "dbo.Faturas");
            DropForeignKey("dbo.Faturas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.PratoMenu", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.PratoMenu", "Prato_id", "dbo.Pratos");
            DropForeignKey("dbo.MenuExtra", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.MenuExtra", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.Professores", new[] { "Id" });
            DropIndex("dbo.Funcionarios", new[] { "Id" });
            DropIndex("dbo.Estudantes", new[] { "Id" });
            DropIndex("dbo.Clientes", new[] { "Id" });
            DropIndex("dbo.PratoMenu", new[] { "Menu_Id" });
            DropIndex("dbo.PratoMenu", new[] { "Prato_id" });
            DropIndex("dbo.MenuExtra", new[] { "Extra_Id" });
            DropIndex("dbo.MenuExtra", new[] { "Menu_Id" });
            DropIndex("dbo.Reservas", new[] { "clienteId" });
            DropIndex("dbo.Multas", new[] { "ReservaId" });
            DropIndex("dbo.ItensFatura", new[] { "FaturaId" });
            DropIndex("dbo.Faturas", new[] { "ClienteId" });
            DropIndex("dbo.Pratos", new[] { "Reserva_id" });
            DropIndex("dbo.Menus", new[] { "Reserva_id" });
            DropIndex("dbo.Extras", new[] { "Reserva_id" });
            DropTable("dbo.Professores");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Estudantes");
            DropTable("dbo.Clientes");
            DropTable("dbo.PratoMenu");
            DropTable("dbo.MenuExtra");
            DropTable("dbo.Reservas");
            DropTable("dbo.Multas");
            DropTable("dbo.ItensFatura");
            DropTable("dbo.Faturas");
            DropTable("dbo.Pratos");
            DropTable("dbo.Menus");
            DropTable("dbo.Extras");
            DropTable("dbo.Utilizadores");
        }
    }
}
