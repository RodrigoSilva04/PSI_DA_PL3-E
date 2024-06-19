using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    public class FaturaController
    {
        public void AdicionarFatura(Fatura fatura)
        {
            using (var db = new CantinaContext())
            {
                db.Faturas.Add(fatura);
                db.SaveChanges();
            }
        }

        public Fatura BuscarFaturaPorId(int id)
        {
            using (var db = new CantinaContext())
            {
                return db.Faturas
                         .Include(f => f.Cliente) // Se necessário, incluir o cliente relacionado à fatura
                         .Include(f => f.ItensFatura)
                         .FirstOrDefault(f => f.Id == id);
            }
        }
    }
}
