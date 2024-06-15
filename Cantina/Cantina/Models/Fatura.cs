using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<ItemFatura> ItensFatura { get; set; }
    }

}
