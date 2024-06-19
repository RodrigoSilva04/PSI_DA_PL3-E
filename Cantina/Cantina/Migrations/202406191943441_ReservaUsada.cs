namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservaUsada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "usada", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservas", "usada");
        }
    }
}
