using Cantina.Controllers;
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
    public partial class MultasForm : Form
    {
        public MultasForm()
        {
            InitializeComponent();
            CarregarListBox();
            LimparCampos();
        }

        private void LBox_Multas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Ir buscar a multa selecionada por id, preencher os campos com os valores da multa
            if (LB_Multas.SelectedItem != null)
            {
                MultaController multaController = new MultaController();
                int idMulta = ((Multa)LB_Multas.SelectedItem).Id;
                Multa multa = multaController.BuscarMultaPorId(idMulta);

                if (multa != null)
                {
                    TB_PrecoMulta.Text = multa.Valor.ToString();
                    TB_HorasMulta.Text = multa.NumHoras.ToString();
                }
            }
        }
        private void CarregarListBox()
        {
            MultaController multaController = new MultaController();
            List<Multa> multas = multaController.ListarMultas();

            LB_Multas.Items.Clear();

            foreach (Multa multa in multas)
            {
                LB_Multas.Items.Add(multa.Id);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MultaController multaController = new MultaController();
            Multa multa = new Multa();
            multa.Valor = decimal.Parse(TB_PrecoMulta.Text);
            multa.NumHoras = int.Parse(TB_HorasMulta.Text);
            multaController.AdicionarMulta(multa);
            LimparCampos();
            CarregarListBox();
        }

        private void BT_RemoverMulta_Click(object sender, EventArgs e)
        {
            //Apagar uma multa da base de dados
            try
            {
                string valorMulta = LB_Multas.SelectedItem.ToString();

                MultaController multaController = new MultaController();
                int idMulta = ((Multa)LB_Multas.SelectedItem).Id;
                Multa multa = multaController.BuscarMultaPorId(idMulta);

                if (multa != null)
                {
                    multaController.RemoverMulta(multa);
                    MessageBox.Show("Multa removida com sucesso!");
                    CarregarListBox();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover multa: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            TB_PrecoMulta.Text = "";
            TB_HorasMulta.Text = "";
        }

        private void BT_EditarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                MultaController multaController = new MultaController();
                int idMulta = ((Multa)LB_Multas.SelectedItem).Id;
                Multa multa = multaController.BuscarMultaPorId(idMulta);

                if (multa != null)
                {
                    if (decimal.TryParse(TB_PrecoMulta.Text, out decimal valorMulta))
                    {
                        multa.Valor = valorMulta;
                    }
                    else
                    {
                        MessageBox.Show("Valor da multa inválido.");
                        return;
                    }
                    if (int.TryParse(TB_HorasMulta.Text, out int numHorasMulta))
                    {
                        multa.NumHoras = numHorasMulta;
                    }
                    else
                    {
                        MessageBox.Show("Número de horas inválido.");
                        return;
                    }
                    //Se o nome ou username ou nif estiver vazio, não atualiza
                    if (string.IsNullOrEmpty(TB_PrecoMulta.Text) || string.IsNullOrEmpty(TB_HorasMulta.Text))
                    {
                        MessageBox.Show("Preencha todos os campos.");
                        return;
                    }
                    else
                    {
                        multaController.AtualizarMulta(multa);
                        MessageBox.Show("Multa adicionada com sucesso!");

                        TB_PrecoMulta.Text = "";
                        TB_HorasMulta.Text = "";

                        CarregarListBox();
                    }


                }
                else
                {
                    MessageBox.Show("Multa não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar Multa: " + ex.Message);
            }
        }

        private void TB_PrecoMulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
