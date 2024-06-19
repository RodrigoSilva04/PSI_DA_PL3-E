using Cantina.Controllers;
using Cantina.Views;
using GereCantina.Controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
            CarregarCategorias();
            CarregarListBox();
        }

        private void TB_NomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se a categoria for estudante, mostrar o campo de numero de estudante
            if (CB_Categoria.SelectedItem.ToString() == "Estudante")
            {
                L_NumEstudante.Visible = true;
                TB_NumEstudanteCliente.Visible = true;
                L_EmailCliente.Visible = false;
                TB_EmailCliente.Visible = false;
            }
            else if (CB_Categoria.SelectedItem.ToString() == "Professor")
            {
                L_EmailCliente.Visible = true;
                TB_EmailCliente.Visible = true;
                L_NumEstudante.Visible = false;
                TB_NumEstudanteCliente.Visible = false;
            }
        }
        private void CarregarCategorias()
        {
            //Carregar categoria estudante e professor
            CB_Categoria.Items.Add("Estudante");
            CB_Categoria.Items.Add("Professor");

        }

        private void CB_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cancel the keypress event to prevent typing
            e.Handled = true;
        }

       

        private void BT_AdicionarClientes_Click(object sender, EventArgs e)
        {
            
        }
        private void CarregarListBox()
        {
            ClienteController clienteController = new ClienteController();
            List<Cliente> clientes = clienteController.ListarClientes();

            LBox_Clientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                LBox_Clientes.Items.Add(cliente);
            }
        }

        private void LimparCampos()
        {
            TB_NomeCliente.Text = "";
            TB_NifCliente.Text = "";
            TB_NumEstudanteCliente.Text = "";
            TB_EmailCliente.Text = "";
        }

        private void TB_NifCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBox_Clientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Mostrar os dados do cliente selecionado se for estudante procurar o numero de estudante e se for professor procurar o email
            if (LBox_Clientes.SelectedItem != null)
            {
                int clienteid = ((Cliente)LBox_Clientes.SelectedItem).Id;
                

                ClienteController clienteController = new ClienteController();
                Cliente cliente = clienteController.BuscarClientePorId(clienteid);

                if (cliente != null)
                {
                    TB_NomeCliente.Text = cliente.Nome;
                    TB_NifCliente.Text = cliente.Nif;

                    if (cliente is Estudante)
                    {
                        Estudante estudante = (Estudante)cliente;
                        TB_NumEstudanteCliente.Text = estudante.NumEstudante;
                        CB_Categoria.SelectedItem = "Estudante";
                        TB_EmailCliente.Text = "";
                    }
                    else if (cliente is Professor)
                    {
                        Professor professor = (Professor)cliente;
                        TB_EmailCliente.Text = professor.Email;
                        CB_Categoria.SelectedItem = "Professor";
                        TB_NumEstudanteCliente.Text = "";
                    }
                }
            }
        }

        private void BT_AdicionarClientes_Click_1(object sender, EventArgs e)
        {
            //Se a categoria for estudante, adicionar o numero de estudante
            if (CB_Categoria.SelectedItem.ToString() == "Estudante")
            {
                //Adicionar o numero de estudante
                EstudanteController estudanteController = new EstudanteController();
                Estudante estudante = new Estudante();
                estudante.Nome = TB_NomeCliente.Text;
                estudante.Nif = TB_NifCliente.Text;
                estudante.NumEstudante = TB_NumEstudanteCliente.Text;
                estudante.Saldo = 0;
                estudanteController.AdicionarEstudante(estudante);
                CarregarListBox();
            }
            //Se a categoria for professor, adicionar o email
            if (CB_Categoria.SelectedItem.ToString() == "Professor")
            {
                //Adicionar o email
                ProfessorController professorController = new ProfessorController();
                Professor professor = new Professor();
                professor.Nome = TB_NomeCliente.Text;
                professor.Nif = TB_NifCliente.Text;
                professor.Email = TB_EmailCliente.Text;
                professor.Saldo = 0;
                professorController.AdicionarProfessor(professor);
                CarregarListBox();
            }
        }

        private void BT_EditarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeFuncionario = LBox_Clientes.SelectedItem.ToString();

                ClienteController clienteController = new ClienteController();
                Cliente cliente = clienteController.BuscarClientePorNome(nomeFuncionario);

                if (cliente != null)
                {
                    cliente.Nome = TB_NomeCliente.Text;
                    cliente.Nif = TB_NifCliente.Text;
                    if (cliente is Estudante)
                    {
                        Estudante estudante = (Estudante)cliente;
                        estudante.NumEstudante = TB_NumEstudanteCliente.Text;
                        CB_Categoria.SelectedItem = "Estudante";
                        TB_EmailCliente.Text = "";
                    }
                    else if (cliente is Professor)
                    {
                        Professor professor = (Professor)cliente;
                        professor.Email = TB_EmailCliente.Text;
                        CB_Categoria.SelectedItem = "Professor";
                        TB_NumEstudanteCliente.Text = "";
                    }
                    //Se o nome ou o nif ou se for um estudante e o numero de estudante ou se for um professor e o email estiverem vazios, não atualiza
                    if (string.IsNullOrEmpty(cliente.Nome) || string.IsNullOrEmpty(cliente.Nif) || (cliente is Estudante && string.IsNullOrEmpty(TB_NumEstudanteCliente.Text)) || (cliente is Professor && string.IsNullOrEmpty(TB_EmailCliente.Text)))
                    {
                        MessageBox.Show("Preencha todos os campos.");
                        return;
                    }
                    else
                    {
                        clienteController.AtualizarCliente(cliente);


                        MessageBox.Show("Cliente atualizado com sucesso!");
                        CarregarListBox();
                        LimparCampos();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar funcionário: " + ex.Message);
            }
        }

        private void BT_RemoverClientes_Click(object sender, EventArgs e)
        {
            try
            {
                //Apagar funcionario da base de dados
                if (LBox_Clientes.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um cliente para remover.");
                    return;
                }
                int id = ((Cliente)LBox_Clientes.SelectedItem).Id;


                ClienteController clienteController = new ClienteController();
                //Ir buscar o cliente por id
                Cliente cliente = clienteController.BuscarClientePorId(id);
                if (cliente != null)
                {
                    clienteController.RemoverCliente(cliente);
                    MessageBox.Show("Cliente removido com sucesso!");
                    CarregarListBox();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover Cliente: " + ex.Message);
            }
        }

        private void bt_sair_Click_(object sender, EventArgs e)
        {
            //Sair do aplicativo
            Application.Exit();
        }
        private void bt_Funcionários_Click(object sender, EventArgs e)
        {
            //Abrir a janela de funcionários
            this.Hide();
            FuncionarioForm funcionario = new FuncionarioForm();
            funcionario.ShowDialog();
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

        private void bt_Clientes_Click(object sender, EventArgs e)
        {
            //Abrir a janela de clientes
            this.Hide();
            ClientesForm clientes = new ClientesForm();
            clientes.ShowDialog();
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

        private void bt_Extras_Click(object sender, EventArgs e)
        {
            //Abrir a janela de extras
            this.Hide();
            ExtrasForm extras = new ExtrasForm();
            extras.ShowDialog();
            this.Close();
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

        private void bt_saldo_Click(object sender, EventArgs e)
        {
            //Abrir a janela de saldo
            this.Hide();
            SaldoForm saldo = new SaldoForm();
            saldo.ShowDialog();
            this.Close();

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalForm principal = new PrincipalForm();
            principal.ShowDialog();
            this.Close();
        }
    }
}
