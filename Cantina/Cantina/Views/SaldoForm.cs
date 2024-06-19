using Cantina.Controllers;
using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina.Views
{
    public partial class SaldoForm : Form
    {
        public SaldoForm()
        {
            InitializeComponent();
            CarregarListBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CarregarListBox()
        {
            ClienteController clienteController = new ClienteController();
            List<Cliente> clientes = clienteController.ListarClientes();

            LBox_Clientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                LBox_Clientes.Items.Add(cliente.Nome);
            }
        }

        private void LBox_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrar o saldo do cliente selecionado
            try
            {
                if (LBox_Clientes.SelectedItem != null)
                {
                    ClienteController clienteController = new ClienteController();
                    Cliente cliente = clienteController.BuscarClientePorNome(LBox_Clientes.SelectedItem.ToString());
                    tb_saldoDisponivel.Text = cliente.Saldo.ToString();
                }
                else
                {
                    tb_saldoDisponivel.Text = "";
                    MessageBox.Show("Selecione um cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mostrar saldo do cliente: " + ex.Message);
            }
            
        }

        private void BT_AdicionarClientes_Click(object sender, EventArgs e)
        {
            //Adicionar saldo ao cliente selecionado
            try
            {
                if (LBox_Clientes.SelectedItem != null)
                {
                    ClienteController clienteController = new ClienteController();
                    Cliente cliente = clienteController.BuscarClientePorNome(LBox_Clientes.SelectedItem.ToString());
                    cliente.Saldo += Convert.ToDouble(tb_saldoAdicionar.Text);
                    clienteController.AtualizarCliente(cliente);
                    tb_saldoDisponivel.Text = cliente.Saldo.ToString();
                    MessageBox.Show("Saldo adicionado com sucesso");
                }
                else
                {
                    MessageBox.Show("Selecione um cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar saldo ao cliente: " + ex.Message);
            }
        }

        private void BT_RemoverClientes_Click(object sender, EventArgs e)
        {
            //Remover saldo ao cliente selecionado
            try
            {
                if (LBox_Clientes.SelectedItem != null)
                {
                    ClienteController clienteController = new ClienteController();
                    Cliente cliente = clienteController.BuscarClientePorNome(LBox_Clientes.SelectedItem.ToString());
                    cliente.Saldo -= Convert.ToDouble(tb_saldoAdicionar.Text);
                    clienteController.AtualizarCliente(cliente);
                    tb_saldoDisponivel.Text = cliente.Saldo.ToString();
                    MessageBox.Show("Saldo removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Selecione um cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover saldo ao cliente: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalForm principal = new PrincipalForm();
            principal.ShowDialog();
            this.Close();
        }
    }
}
