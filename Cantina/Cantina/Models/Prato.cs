using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Models
{
    public class Prato
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }

        public bool ativo { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
