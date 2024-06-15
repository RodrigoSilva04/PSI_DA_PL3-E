namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Utilizadors", newName: "Utilizadores");
            RenameTable(name: "dbo.Extras", newName: "Extra");
            RenameTable(name: "dbo.Menus", newName: "Menu");
            RenameTable(name: "dbo.Pratoes", newName: "Prato");
            RenameTable(name: "dbo.Faturas", newName: "Fatura");
            RenameTable(name: "dbo.ItemFaturas", newName: "ItemFatura");
            RenameTable(name: "dbo.Multas", newName: "Multa");
            RenameTable(name: "dbo.Reservas", newName: "Reserva");
            RenameTable(name: "dbo.MenuExtras", newName: "MenuExtra");
            RenameTable(name: "dbo.PratoMenus", newName: "PratoMenu");
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
            
            AlterColumn("dbo.Utilizadores", "Discriminator", c => c.String(maxLength: 128));
            DropColumn("dbo.Utilizadores", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilizadores", "Username", c => c.String());
            DropForeignKey("dbo.Funcionarios", "Id", "dbo.Utilizadores");
            DropIndex("dbo.Funcionarios", new[] { "Id" });
            AlterColumn("dbo.Utilizadores", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.Funcionarios");
            RenameTable(name: "dbo.PratoMenu", newName: "PratoMenus");
            RenameTable(name: "dbo.MenuExtra", newName: "MenuExtras");
            RenameTable(name: "dbo.Reserva", newName: "Reservas");
            RenameTable(name: "dbo.Multa", newName: "Multas");
            RenameTable(name: "dbo.ItemFatura", newName: "ItemFaturas");
            RenameTable(name: "dbo.Fatura", newName: "Faturas");
            RenameTable(name: "dbo.Prato", newName: "Pratoes");
            RenameTable(name: "dbo.Menu", newName: "Menus");
            RenameTable(name: "dbo.Extra", newName: "Extras");
            RenameTable(name: "dbo.Utilizadores", newName: "Utilizadors");
        }
    }
}
