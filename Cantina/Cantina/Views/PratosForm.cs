using Cantina.Controllers;
using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina
{
    public partial class PratosForm : Form
    {
        public PratosForm()
        {
            InitializeComponent();
            CarregarCBPratos();
            CarregarListBox();
        }
        private void CarregarListBox()
        {
            //Carregar a listbox com os pratos
            PratoController pratoController = new PratoController();
            List<Prato> pratos = pratoController.ListarPratos();
            LBox_Pratos.Items.Clear();
            foreach (Prato prato in pratos)
            {
                LBox_Pratos.Items.Add(prato.descricao);
            }
        }
        
        private void CarregarCBPratos()
        {
            //Adicionar tipo de prato peixe carne e vegetariano
            CB_Tipo.Items.Add("Peixe");
            CB_Tipo.Items.Add("Carne");
            CB_Tipo.Items.Add("Vegetariano");
            
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Configurar o tipo de prato selecionado

           
        }

        private void BT_AdicionarPratos_Click(object sender, EventArgs e)
        {
            //Adicionar prato se os campos estiverem preenchidos e no fim limpa os campos
            try
            {
                PratoController pratoController = new PratoController();
                Prato prato = new Prato();
                prato.descricao = TB_Descricao.Text;
                prato.tipo = CB_Tipo.Text;
                //Tem de se fazer parse pois é int 
                prato.quantidade = Convert.ToInt32(tb_Quantidade.Text);
                
                //Se a checkbox estiver selecionada o prato fica ativo
                if (ck_Ativo.Checked)
                {
                    prato.ativo = true;
                }
                else
                {
                    prato.ativo = false;
                }
                //Se a descriçao, tipo ,quantidade e a checkbox nao estiver selecionada nao deixa adicionar o prato
                if (string.IsNullOrEmpty(prato.descricao) || string.IsNullOrEmpty(prato.tipo) || prato.quantidade < 0)
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                else if (prato.quantidade < 0)
                {
                    MessageBox.Show("A quantidade tem de ser maior que 0.");
                }
                else
                {
                    pratoController.AdicionarPrato(prato);
                    MessageBox.Show("Prato adicionado com sucesso!");

                    TB_Descricao.Text = "";
                    CB_Tipo.Text = "";
                    tb_Quantidade.Text = "";
                    ck_Ativo.Checked = false;
                    CarregarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar prato: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void LBox_Pratos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (LBox_Pratos.SelectedItem != null)
            {
                string descricao = LBox_Pratos.SelectedItem.ToString();

                PratoController pratoController = new PratoController();
                Prato prato = pratoController.BuscarPratoPorDescricao(descricao);

                if (prato != null)
                {
                    TB_Descricao.Text = prato.descricao;
                    CB_Tipo.Text = prato.tipo;
                    tb_Quantidade.Text = prato.quantidade.ToString();
                    if (prato.ativo)
                    {
                        ck_Ativo.Checked = true;
                    }
                    else
                    {
                        ck_Ativo.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Prato não encontrado.");
                }

            }
        }

        private void BT_EditarPratos_Click(object sender, EventArgs e)
        {
            //Editar prato se os campos estiverem preenchidos e no fim limpa os campos
           
                //Editar prato da base de dados
                try
                {
                    //Editar funcionario da base de dados
                    if (LBox_Pratos.SelectedItem == null)
                    {
                        MessageBox.Show("Selecione um prato para editar.");
                        return;
                    }

                    string descricao = LBox_Pratos.SelectedItem.ToString();

                    PratoController pratocontroller = new PratoController();
                    Prato prato = pratocontroller.BuscarPratoPorDescricao(descricao);

                    if (prato != null)
                    {
                        prato.descricao = TB_Descricao.Text;
                        prato.tipo = CB_Tipo.Text;
                        prato.ativo = ck_Ativo.Checked;
                        prato.quantidade = Convert.ToInt32(tb_Quantidade.Text);
                        //Se o nome ou username ou nif estiver vazio, não atualiza
                        if (string.IsNullOrEmpty(prato.descricao) || string.IsNullOrEmpty(prato.tipo))
                        {
                            MessageBox.Show("Preencha todos os campos.");
                            return;
                        }else if (prato.quantidade < 0)
                    {
                            MessageBox.Show("A quantidade tem de ser maior que 0.");
                        }
                        else
                        {
                            pratocontroller.AtualizarPrato(prato);


                            MessageBox.Show("Prato atualizado com sucesso!");


                            CarregarListBox();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Prato não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Editar Prato: " + ex.Message);
                }



            }

        private void BT_RemoverPratos_Click(object sender, EventArgs e)
        {
            //Remover prato se o prato estiver selecionado
            try
            {
                if (LBox_Pratos.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um prato para remover.");
                    return;
                }

                string descricao = LBox_Pratos.SelectedItem.ToString();

                PratoController pratoController = new PratoController();
                Prato prato = pratoController.BuscarPratoPorDescricao(descricao);


                if (prato != null)
                {
                    pratoController.RemoverPrato(prato);
                    MessageBox.Show("Prato removido com sucesso!");
                    CarregarListBox();
                }
                else
                {
                    MessageBox.Show("Prato não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover prato: " + ex.Message);
            }
        }
    }
    }

