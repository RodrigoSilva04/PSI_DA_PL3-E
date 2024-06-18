using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    using Cantina;
    using GereCantina.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Runtime.InteropServices.ComTypes;
    using System.Windows.Forms;

    public class PratoController
    {
        
        //CRUD de Pratos
        public void AdicionarPrato(Prato prato)
        {
            //Adicionar Prato
            using (var db = new CantinaContext())
            {
                db.Pratos.Add(prato);
                db.SaveChanges();
            }
        }

        public void RemoverPrato(Prato prato)
        {
            //Remover Prato
            using (var db = new CantinaContext())
            {
                db.Entry(prato).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void AtualizarPrato(Prato prato)
        {
          //Atualizar todos os valores do prato
            using (var db = new CantinaContext())
            {
                db.Entry(prato).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }


        public List<Prato> ListarPratos()
        {
            //Listar Prato
            using (var db = new CantinaContext())
            {
                return db.Pratos.ToList();
            }
        }
        public Prato BuscarPratoPorDescricao(string descricao)
        {
            //Buscar Prato por descrição e retornar o prato
            using (var db = new CantinaContext())
            {
                return db.Pratos.FirstOrDefault(p => p.descricao == descricao);
                
            }
        }
    }
}
