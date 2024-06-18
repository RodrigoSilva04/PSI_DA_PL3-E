using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Controllers
{
    using Cantina;
    using GereCantina.Models;
    public class ProfessorController
    {
        public void AdicionarProfessor(Professor professor)
        {
            using (var db = new CantinaContext())
            {
                db.Professores.Add(professor);
                db.SaveChanges();
            }
        }

        public void AtualizarProfessor(Professor professor)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void RemoverProfessor(Professor professor)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(professor).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Professor> ListarProfessores()
        {
            using (var db = new CantinaContext())
            {
                return db.Professores.ToList();
            }
        }

        public Professor BuscarProfessorPorId(int id)
        {
            using (var db = new CantinaContext())
            {
                return db.Professores.Find(id);
            }
        }

        public Professor BuscarProfessorPorEmail(string email)
        {
            using (var db = new CantinaContext())
            {
                return db.Professores.FirstOrDefault(e => e.Email == email);
            }
        }
    }
}
