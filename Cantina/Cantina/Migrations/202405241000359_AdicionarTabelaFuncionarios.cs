namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AdicionarTabelaFuncionarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionários",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(),
                    Nome = c.String(),
                    NIF = c.String(),
                })
                .PrimaryKey(t => t.Id);

            // Other table creation code
        }

        public override void Down()
        {
            
        }
    }
}
