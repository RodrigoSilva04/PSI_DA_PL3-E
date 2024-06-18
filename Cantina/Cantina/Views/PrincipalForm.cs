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
using Cantina.Views;
using GereCantina.Models;




namespace Cantina
{
    public partial class PrincipalForm : Form
    {

        public PrincipalForm()
        {
            InitializeComponent();
            CarregarFuncionarios();
            FillTlMenusSemana();

            
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
        private void FillTlMenusSemana()
        {
            var menus = new Dictionary<string, List<string>>
    {
        { "Segunda-feira", new List<string> { "Prato 1", "Extra 1" } },
        { "Terça-feira", new List<string> { "Prato 2", "Extra 2" } },
        { "Quarta-feira", new List<string> { "Prato 3", "Extra 3" } },
        { "Quinta-feira", new List<string> { "Prato 4", "Extra 4" } },
        { "Sexta-feira", new List<string> { "Prato 5", "Extra 5" } },
    };

            int columnIndex = 0;
            foreach (var dia in menus.Keys)
            {
                // Create a Panel for the current day
                var panelDia = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Create a Label for the day and add it to the column header
                var labelDia = new Label
                {
                    Text = dia,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                tl_MenusSemana.Controls.Add(labelDia, columnIndex, 0);

                // Create a Label to display the menu items
                var labelMenu = new Label
                {
                    Text = string.Join(Environment.NewLine, menus[dia]),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.TopCenter
                };

                // Create a Button for additional details
                var buttonDetalhes = new Button
                {
                    Text = "Detalhes",
                    Dock = DockStyle.Bottom,
                    Tag = dia // Save the day as Tag to use in the click event
                };
                buttonDetalhes.Click += ButtonDetalhes_Click;

                panelDia.Controls.Add(labelMenu);
                panelDia.Controls.Add(buttonDetalhes);

                // Add the day's panel to the TableLayoutPanel
                tl_MenusSemana.Controls.Add(panelDia, columnIndex, 1); // Adjust the row index accordingly if needed

                columnIndex++;
            }
        }

        private void ButtonDetalhes_Click(object sender, EventArgs e)
        {
            // Ir para a janela de reservas com o dia selecionado

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
            ExtrasForm extras = new ExtrasForm();
            extras.ShowDialog();
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

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            
        }
       

    }
}
