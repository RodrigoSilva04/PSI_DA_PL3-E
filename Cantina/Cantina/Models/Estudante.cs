using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Estudante : Cliente
    {
        public string NumEstudante { get; set; }

        public override string ToString()
        {
            return $"{Nome}, Nº Estudante: {NumEstudante}";
        }
    }
}
