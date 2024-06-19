﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereCantina.Models
{
    public class Extra
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
