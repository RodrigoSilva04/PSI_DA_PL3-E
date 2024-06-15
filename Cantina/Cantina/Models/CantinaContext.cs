using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class CantinaContext : DbContext
    {
        public CantinaContext() : base("name=CantinaContext")
        {
        }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<ItemFatura> ItensFatura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Remove a convenção de pluralização de nomes de tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configurações adicionais de mapeamento
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Estudante>().ToTable("Estudantes");
            modelBuilder.Entity<Professor>().ToTable("Professores");
            modelBuilder.Entity<Multa>().ToTable("Multas");
            modelBuilder.Entity<Reserva>().ToTable("Reservas");
            modelBuilder.Entity<Prato>().ToTable("Pratos");
            modelBuilder.Entity<Extra>().ToTable("Extras");
            modelBuilder.Entity<Menu>().ToTable("Menus");
            modelBuilder.Entity<Fatura>().ToTable("Faturas");
            modelBuilder.Entity<ItemFatura>().ToTable("ItensFatura");

            // Caso tenha propriedades complexas ou relações, você pode configurá-las aqui
        }
    }
}
