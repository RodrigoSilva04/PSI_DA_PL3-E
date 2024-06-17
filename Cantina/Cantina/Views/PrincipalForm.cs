using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina.Controllers;
using GereCantina.Models;




namespace Cantina
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            CarregarFuncionarios();
            InitializeTable();
        }
        private void InitializeTable()
        {
            this.tableLayoutPanelSemana = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // TableLayoutPanel
            this.tableLayoutPanelSemana.ColumnCount = 5;
            this.tableLayoutPanelSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelSemana.RowCount = 1;
            this.tableLayoutPanelSemana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelSemana.Size = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.tableLayoutPanelSemana);
        }
        private void CarregarFuncionarios()
        {
            FuncionárioController funcionárioController = new FuncionárioController();
            List<Funcionario> funcionários = funcionárioController.ListarFuncionários();

            comboBox1.Items.Clear();

            foreach (Funcionario funcionário in funcionários)
            {
                comboBox1.Items.Add(funcionário.Nome);
            }
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            //Sair do aplicativo
            Application.Exit();
        }

        private void bt_reservas_Click(object sender, EventArgs e)
        {
            //Abrir a janela de reservas
            this.Hide();
            ReservasForm reservas = new ReservasForm();
            reservas.ShowDialog();
            this.Close();
        }

        private void bt_Pratos_Click(object sender, EventArgs e)
        {
            //Abrir a janela de pratos
            this.Hide();
            PratosForm pratos = new PratosForm();
            pratos.ShowDialog();
            this.Close();
        }

        private void bt_Extras_Click(object sender, EventArgs e)
        {
            //Abrir a janela de extras
            this.Hide();
            
            this.Close();
        }

        private void bt_Multas_Click(object sender, EventArgs e)
        {
            //Abrir a janela de multas
            this.Hide();
            MultasForm multas = new MultasForm();
            multas.ShowDialog();
            this.Close();
        }

        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            //Abrir a janela de clientes
            this.Hide();
            ClientesForm clientes = new ClientesForm();
            clientes.ShowDialog();
            this.Close();
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            //Abrir a janela de menu
            this.Hide();
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            this.Close();
        }

        private void bt_Funcionários_Click(object sender, EventArgs e)
        {
            //Abrir a janela de funcionários
            this.Hide();
            FuncionarioForm funcionario = new FuncionarioForm();
            funcionario.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visualizar todos os funcionáriose selecionar quem é que esta a utilizar o sistema

        }

        private void bt_loginUt_Click(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
            label3.Visible = true;
            //Utilizador é o funcionário que está a utilizar o sistema

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanelSemana_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
