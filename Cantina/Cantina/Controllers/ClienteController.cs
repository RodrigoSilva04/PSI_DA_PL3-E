using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    public class ClienteController
    {
        //CRUD
        //Criar a parte de adicionar, remover, atualizar e listar clientes
        //Adicionar
        public void AdicionarCliente(Cliente cliente)
        {
            using (var db = new CantinaContext())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }
        //Remover
        public void RemoverCliente(Cliente cliente)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(cliente).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        //Atualizar
        public void AtualizarCliente(Cliente cliente)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        //Listar
        public List<Cliente> ListarClientes()
        {
            using (var db = new CantinaContext())
            {
                return db.Clientes.ToList();
            }
        }

        //função para buscar funcionário por nome
        public Cliente BuscarClientePorNome(string nome)
        {
            using (var db = new CantinaContext())
            {
                return db.Clientes.FirstOrDefault(f => f.Nome == nome);
            }
        }
    }
}
