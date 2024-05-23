using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Multa> Multas { get; set; }
        public ICollection<Prato> Pratos { get; set; }
        public ICollection<Extra> Extras { get; set; }
        public ICollection<Menu> Menus { get; set; }
     }
}
