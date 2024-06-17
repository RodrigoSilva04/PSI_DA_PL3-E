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
            //Adicionar funcionario se os campos estiverem preenchidos e no fim limpa os campos e atualiza a listbox
            try
            {
                FuncionárioController funcionárioController = new FuncionárioController();
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = textBox1.Text;
                funcionario.Username = textBox3.Text;
                funcionario.Nif = textBox2.Text;

                if (string.IsNullOrEmpty(funcionario.Nome) || string.IsNullOrEmpty(funcionario.Username) || string.IsNullOrEmpty(funcionario.Nif))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                else {
                    funcionárioController.AdicionarFuncionário(funcionario);
                    MessageBox.Show("Funcionário adicionado com sucesso!");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                    CarregarListBox();
                }
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
            try
            {
                //Apagar funcionario da base de dados
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um funcionário para remover.");
                    return;
                }

                string nomeFuncionario = listBox1.SelectedItem.ToString();

                FuncionárioController funcionárioController = new FuncionárioController();
                Funcionario funcionario = funcionárioController.BuscarFuncionarioPorNome(nomeFuncionario);

                if (funcionario != null)
                {
                    funcionárioController.RemoverFuncionário(funcionario);
                    MessageBox.Show("Funcionário removido com sucesso!");
                    CarregarListBox();
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover funcionário: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editar funcionario
            try
            {
                //Editar funcionario da base de dados
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um funcionário para editar.");
                    return;
                }

                string nomeFuncionario = listBox1.SelectedItem.ToString();

                FuncionárioController funcionárioController = new FuncionárioController();
                Funcionario funcionario = funcionárioController.BuscarFuncionarioPorNome(nomeFuncionario);

                if (funcionario != null)
                {
                    funcionario.Nome = textBox1.Text;
                    funcionario.Username = textBox3.Text;
                    funcionario.Nif = textBox2.Text;
                    //Se o nome ou username ou nif estiver vazio, não atualiza
                    if (string.IsNullOrEmpty(funcionario.Nome) || string.IsNullOrEmpty(funcionario.Username) || string.IsNullOrEmpty(funcionario.Nif))
                    {
                        MessageBox.Show("Preencha todos os campos.");
                        return;
                    }
                    else {
                        funcionárioController.AtualizarFuncionário(funcionario);


                        MessageBox.Show("Funcionário atualizado com sucesso!");


                        CarregarListBox();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar funcionário: " + ex.Message);
            }
        
        

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quando seleciona um funcionario, preenche os campos com os dados do funcionario para se editar ou remover
            if (listBox1.SelectedItem != null)
            {
                string nomeFuncionario = listBox1.SelectedItem.ToString();

                FuncionárioController funcionárioController = new FuncionárioController();
                Funcionario funcionario = funcionárioController.BuscarFuncionarioPorNome(nomeFuncionario);

                if (funcionario != null)
                {
                    textBox1.Text = funcionario.Nome;
                    textBox2.Text = funcionario.Nif;
                    textBox3.Text = funcionario.Username;
                }
            }

        }
    }
}
