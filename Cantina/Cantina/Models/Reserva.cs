using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public bool usada { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Prato> Pratos { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<Multa> Multas { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Cliente}, Multas: {Multas}, Pratos: {Pratos}, Extras: {Extras}, Menus: {Menus}";
        }
     }
}
