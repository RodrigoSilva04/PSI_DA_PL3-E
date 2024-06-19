using Cantina.Controllers;
using GereCantina.Controllers;
using GereCantina.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            // Ir buscar a multa selecionada por id, preencher os campos com os valores da multa
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
            ReservaController reservaController = new ReservaController();
            //Listar todas as reservas
            List<Reserva> reservas = reservaController.ListarReservas();

            LB_Multas.Items.Clear();
            LB_Reservas.Items.Clear();
            foreach (Reserva reserva in reservas)
            {
                // Exemplo: Mostrar o nome do cliente na listbox que pertence a reserva
                LB_Reservas.Items.Add(reserva);
            }

            foreach (Multa multa in multas)
            {
                LB_Multas.Items.Add(multa);
            }

            LB_Multas.DisplayMember = "DisplayText"; // Display member to show custom string
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Adicionar uma nova multa
            try
            {
                MultaController multaController = new MultaController();
                Multa multa = new Multa
                {
                    Valor = decimal.Parse(TB_PrecoMulta.Text),
                    NumHoras = int.Parse(TB_HorasMulta.Text),
                };

                multaController.AdicionarMulta(multa);
                MessageBox.Show("Multa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_RemoverMulta_Click(object sender, EventArgs e)
        {
            // Apagar uma multa da base de dados
            try
            {
                if (LB_Multas.SelectedItem != null)
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_EditarMulta_Click(object sender, EventArgs e)
        {
            // Editar uma multa existente
            try
            {
                if (LB_Multas.SelectedItem != null)
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

                        multaController.AtualizarMulta(multa);
                        MessageBox.Show("Multa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        CarregarListBox();
                    }
                    else
                    {
                        MessageBox.Show("Multa não encontrada.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma multa para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            TB_PrecoMulta.Text = "";
            TB_HorasMulta.Text = "";
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
