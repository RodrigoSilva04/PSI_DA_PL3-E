using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    using Cantina;
    using GereCantina.Models;
    public class ExtraController
    {
        //CRUD de Extras
        public void AdicionarExtra(Extra extra)
        {
            //Adicionar Extra
            using (var db = new CantinaContext())
            {
                db.Extras.Add(extra);
                db.SaveChanges();
            }
        }

        public void RemoverExtra(Extra extra)
        {
            //Remover Extra
            using (var db = new CantinaContext())
            {
                db.Entry(extra).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void AtualizarExtra(Extra extra)
        {
            //Atualizar todos os valores do extra
            using (var db = new CantinaContext())
            {
                db.Entry(extra).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Extra> ListarExtras()
        {
            //Listar Extra
            using (var db = new CantinaContext())
            {
                return db.Extras.ToList();
            }
        }

        public Extra BuscarExtraPorDescricao(string descricao)
        {
            //Buscar Extra por descrição e retornar o extra
            using (var db = new CantinaContext())
            {
                return db.Extras.FirstOrDefault(e => e.Descricao == descricao);
            }
        }

    }
}
