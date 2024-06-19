namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MultaFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Multas", "ReservaId", "dbo.Reservas");
            DropIndex("dbo.Multas", new[] { "ReservaId" });
            RenameColumn(table: "dbo.Multas", name: "ReservaId", newName: "Reserva_id");
            AlterColumn("dbo.Multas", "Reserva_id", c => c.Int());
            CreateIndex("dbo.Multas", "Reserva_id");
            AddForeignKey("dbo.Multas", "Reserva_id", "dbo.Reservas", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Multas", "Reserva_id", "dbo.Reservas");
            DropIndex("dbo.Multas", new[] { "Reserva_id" });
            AlterColumn("dbo.Multas", "Reserva_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Multas", name: "Reserva_id", newName: "ReservaId");
            CreateIndex("dbo.Multas", "ReservaId");
            AddForeignKey("dbo.Multas", "ReservaId", "dbo.Reservas", "id", cascadeDelete: true);
        }
    }
}
