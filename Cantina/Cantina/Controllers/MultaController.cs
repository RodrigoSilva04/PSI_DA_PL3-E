using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina.Controllers
{
    public class MultaController
    {
        public List<Multa> ListarMultas()
        {
            using (var db = new CantinaContext())
            {
                var multas = db.Multas.ToList();
                return multas;
            }
        }

        //Adicionar
        public void AdicionarMulta(Multa multa)
        {
            using (var db = new CantinaContext())
            {
                db.Multas.Add(multa);
                db.SaveChanges();
            }
        }
        //Remover
        public void RemoverMulta(Multa multa)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(multa).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        //Atualizar
        public void AtualizarMulta(Multa multa)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(multa).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //Buscar multa por id
        public Multa BuscarMultaPorId(int id)
        {
            using (var db = new CantinaContext())
            {
                return db.Multas.Find(id);
            }
        }
    }
}
