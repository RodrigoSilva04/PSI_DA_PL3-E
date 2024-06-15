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
            using (var context = new CantinaContext())
            {
                context.Estudantes.Add(estudante);
                context.SaveChanges();
            }
        }

        public void AtualizarEstudante(Estudante estudante)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(estudante).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoverEstudante(Estudante estudante)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(estudante).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Estudante> ListarEstudantes()
        {
            using (var context = new CantinaContext())
            {
                return context.Estudantes.ToList();
            }
        }

        public Estudante BuscarEstudantePorId(int id)
        {
            using (var context = new CantinaContext())
            {
                return context.Estudantes.Find(id);
            }
        }

        public Estudante BuscarEstudantePorNumero(string numero)
        {
            using (var context = new CantinaContext())
            {
                return context.Estudantes.FirstOrDefault(e => e.NumEstudante == numero);
            }
        }
    }
}
