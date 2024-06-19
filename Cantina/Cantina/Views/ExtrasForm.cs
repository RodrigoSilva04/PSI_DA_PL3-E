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

namespace Cantina.Views
{
    public partial class ExtrasForm : Form
    {
        public ExtrasForm()
        {
            InitializeComponent();
            CarregarListBox();
        }
        private void CarregarListBox()
        {
            ExtraController extraController = new ExtraController();
            List<Extra> extras = extraController.ListarExtras();

            LBox_Extras.Items.Clear();

            foreach (Extra extra in extras)
            {
                LBox_Extras.Items.Add(extra.Descricao);
            }
        }
        private void LimparCampos()
        {
            TB_Descricao.Text = "";
            TB_Preco.Text = "";
            ck_Ativo.Checked = false;
            tb_Quantidade.Text = "";
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BT_AdicionarExtra_Click(object sender, EventArgs e)
        {
            //Adicionar extra se os campos estiverem preenchidos e no fim limpa os campos
            try
            {
                ExtraController extraController = new ExtraController();
                Extra extra = new Extra();
                extra.Descricao = TB_Descricao.Text;
                extra.Preco = Convert.ToDouble(TB_Preco.Text);
                extra.Quantidade = Convert.ToInt32(tb_Quantidade.Text);
                //Se a checkbox estiver selecionada o extra fica ativo
                if (ck_Ativo.Checked)
                {
                    extra.Ativo = true;
                }
                else
                {
                    extra.Ativo = false;
                }
                if (string.IsNullOrEmpty(extra.Descricao) || string.IsNullOrEmpty(extra.Preco.ToString()) || string.IsNullOrEmpty(extra.Preco.ToString()))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                else if (extra.Preco < 0)
                {
                    MessageBox.Show("O preço não pode ser negativo.");
                    return;
                }
                else
                {
                    extraController.AdicionarExtra(extra);
                    MessageBox.Show("Extra adicionado com sucesso!");
                    TB_Descricao.Text = "";
                    TB_Preco.Text = "";
                    CarregarListBox();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar extra: " + ex.Message);
            }

        }

        private void BT_RemoverExtra_Click(object sender, EventArgs e)
        {
            //Remover extra selecionado
            try
            {
                ExtraController extraController = new ExtraController();
                Extra extra = extraController.BuscarExtraPorDescricao(LBox_Extras.SelectedItem.ToString());
                extraController.RemoverExtra(extra);
                MessageBox.Show("Extra removido com sucesso!");
                CarregarListBox();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover extra: " + ex.Message);
            }
        }

        private void LBox_Extras_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrar o extra selecionado nos campos de texto
            ExtraController extraController = new ExtraController();
            //Buscar o extra selecionado na listbox mas se for null nao faz nada
            if (LBox_Extras.SelectedItem != null)
            {
                Extra extra = extraController.BuscarExtraPorDescricao(LBox_Extras.SelectedItem.ToString());
                TB_Descricao.Text = extra.Descricao;
                TB_Preco.Text = extra.Preco.ToString();
                tb_Quantidade.Text = extra.Quantidade.ToString();
                if (extra.Ativo)
                {
                    ck_Ativo.Checked = true;
                }
                else
                {
                    ck_Ativo.Checked = false;
                }
            }
            

            

        }

        private void BT_EditarExtra_Click(object sender, EventArgs e)
        {
            //Editar extra se os campos estiverem preenchidos e no fim limpa os campos

            //Editar extra da base de dados
            try
            {
                //Editar funcionario da base de dados
                if (LBox_Extras.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um extra para editar.");
                    return;
                }

                string Descricao = LBox_Extras.SelectedItem.ToString();

                ExtraController extracontroller = new ExtraController();
                Extra extra = extracontroller.BuscarExtraPorDescricao(Descricao);

                if (extra != null)
                {
                    extra.Descricao = TB_Descricao.Text;
                    extra.Preco = Convert.ToDouble(TB_Preco.Text);
                    extra.Ativo = ck_Ativo.Checked;
                    extra.Quantidade = Convert.ToInt32(tb_Quantidade.Text);
                    //Se o nome ou username ou nif estiver vazio, não atualiza
                    if (string.IsNullOrEmpty(extra.Descricao))
                    {
                        MessageBox.Show("Preencha a descriçao.");
                        return;
                    }
                    else if (extra.Quantidade < 0)
                    {
                        MessageBox.Show("A quantidade tem de ser maior que 0.");
                    }
                    else if (extra.Preco < 0)
                    {
                        MessageBox.Show("O preço tem de ser maior que 0.");
                    }
                    else
                    {
                        extracontroller.AtualizarExtra(extra);


                        MessageBox.Show("Extra atualizado com sucesso!");


                        CarregarListBox();
                    }

                }
                else
                {
                    MessageBox.Show("Extra não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar Extra: " + ex.Message);
            }
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
