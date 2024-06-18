using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cantina.Controllers;
using GereCantina.Models;
using Menu = GereCantina.Models.Menu;

namespace Cantina
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            CarregarListBoxs();
        }

        private void CarregarListBoxs()
        {
            // Carregar listboxs com pratos e extras se ativos
            PratoController pratoController = new PratoController();
            ExtraController extraController = new ExtraController();
            List<Prato> pratos = pratoController.ListarPratos();
            List<Extra> extras = extraController.ListarExtras();
            // Carregar tambem todos os menus
            MenuController menuController = new MenuController();
            List<Menu> menus = menuController.ListarMenus();

            LBox_MenuAtual.Items.Clear();
            LBox_PratosMenu.Items.Clear();
            LBox_ExtrasMenu.Items.Clear();
            LBox_TodosMenus.Items.Clear();

            foreach (Menu menu in menus)
            {
                LBox_TodosMenus.Items.Add(menu);
            }
            foreach (Prato prato in pratos)
            {
                if (prato.ativo)
                {
                    LBox_PratosMenu.Items.Add(prato);
                }
            }
            foreach (Extra extra in extras)
            {
                if (extra.Ativo)
                {
                    LBox_ExtrasMenu.Items.Add(extra);
                }
            }
            LBox_PratosMenu.DisplayMember = "descricao";
            LBox_ExtrasMenu.DisplayMember = "Descricao";
        }

        private void LBox_PratosMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RefreshMenuAtual()
        {
            LBox_MenuAtual.Items.Clear();
        }

        private void BT_AdicionarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se todos os campos obrigatórios estão preenchidos e se há pelo menos um prato ou extra no menu
                if (string.IsNullOrEmpty(tb_Quantidade.Text) ||
                    string.IsNullOrEmpty(TB_precoEstudante.Text) ||
                    string.IsNullOrEmpty(TB_precoProfessor.Text) ||
                    LBox_MenuAtual.Items.Count == 0)
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios e adicione pelo menos um prato ou extra ao menu.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Criar uma cópia dos itens de LBox_MenuAtual.Items para evitar modificação durante a iteração
                List<object> itemsCopy = new List<object>();
                foreach (var item in LBox_MenuAtual.Items)
                {
                    itemsCopy.Add(item);
                }

                // Filtra e seleciona os pratos e extras da cópia dos itens
                List<Prato> pratos = new List<Prato>();
                List<Extra> extras = new List<Extra>();

                foreach (var item in itemsCopy)
                {
                    if (item is Prato prato)
                    {
                        pratos.Add(prato);
                    }
                    else if (item is Extra extra)
                    {
                        extras.Add(extra);
                    }
                }

                // Debug output para o número de pratos e extras detectados
                lb_Debug.Text = $"Pratos count: {pratos.Count}, Extras count: {extras.Count}";

                // Define a data e hora para o menu
                DateTime dataHora = DTData_Menu.Value.Date + DTHora_Menu.Value.TimeOfDay;

                // Cria um novo objeto Menu e atribui as propriedades
                Menu novoMenu = new Menu
                {
                    DataHora = dataHora,
                    QtdDisponivel = int.Parse(tb_Quantidade.Text),
                    PrecoEstudante = decimal.Parse(TB_precoEstudante.Text),
                    PrecoProfessor = decimal.Parse(TB_precoProfessor.Text),
                    Pratos = pratos, // Atribui a lista de pratos à propriedade Pratos
                    Extras = extras  // Atribui a lista de extras à propriedade Extras
                };
                

                // Adiciona o novo menu ao banco de dados
                MenuController menuController = new MenuController();
                menuController.AdicionarMenu(novoMenu, pratos, extras);
                //Debug se o menu foi criado corretamente
                lb_debug2.Text = $"Menu criado: {novoMenu.DataHora}, {novoMenu.QtdDisponivel}, {novoMenu.PrecoEstudante}, {novoMenu.PrecoProfessor}";
                lb_debug2.Text = $"Menu criado: {novoMenu.DataHora}, {novoMenu.QtdDisponivel}, {novoMenu.PrecoEstudante}, {novoMenu.PrecoProfessor}";

                // Recarrega as listas e limpa as seleções atuais do menu
                CarregarListBoxs();
                LBox_MenuAtual.Items.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao converter um dos campos numéricos. Verifique se a quantidade e os preços estão no formato correto.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Um dos campos obrigatórios está vazio. Verifique todos os campos e tente novamente.", "Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao adicionar o menu: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_adicionarPrato_Click(object sender, EventArgs e)
        {
            if (!LBox_MenuAtual.Items.OfType<Prato>().Any())
            {
                if (LBox_PratosMenu.SelectedItem != null)
                {
                    LBox_MenuAtual.Items.Add(LBox_PratosMenu.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecione um prato para adicionar");
                }
            }
            else
            {
                MessageBox.Show("Já tem um prato adicionado ao menu atual");
            }
            LBox_MenuAtual.DisplayMember = "descricao";
        }

        private void bt_removerExtra_Click(object sender, EventArgs e)
        {
            if (LBox_MenuAtual.SelectedItem is Extra)
            {
                LBox_MenuAtual.Items.Remove(LBox_MenuAtual.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um extra para remover");
            }

        }

        private void bt_removerPrato_Click(object sender, EventArgs e)
        {
            if (LBox_MenuAtual.SelectedItem is Prato)
            {
                LBox_MenuAtual.Items.Remove(LBox_MenuAtual.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um prato para remover");
            }
        }

        private void bt_adicionarextra_Click(object sender, EventArgs e)
        {
            if (LBox_MenuAtual.Items.OfType<Extra>().Count() < 3)
            {
                if (LBox_ExtrasMenu.SelectedItem != null)
                {
                    LBox_MenuAtual.Items.Add(LBox_ExtrasMenu.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Selecione um extra para adicionar");
                }
            }
            else
            {
                MessageBox.Show("Já tem 3 extras adicionados ao menu atual");
            }
            LBox_MenuAtual.DisplayMember = "Descricao";
        }

        private void LBox_TodosMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBox_TodosMenus.SelectedItem != null)
            {
                try
                {
                    MenuController menuController = new MenuController();
                    int id = ((Menu)LBox_TodosMenus.SelectedItem).Id;
                    Menu menu = menuController.BuscarMenuPorId(id);

                    tb_Quantidade.Text = menu.QtdDisponivel.ToString();
                    TB_precoEstudante.Text = menu.PrecoEstudante.ToString("F2");
                    TB_precoProfessor.Text = menu.PrecoProfessor.ToString("F2");
                    DTData_Menu.Value = menu.DataHora.Date;
                    DTHora_Menu.Value = menu.DataHora;

                    LBox_MenuAtual.Items.Clear();
                    foreach (Prato prato in menu.Pratos)
                    {
                        LBox_MenuAtual.Items.Add(prato);
                    }
                    foreach (Extra extra in menu.Extras)
                    {
                        LBox_MenuAtual.Items.Add(extra);
                    }
                    LBox_PratosMenu.DisplayMember = "descricao";
                    LBox_ExtrasMenu.DisplayMember = "Descricao";

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

        private void BT_RemoverMenu_Click(object sender, EventArgs e)
        {
            if (LBox_TodosMenus.SelectedItem != null)
            {
                MenuController menuController = new MenuController();
                int id = ((Menu)LBox_TodosMenus.SelectedItem).Id;
                Menu menu = menuController.BuscarMenuPorId(id);
                menuController.RemoverMenu(menu);
                CarregarListBoxs();
            }
            else
            {
                MessageBox.Show("Selecione um menu para remover");
            }
        }
        private void LimparCampos()
        {
            tb_Quantidade.Text = "";
            TB_precoEstudante.Text = "";
            TB_precoProfessor.Text = "";
            DTData_Menu.Value = DateTime.Now;
            DTHora_Menu.Value = DateTime.Now;
            
        }

        private void BT_EditarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBox_TodosMenus.SelectedItem != null &&
                    !string.IsNullOrEmpty(tb_Quantidade.Text) &&
                    !string.IsNullOrEmpty(TB_precoEstudante.Text) &&
                    !string.IsNullOrEmpty(TB_precoProfessor.Text) &&
                    LBox_MenuAtual.Items.Count > 0)
                {
                    MenuController menuController = new MenuController();
                    int id = ((Menu)LBox_TodosMenus.SelectedItem).Id;
                    Menu menu = menuController.BuscarMenuPorId(id);

                    // Atualizar os campos do menu com os novos valores da interface do usuário
                    menu.QtdDisponivel = int.Parse(tb_Quantidade.Text);
                    menu.PrecoEstudante = decimal.Parse(TB_precoEstudante.Text);
                    menu.PrecoProfessor = decimal.Parse(TB_precoProfessor.Text);
                    menu.Pratos = LBox_MenuAtual.Items.OfType<Prato>().ToList();
                    menu.Extras = LBox_MenuAtual.Items.OfType<Extra>().ToList();

                    // Atualizar o menu no contexto do Entity Framework
                    menuController.AtualizarMenu(menu);

                    // Recarregar listas e limpar seleções
                    CarregarListBoxs();
                    LBox_MenuAtual.Items.Clear();

                    MessageBox.Show("Menu atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios e adicione pelo menos um prato ou extra ao menu.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao converter um dos campos numéricos. Verifique se a quantidade e os preços estão no formato correto.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Um dos campos obrigatórios está vazio. Verifique todos os campos e tente novamente.", "Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao editar o menu: {ex.Message}", "Erro ao Editar Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
    
}
