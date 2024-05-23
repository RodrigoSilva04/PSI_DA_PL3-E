using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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
            Reservas reservas = new Reservas();
            reservas.ShowDialog();
            this.Close();
        }

        private void bt_Pratos_Click(object sender, EventArgs e)
        {
            //Abrir a janela de pratos
            this.Hide();
            Pratos pratos = new Pratos();
            pratos.ShowDialog();
            this.Close();
        }

        private void bt_Extras_Click(object sender, EventArgs e)
        {
            //Abrir a janela de extras
            this.Hide();
            Extras extras = new Extras();
            extras.ShowDialog();
            this.Close();
        }

        private void bt_Multas_Click(object sender, EventArgs e)
        {
            //Abrir a janela de multas
            this.Hide();
            Multas multas = new Multas();
            multas.ShowDialog();
            this.Close();
        }

        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            //Abrir a janela de clientes
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
            this.Close();
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            //Abrir a janela de menu
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void bt_Funcionários_Click(object sender, EventArgs e)
        {
            //Abrir a janela de funcionários
            this.Hide();
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
