namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaldoDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Saldo", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Saldo", c => c.Int(nullable: false));
        }
    }
}
