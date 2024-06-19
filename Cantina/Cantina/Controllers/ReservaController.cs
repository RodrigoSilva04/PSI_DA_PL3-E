using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cantina.Controllers
{
    public class ReservaController
    {
        //Efetuar CRUD de Reservas
        public void AdicionarReserva(Reserva reserva)
        {
            using (var db = new CantinaContext())
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
            }
        }
        public Reserva BuscarReservaPorId(int id)
        {
            using (var db = new CantinaContext())
            {
                return db.Reservas.Include(r => r.Multas)
                                  .Include(r => r.Pratos)
                                  .Include(r => r.Extras)
                                  .Include(r => r.Menus)
                                  .Include(r => r.Cliente)
                                  .FirstOrDefault(r => r.id == id);
            }
        }

        public List<Reserva> ListarReservas()
        {
            using (var db = new CantinaContext())
            {
                return db.Reservas.Include(r => r.Multas)
                                  .Include(r => r.Pratos)
                                  .Include(r => r.Extras)
                                  .Include(r => r.Menus)
                                  .Include(r => r.Cliente)
                                  .ToList();
            }
        }
        public void AtualizarReserva(Reserva reserva)
        {
            using (var db = new CantinaContext())
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


    }
}
