using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina.Controllers;
using GereCantina.Models;


namespace Cantina
{
    public partial class ReservasForm : Form
    {
        public ReservasForm()
        {
            InitializeComponent();
            CarregarListBoxs();
        }
        private void ResetQuantidades()
        {
            TB_qntPrato.Text = "";
            TB_qntExtra.Text = "";
        }

        private void LBox_PratosReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se for um prato selecionado aparecer a quantidade disponivel desse prato 
            if (LBox_PratosReserva.SelectedItem != null)
            {
                try
                {
                    if (LBox_PratosReserva.SelectedItem is Prato)
                    {
                        Prato prato = (Prato)LBox_PratosReserva.SelectedItem;
                        TB_qntPrato.Text = prato.quantidade.ToString();
                    }
                    else
                    {
                        ResetQuantidades();
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar o prato selecionado. Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar a seleção: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void CarregarListBoxs()
        {
            //Carregar a listbox com os menus
            MenuController menuController = new MenuController();
            List<GereCantina.Models.Menu> menus = menuController.ListarMenus();
            ClienteController clienteController = new ClienteController();
            List<Cliente> clientes = clienteController.ListarClientes();
            //Limpar a listbox
            LBox_Menus.Items.Clear();
            LBox_Clientes.Items.Clear();
            foreach (GereCantina.Models.Menu menu in menus)
            {
                LBox_Menus.Items.Add(menu);
            }
            foreach (Cliente cliente in clientes)
            {
                LBox_Clientes.Items.Add(cliente);
            }
           
        }

        private void LBox_Menus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBox_Menus.SelectedItem != null)
            {
                try
                {
                    MenuController menuController = new MenuController();
                    
                    int id = ((GereCantina.Models.Menu)LBox_Menus.SelectedItem).Id;
                    GereCantina.Models.Menu menu = menuController.BuscarMenuPorId(id);
                    LBox_PratosReserva.Items.Clear();
                    LBox_ExtrasReserva.Items.Clear();
                    //Se o cliente selecionado for professor ou aluno aparece o preco do menu conforme o tipo de cliente
                    if (LBox_Clientes.SelectedItem != null)
                    {
                        Cliente cliente = (Cliente)LBox_Clientes.SelectedItem;
                        if (cliente is Professor)
                        {
                            tb_PrecoMenu.Text = menu.PrecoProfessor.ToString();
                        }
                        else if (cliente is Estudante)
                        {
                            tb_PrecoMenu.Text = menu.PrecoEstudante.ToString();
                        }
                    }else
                    {
                        MessageBox.Show("Selecione um cliente para ver o preço do menu", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    foreach (Prato prato in menu.Pratos)
                    {
                        LBox_PratosReserva.Items.Add(prato);
                        LBox_PratosReserva.DisplayMember = "descricao";
                    }
                    foreach (Extra extra in menu.Extras)
                    {
                        //Adicionar os extras à listbox com o nome do extra e o preco de cada extra 
                        
                        LBox_ExtrasReserva.Items.Add(extra);
                        LBox_ExtrasReserva.DisplayMember = "Descricao";
                        // Set the format string as DisplayMember for LBox_ExtrasReserva


                    }
                    //Se ja estiver pratos e extras na reserva limpa a reserva
                    if (LBox_Reserva.Items.Count > 0)
                    {
                        LBox_Reserva.Items.Clear();
                        MessageBox.Show("Selecionou outro menu os itens da reserva foram limpos");
                    }
                    tb_Total.Text = CalcularTotal().ToString();
                    ResetQuantidades();
                    
                    

                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar o menu selecionado. Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar a seleção: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bt_adicionarPratoReserva_Click(object sender, EventArgs e)
        {
            // Verifica se os pratos, extras e clientes foram selecionados
            if (LBox_PratosReserva.SelectedItems != null && LBox_Clientes.SelectedItem != null)
            {
                try
                {
                    // Limpa a ListBox atual de seleção de itens da reserva (se necessário)

                    // Adiciona os pratos selecionados à ListBox de itens da reserva
                    foreach (var item in LBox_PratosReserva.SelectedItems)
                    {
                        var prato = item as Prato;
                        if (prato != null)
                        {
                            LBox_Reserva.Items.Add(prato);
                            LBox_Reserva.DisplayMember = "Descricao";
                            //Mostrar a descricao do prato


                        }
                    }


                    MessageBox.Show("Itens adicionados à reserva com sucesso!", "Itens Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao adicionar itens à reserva: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um prato, e um cliente para adicionar à reserva.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_AdicionarExtraReserva_Click(object sender, EventArgs e)
        {
            // Verifica se extras e clientes foram selecionados
            if (LBox_ExtrasReserva.SelectedItems != null && LBox_Clientes.SelectedItem != null)
            {
                try
                {
                    // Adiciona os pratos selecionados à ListBox de itens da reserva
                    foreach (var item in LBox_ExtrasReserva.SelectedItems)
                    {
                        var extra = item as Extra;
                        if (extra != null)
                        {
                            LBox_Reserva.Items.Add(extra);
                            LBox_ExtrasReserva.DisplayMember = "Descricao";
                        }
                        else
                        {
                            MessageBox.Show("Nao deu");
                        }

                    }
                    tb_Total.Text = CalcularTotal().ToString();


                    MessageBox.Show("Itens adicionados à reserva com sucesso!", "Itens Adicionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao adicionar itens à reserva: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um prato, e um cliente para adicionar à reserva.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private double CalcularTotal()
        {
            double total = 0;

            // Parse the base price from tb_PrecoMenu.Text
            if (double.TryParse(tb_PrecoMenu.Text, out double precoMenu))
            {
                total += precoMenu;
            }
            else
            {
                // Handle parsing error if necessary
                // Example: MessageBox.Show("Preço do menu inválido.");
                // return total;
            }

            // Iterate through items in LBox_Reserva.Items
            foreach (var item in LBox_Reserva.Items)
            {
                if (item is Prato)
                {
                    Prato prato = (Prato)item;
                    // Accumulate additional costs for Pratos if necessary
                    // Example: total += prato.Preco;
                }
                else if (item is Extra)
                {
                    Extra extra = (Extra)item;
                    total += extra.Preco;
                }
            }

            return total;
        }

        private void LBox_ExtrasReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Extra aparecer a quantidade disponivel desse extra
            if (LBox_ExtrasReserva.SelectedItem != null)
            {
                try
                {
                    if (LBox_ExtrasReserva.SelectedItem is Extra)
                    {
                        Extra extra = (Extra)LBox_ExtrasReserva.SelectedItem;
                        TB_qntExtra.Text = extra.Quantidade.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Nao deu");
                        ResetQuantidades();
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar o extra selecionado. Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar a seleção: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

        }
    }
}
