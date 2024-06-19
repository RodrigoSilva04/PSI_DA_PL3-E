using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Multa
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int NumHoras { get; set; }

        public override string ToString()
        {
            return $"Valor da multa: {Valor:C1}, Nº: {NumHoras}";
        }
    }

}
