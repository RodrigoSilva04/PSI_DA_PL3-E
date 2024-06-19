using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int QtdDisponivel { get; set; }
        public double PrecoEstudante { get; set; }
        public double PrecoProfessor { get; set; }
        public ICollection<Prato> Pratos { get; set; }
        public ICollection<Extra> Extras { get; set; }
    }
}
