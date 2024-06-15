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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
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
    }
}
