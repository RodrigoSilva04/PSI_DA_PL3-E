using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina.Controllers;
using GereCantina.Models;

namespace Cantina
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
            CarregarListBox();
        }

        private void CarregarListBox()
        {
            FuncionárioController funcionárioController = new FuncionárioController();
            List<Funcionario> funcionários = funcionárioController.ListarFuncionários();

            listBox1.Items.Clear();

            foreach (Funcionario funcionário in funcionários)
            {
                listBox1.Items.Add(funcionário.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeFuncionario = textBox1.Text;
                string usernameFuncionario = textBox3.Text;
                string nifFuncionario = textBox2.Text;

                Funcionario funcionario = new Funcionario()
                {
                    Nome = nomeFuncionario,
                    Username = usernameFuncionario,
                    Nif = nifFuncionario
                };

                FuncionárioController funcionárioController = new FuncionárioController();

                funcionárioController.AdicionarFuncionário(funcionario);

                MessageBox.Show("Funcionário adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar funcionário: " + ex.Message);
            }
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Apagar funcionario da base de dados
            string nomeFuncionario = listBox1.SelectedItem.ToString();
            FuncionárioController funcionárioController = new FuncionárioController();
            Funcionario funcionario = funcionárioController.BuscarFuncionarioPorNome(nomeFuncionario);
            funcionárioController.RemoverFuncionário(funcionario);
            CarregarListBox();
            
        }
    }
}
