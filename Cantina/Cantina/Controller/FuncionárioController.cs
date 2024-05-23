using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Cantina.Controller
{
    using Cantina.Data;
    using Cantina.Models;
    public class FuncionárioController
    {
        //CRUD
        //Criar a parte de adicionar, remover, atualizar e listar funcionários

        //Adicionar
        public void AdicionarFuncionário(Funcionário funcionário)
        {
            using (var context = new CantinaContext())
            {
                context.Funcionários.Add(funcionário);
                context.SaveChanges();
            }
        }
        //Remover
        public void RemoverFuncionário(Funcionario funcionario)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(funcionario).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        //Atualizar
        public void AtualizarFuncionário(Funcionario funcionario)
        {
            using (var context = new CantinaContext())
            {
                context.Entry(funcionario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Listar
        public List<Funcionário> ListarFuncionários()
        {
            using (var context = new CantinaContext())
            {
                return context.Funcionários.ToList();
            }
        }



    }
}
