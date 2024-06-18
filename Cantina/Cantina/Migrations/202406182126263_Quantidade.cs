namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quantidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Extras", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Pratos", "quantidade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pratos", "quantidade");
            DropColumn("dbo.Extras", "Quantidade");
        }
    }
}
