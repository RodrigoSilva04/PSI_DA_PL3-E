using System.Data.Entity;
using Cantina.Models; // Certifique-se de usar o namespace correto para seus modelos

namespace Cantina.Data
{
    public class CantinaContext : DbContext
    {
        public CantinaContext() : base("name=CantinaContext")
        {
        }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Funcionário> Funcionários { get; set; }
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
    }
}