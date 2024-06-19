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
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Cantina
{
    public partial class ReservasForm : Form
    {
        public ReservasForm()
        {
            InitializeComponent();
            CarregarListBoxs();
            CarregarListBoxReservas();
        }
        private void ResetQuantidades()
        {
            TB_qntPrato.Text = "";
            TB_qntExtra.Text = "";
        }
        private void CarregarListBoxReservas()
        {
            ReservaController reservaController = new ReservaController();
            List<Reserva> reservas = reservaController.ListarReservas();

            LBox_Reservas.Items.Clear();
            LBox_ReservasUsadas.Items.Clear();

            foreach (Reserva reserva in reservas)
            {
                LBox_Reservas.Items.Add(reserva);
            }
            foreach (Reserva reserva in reservas)
            {
                if (reserva.usada == true)
                {
                    LBox_ReservasUsadas.Items.Add(reserva);
                }
            }
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
                    MessageBox.Show($"Ocorreu um erro ao carregar o prato selecionado {ex.Message}. Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar a seleção: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void CarregarListBoxs()
        {
            MenuController menuController = new MenuController();
            List<GereCantina.Models.Menu> menus = menuController.ListarMenus();
            ClienteController clienteController = new ClienteController();
            List<Cliente> clientes = clienteController.ListarClientes();
            MultaController multaController = new MultaController();
            List<Multa> multas = multaController.ListarMultas();

            // Limpar e adicionar itens às ListBox
            LBox_Menus.Items.Clear();
            LBox_Clientes.Items.Clear();
            LBox_Multas.Items.Clear();

            foreach (GereCantina.Models.Menu menu in menus)
            {
                LBox_Menus.Items.Add(menu);
            }

            foreach (Cliente cliente in clientes)
            {
                LBox_Clientes.Items.Add(cliente);
            }
            foreach (Multa multa in multas)
            {
                LBox_Multas.Items.Add(multa);
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
                    } else
                    {
                        MessageBox.Show("Selecione um cliente para ver o preço do menu", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //Atualiza a data do menu para o datetime picker e a hora
                    DTData_Menu.Value = menu.DataHora.Date;
                    DTHora_Menu.Value = menu.DataHora;


                    foreach (Prato prato in menu.Pratos)
                    {
                        LBox_PratosReserva.Items.Add(prato);
                        
                    }
                    foreach (Extra extra in menu.Extras)
                    {
                        //Adicionar os extras à listbox com o nome do extra e o preco de cada extra 

                        LBox_ExtrasReserva.Items.Add(extra);
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
                    MessageBox.Show($"Ocorreu um erro ao carregar o menu selecionado.{ex.Message} Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    foreach (var item in LBox_PratosReserva.SelectedItems)
                    {
                        var prato = item as Prato;
                        if (prato != null && !LBox_Reserva.Items.Contains(prato))
                        {
                            LBox_Reserva.Items.Add(prato);
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
                    foreach (var item in LBox_ExtrasReserva.SelectedItems)
                    {
                        var extra = item as Extra;
                        if (extra != null && !LBox_Reserva.Items.Contains(extra))
                        {
                            LBox_Reserva.Items.Add(extra);
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

            // Dá Parse ao preço de tb_PrecoMenu.Text
            if (double.TryParse(tb_PrecoMenu.Text, out double precoMenu))
            {
                total += precoMenu;
            }
            else
            {
                
                MessageBox.Show("Preço do menu inválido.");
                
            }

            
            foreach (var item in LBox_Reserva.Items)
            {
                if (item is Prato)
                {
                    Prato prato = (Prato)item;
                    
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
                        ResetQuantidades();
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao carregar o extra selecionado.{ex.Message} Tente novamente.", "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar a seleção: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void bt_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            // Verifica se há itens na reserva e se um cliente foi selecionado
            if (LBox_Reserva.Items.Count > 0 && LBox_Clientes.SelectedItem != null)
            {
                try
                {
                    ClienteController clienteController = new ClienteController();
                    PratoController pratoController = new PratoController();
                    ExtraController extraController = new ExtraController();
                    MenuController menuController = new MenuController();
                    FaturaController faturaController = new FaturaController(); // Controlador para a fatura
                    ItemFaturaController itemFaturaController = new ItemFaturaController(); // Controlador para itens de fatura
                    ReservaController reservaController = new ReservaController(); // Controlador para a reserva

                    // Ir buscar o cliente selecionado por id
                    Cliente cliente = clienteController.BuscarClientePorId(((Cliente)LBox_Clientes.SelectedItem).Id);

                    double total = CalcularTotal();

                    // Variável para controlar se há quantidade suficiente
                    bool quantidadeSuficiente = true;

                    // Verifica as quantidades dos pratos e extras
                    foreach (var item in LBox_Reserva.Items)
                    {
                        if (item is Prato prato)
                        {
                            if (prato.quantidade <= 0)
                            {
                                quantidadeSuficiente = false;
                                MessageBox.Show($"Quantidade insuficiente para o prato: {prato.descricao}", "Quantidade Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        else if (item is Extra extra)
                        {
                            if (extra.Quantidade <= 0)
                            {
                                quantidadeSuficiente = false;
                                MessageBox.Show($"Quantidade insuficiente para o extra: {extra.Descricao}", "Quantidade Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                    }

                    // Verifica se o saldo do cliente é suficiente
                    if (cliente.Saldo >= total)
                    {
                        // Cria uma nova reserva
                        Reserva reserva = new Reserva
                        {
                            Cliente = cliente,
                            clienteId = cliente.Id,
                            Menus = new List<GereCantina.Models.Menu>(),
                            Pratos = new List<Prato>(),
                            Extras = new List<Extra>(),
                            Multas = new List<Multa>()
                        };

                        // Ir buscar o menu selecionado por id e adicioná-lo à coleção de Menus
                        var menuSelecionado = menuController.BuscarMenuPorId(((GereCantina.Models.Menu)LBox_Menus.SelectedItem).Id);
                        if (menuSelecionado != null)
                        {
                            reserva.Menus.Add(menuSelecionado);
                        }

                        // Se todas as quantidades forem suficientes, prossegue com a reserva
                        if (quantidadeSuficiente)
                        {
                            // Adiciona pratos e extras à reserva e atualiza as quantidades
                            foreach (var item in LBox_Reserva.Items)
                            {
                                if (item is Prato pratoItem)
                                {
                                    // Busca o prato do banco de dados pelo ID
                                    Prato prato = pratoController.BuscarPratoPorId(pratoItem.id);
                                    if (prato != null)
                                    {
                                        prato.quantidade--; // Decrementa a quantidade disponível do prato
                                        pratoController.AtualizarPrato(prato); // Atualiza o prato no banco de dados
                                        reserva.Pratos.Add(prato);
                                    }
                                }
                                else if (item is Extra extraItem)
                                {
                                    // Busca o extra do banco de dados pelo ID
                                    Extra extra = extraController.BuscarExtraPorId(extraItem.Id);
                                    if (extra != null)
                                    {
                                        extra.Quantidade--; // Decrementa a quantidade disponível do extra
                                        extraController.AtualizarExtra(extra); // Atualiza o extra no banco de dados
                                        reserva.Extras.Add(extra);
                                    }
                                }
                            }

                            // Adiciona multa à reserva
                            if (LBox_Multas.SelectedItem != null)
                            {
                                reserva.Multas.Add((Multa)LBox_Multas.SelectedItem);
                            }
                            else
                            {
                                MessageBox.Show("Selecione uma multa para adicionar à reserva.", "Multa não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // Sai do método se não houver multa selecionada
                            }

                            // Salva a reserva no banco de dados
                            reservaController.AdicionarReserva(reserva);

                            // Cria uma nova fatura para a reserva
                            Fatura fatura = new Fatura
                            {
                                Total = (decimal)total,
                                DataHora = DateTime.Now,
                                Cliente = cliente,
                                ClienteId = cliente.Id,
                                ItensFatura = new List<ItemFatura>()
                            };

                            // Adiciona itens de fatura para cada prato na reserva
                            foreach (var prato in reserva.Pratos)
                            {
                                fatura.ItensFatura.Add(new ItemFatura
                                {
                                    Descricao = prato.descricao,
                                    //Preco é igual ao preco do menu
                                    Preco = Convert.ToDecimal(tb_PrecoMenu.Text)
                                });
                                
                            }

                            // Adiciona itens de fatura para cada extra na reserva
                            foreach (var extra in reserva.Extras)
                            {
                                // Converte o preço para decimal explicitamente
                                decimal preco = Convert.ToDecimal(extra.Preco);

                                // Adiciona o item à fatura
                                fatura.ItensFatura.Add(new ItemFatura
                                {
                                    Descricao = extra.Descricao,
                                    Preco = preco
                                });
                            }

                            // Adiciona multa à fatura
                            if (reserva.Multas.Any())
                            {
                                string descricao = ("Multas:");
                                fatura.ItensFatura.Add(new ItemFatura
                                {
                                    Descricao = descricao, // Assume que há apenas uma multa por reserva
                                    Preco = reserva.Multas.First().Valor
                                });
                            }

                            // Salva a fatura no banco de dados
                            faturaController.AdicionarFatura(fatura);

                            MessageBox.Show("Reserva efetuada com sucesso!", "Reserva Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GerarFaturaPDF(fatura);

                            // Limpa os campos e lista de itens da reserva
                            LBox_Reserva.Items.Clear();
                            tb_Total.Text = "";
                            tb_PrecoMenu.Text = "";
                            ResetQuantidades();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para efetuar a reserva.", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao efetuar a reserva: {ex.Message}", "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um prato e um cliente para efetuar a reserva.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GerarArquivoTextoReserva(Reserva reserva)
        {

            // Carrega o cliente explicitamente se não estiver carregado
            if (reserva.Cliente == null && reserva.clienteId != 0)
            {
                ClienteController clienteController = new ClienteController();
                reserva.Cliente = clienteController.BuscarClientePorId(reserva.clienteId);
            }

            // Verifica se o cliente foi carregado corretamente
            if (reserva.Cliente != null)
            {
                // Define o caminho e o nome do arquivo de texto
                string filePath = $"Reserva_{reserva.id}.txt";

                // Usa StreamWriter para escrever no arquivo de texto
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Escreve as informações do cliente
                    writer.WriteLine("Informações do Cliente");
                    writer.WriteLine($"ID do Cliente: {reserva.clienteId}");
                    writer.WriteLine($"Nome do Cliente: {reserva.Cliente.Nome}");
                    writer.WriteLine($"Saldo do Cliente: {reserva.Cliente.Saldo}");
                    writer.WriteLine();

                    // Escreve as informações da reserva
                    writer.WriteLine("Informações da Reserva");
                    writer.WriteLine($"ID da Reserva: {reserva.id}");
                    writer.WriteLine($"Data da Reserva: {DateTime.Now}");
                    writer.WriteLine();

                    // Escreve os pratos da reserva
                    writer.WriteLine("Pratos");
                    foreach (var prato in reserva.Pratos)
                    {
                        writer.WriteLine($"Prato: {prato.descricao}");
                        writer.WriteLine($"Preço: {tb_PrecoMenu.Text}");
                        writer.WriteLine($"Quantidade disponível: {prato.quantidade}");
                        writer.WriteLine();
                    }

                    // Escreve os extras da reserva
                    writer.WriteLine("Extras");
                    foreach (var extra in reserva.Extras)
                    {
                        writer.WriteLine($"Extra: {extra.Descricao}");
                        writer.WriteLine($"Preço: {extra.Preco}");
                        writer.WriteLine();
                    }

                    // Escreve o total da reserva
                    writer.WriteLine($"Total da Reserva: {CalcularTotal()}");
                    writer.WriteLine();

                    // Escreve as multas da reserva (se houver)
                    if (reserva.Multas != null && reserva.Multas.Count > 0)
                    {
                        writer.WriteLine("Multas");
                        foreach (var multa in reserva.Multas)
                        {
                            writer.WriteLine($"Valor da Multa: {multa.Valor}");
                            writer.WriteLine($"Número de Horas: {multa.NumHoras}");
                            writer.WriteLine();
                        }
                    }
                    else
                    {
                        writer.WriteLine($"Não foi detetada qualquer multa");
                        writer.WriteLine();
                    }

                }

                MessageBox.Show($"Arquivo de texto da reserva gerado com sucesso: {filePath}", "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void GerarFaturaPDF(Fatura fatura)
        {
            // Configurações iniciais do documento PDF
            Document doc = new Document();
            string nomeArquivo = "Fatura_" + fatura.Id + ".pdf";
            string caminhoDiretorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Faturas");

            // Verifica se o diretório existe; se não, cria o diretório
            if (!Directory.Exists(caminhoDiretorio))
            {
                Directory.CreateDirectory(caminhoDiretorio);
            }

            string caminhoArquivo = Path.Combine(caminhoDiretorio, nomeArquivo);

            try
            {
                // Criação do documento PDF
                PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));

                // Abre o documento para escrita
                doc.Open();

                // Adiciona título
                Paragraph titulo = new Paragraph("Fatura");
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                // Adiciona informações da fatura
                doc.Add(new Paragraph($"ID da Fatura: {fatura.Id}"));
                doc.Add(new Paragraph($"Data e Hora: {fatura.DataHora}"));
                doc.Add(new Paragraph($"Total: {fatura.Total:C}")); // Formata o valor como moeda

                // Adiciona os itens da fatura
                PdfPTable table = new PdfPTable(2); // Tabela com duas colunas: Descrição e Preço
                table.WidthPercentage = 100; // Define a largura da tabela como 100% do documento

                foreach (var item in fatura.ItensFatura)
                {
                    table.AddCell(item.Descricao);
                    table.AddCell(item.Preco.ToString("C")); // Formata o preço como moeda
                }

                doc.Add(table);

                // Fecha o documento
                doc.Close();

                // Exibe mensagem de sucesso
                MessageBox.Show("Fatura gerada com sucesso! Caminho do arquivo: " + caminhoArquivo, "Fatura Gerada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar a fatura PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha o documento se estiver aberto
                if (doc.IsOpen())
                {
                    doc.Close();
                }
            }
        }

        private void bt_Marcar_Click(object sender, EventArgs e)
        {
            //Vai buscar a reserva selecionada e muda o estado da reserva para marcada
            if (LBox_Reservas.SelectedItem != null)
            {
                ReservaController reservaController = new ReservaController();
                Reserva reserva = (Reserva)LBox_Reservas.SelectedItem;
                //Vai buscar a reserva selecionada por id
                Reserva reservaMarcada = reservaController.BuscarReservaPorId(reserva.id);
                reservaMarcada.usada = true;
                reservaController.AtualizarReserva(reservaMarcada);
                //Adiciona a reserva marcada à listbox de reservas marcadas
                LBox_ReservasUsadas.Items.Add(reservaMarcada);
                //Remove a reserva da listbox de reservas
                LBox_Reservas.Items.Remove(reserva);
                MessageBox.Show("Reserva marcada com sucesso!", "Reserva Marcada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarListBoxReservas();
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para marcar.", "Reserva não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalForm principal = new PrincipalForm();
            principal.ShowDialog();
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
