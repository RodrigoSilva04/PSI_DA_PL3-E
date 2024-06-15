namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nif = c.String(),
                        NumEstudante = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
                "dbo.Pratoes",
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
                .ForeignKey("dbo.Utilizadors", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.ItemFaturas",
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
                .ForeignKey("dbo.Utilizadors", t => t.clienteId, cascadeDelete: true)
                .Index(t => t.clienteId);
            
            CreateTable(
                "dbo.MenuExtras",
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
                "dbo.PratoMenus",
                c => new
                    {
                        Prato_id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prato_id, t.Menu_Id })
                .ForeignKey("dbo.Pratoes", t => t.Prato_id, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .Index(t => t.Prato_id)
                .Index(t => t.Menu_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pratoes", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Multas", "ReservaId", "dbo.Reservas");
            DropForeignKey("dbo.Menus", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Extras", "Reserva_id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "clienteId", "dbo.Utilizadors");
            DropForeignKey("dbo.ItemFaturas", "FaturaId", "dbo.Faturas");
            DropForeignKey("dbo.Faturas", "ClienteId", "dbo.Utilizadors");
            DropForeignKey("dbo.PratoMenus", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.PratoMenus", "Prato_id", "dbo.Pratoes");
            DropForeignKey("dbo.MenuExtras", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.MenuExtras", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.PratoMenus", new[] { "Menu_Id" });
            DropIndex("dbo.PratoMenus", new[] { "Prato_id" });
            DropIndex("dbo.MenuExtras", new[] { "Extra_Id" });
            DropIndex("dbo.MenuExtras", new[] { "Menu_Id" });
            DropIndex("dbo.Reservas", new[] { "clienteId" });
            DropIndex("dbo.Multas", new[] { "ReservaId" });
            DropIndex("dbo.ItemFaturas", new[] { "FaturaId" });
            DropIndex("dbo.Faturas", new[] { "ClienteId" });
            DropIndex("dbo.Pratoes", new[] { "Reserva_id" });
            DropIndex("dbo.Menus", new[] { "Reserva_id" });
            DropIndex("dbo.Extras", new[] { "Reserva_id" });
            DropTable("dbo.PratoMenus");
            DropTable("dbo.MenuExtras");
            DropTable("dbo.Reservas");
            DropTable("dbo.Multas");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Faturas");
            DropTable("dbo.Pratoes");
            DropTable("dbo.Menus");
            DropTable("dbo.Extras");
            DropTable("dbo.Utilizadors");
        }
    }
}
