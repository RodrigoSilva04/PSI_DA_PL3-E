using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GereCantina
{
    //Criar a classe utilizador
    public class Utilizador
    {
        //Criar as 3 variaveis
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nif { get; set; }
        
    }
}
