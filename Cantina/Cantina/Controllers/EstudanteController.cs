using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;


namespace GereCantina.Controllers
{
    using Cantina;
    using GereCantina.Models;
    public class EstudanteController
    {

        public void AdicionarEstudante(Estudante estudante)
        {
            using (var db = new CantinaContext())
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
            }
        }

        public void AtualizarEstudante(Estudante estudante)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void RemoverEstudante(Estudante estudante)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(estudante).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Estudante> ListarEstudantes()
        {
            using (var db = new CantinaContext())
            {
                return db.Estudantes.ToList();
            }
        }

        public Estudante BuscarEstudantePorId(int id)
        {
            using (var db = new CantinaContext())
            {
                return db.Estudantes.Find(id);
            }
        }

        public Estudante BuscarEstudantePorNumero(string numero)
        {
            using (var db = new CantinaContext())
            {
                return db.Estudantes.FirstOrDefault(e => e.NumEstudante == numero);
            }
        }
    }
}
