using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class ItemFatura
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int FaturaId { get; set; }
        public Fatura Fatura { get; set; }
    }

}
