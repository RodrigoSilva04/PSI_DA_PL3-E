using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    class utilizador
    {
        //Criar as 3 variaveis 
        internal string Id;
        internal string Nome;
        internal string Nif;

        public utilizador(string id,string nome,string nif)
        {
            //Atribuir os valores as variaveis
            Nome = nome;
            Id = id;
            Nif = nif;
        }
    }
}
