namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaldoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Saldo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Saldo");
        }
    }
}
