namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTabelaFuncionarios : DbMigration
    {
        public override void Up()
        {
            //Adicionar a table Funcionarios
            CreateTable(
                               "dbo.Funcionarios",
                                              c => new
                                              {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nif = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            //Remover a table Funcionarios antiga
            DropTable("dbo.Funcionários");

        }
    }
}
