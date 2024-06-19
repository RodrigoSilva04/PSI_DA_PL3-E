using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using GereCantina.Models;

namespace Cantina.Controllers
{
    public class ItemFaturaController
    {
        public void AdicionarItemFatura(ItemFatura itemFatura)
        {
            using (var db = new CantinaContext())
            {
                db.ItensFatura.Add(itemFatura);
                db.SaveChanges();
            }
        }
        public List<ItemFatura> BuscarItensFaturaPorFaturaId(int faturaId)
        {
            using (var db = new CantinaContext())
            {
                return db.ItensFatura
                         .Where(i => i.FaturaId == faturaId)
                         .ToList();
            }
        }
    }
}
