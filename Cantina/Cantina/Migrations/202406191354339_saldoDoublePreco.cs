namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saldoDoublePreco : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Extras", "Preco", c => c.Double(nullable: false));
            AlterColumn("dbo.Menus", "PrecoEstudante", c => c.Double(nullable: false));
            AlterColumn("dbo.Menus", "PrecoProfessor", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "PrecoProfessor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Menus", "PrecoEstudante", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Extras", "Preco", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
