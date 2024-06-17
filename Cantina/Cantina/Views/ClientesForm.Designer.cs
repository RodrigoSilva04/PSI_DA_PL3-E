using System;

namespace Cantina
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBox_Clientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_AdicionarClientes = new System.Windows.Forms.Button();
            this.BT_EditarClientes = new System.Windows.Forms.Button();
            this.BT_RemoverClientes = new System.Windows.Forms.Button();
            this.GB_Clientes = new System.Windows.Forms.GroupBox();
            this.TB_EmailCliente = new System.Windows.Forms.TextBox();
            this.TB_NumEstudanteCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NifCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NomeCliente = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Funcionários = new System.Windows.Forms.Button();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.bt_Pratos = new System.Windows.Forms.Button();
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.bt_Extras = new System.Windows.Forms.Button();
            this.bt_reservas = new System.Windows.Forms.Button();
            this.bt_Multas = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GB_Clientes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox_Clientes
            // 
            this.LBox_Clientes.FormattingEnabled = true;
            this.LBox_Clientes.ItemHeight = 16;
            this.LBox_Clientes.Location = new System.Drawing.Point(247, 231);
            this.LBox_Clientes.Name = "LBox_Clientes";
            this.LBox_Clientes.ScrollAlwaysVisible = true;
            this.LBox_Clientes.Size = new System.Drawing.Size(417, 356);
            this.LBox_Clientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(677, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // BT_AdicionarClientes
            // 
            this.BT_AdicionarClientes.Location = new System.Drawing.Point(24, 264);
            this.BT_AdicionarClientes.Name = "BT_AdicionarClientes";
            this.BT_AdicionarClientes.Size = new System.Drawing.Size(125, 67);
            this.BT_AdicionarClientes.TabIndex = 2;
            this.BT_AdicionarClientes.Text = "Adicionar";
            this.BT_AdicionarClientes.UseVisualStyleBackColor = true;
            // 
            // BT_EditarClientes
            // 
            this.BT_EditarClientes.Location = new System.Drawing.Point(230, 264);
            this.BT_EditarClientes.Name = "BT_EditarClientes";
            this.BT_EditarClientes.Size = new System.Drawing.Size(125, 67);
            this.BT_EditarClientes.TabIndex = 3;
            this.BT_EditarClientes.Text = "Editar";
            this.BT_EditarClientes.UseVisualStyleBackColor = true;
            // 
            // BT_RemoverClientes
            // 
            this.BT_RemoverClientes.Location = new System.Drawing.Point(428, 264);
            this.BT_RemoverClientes.Name = "BT_RemoverClientes";
            this.BT_RemoverClientes.Size = new System.Drawing.Size(125, 67);
            this.BT_RemoverClientes.TabIndex = 4;
            this.BT_RemoverClientes.Text = "Remover";
            this.BT_RemoverClientes.UseVisualStyleBackColor = true;
            // 
            // GB_Clientes
            // 
            this.GB_Clientes.Controls.Add(this.TB_EmailCliente);
            this.GB_Clientes.Controls.Add(this.TB_NumEstudanteCliente);
            this.GB_Clientes.Controls.Add(this.label7);
            this.GB_Clientes.Controls.Add(this.label6);
            this.GB_Clientes.Controls.Add(this.CB_Categoria);
            this.GB_Clientes.Controls.Add(this.BT_RemoverClientes);
            this.GB_Clientes.Controls.Add(this.BT_EditarClientes);
            this.GB_Clientes.Controls.Add(this.label5);
            this.GB_Clientes.Controls.Add(this.BT_AdicionarClientes);
            this.GB_Clientes.Controls.Add(this.TB_NifCliente);
            this.GB_Clientes.Controls.Add(this.label4);
            this.GB_Clientes.Controls.Add(this.label3);
            this.GB_Clientes.Controls.Add(this.label2);
            this.GB_Clientes.Controls.Add(this.TB_NomeCliente);
            this.GB_Clientes.Location = new System.Drawing.Point(698, 231);
            this.GB_Clientes.Name = "GB_Clientes";
            this.GB_Clientes.Size = new System.Drawing.Size(575, 358);
            this.GB_Clientes.TabIndex = 5;
            this.GB_Clientes.TabStop = false;
            // 
            // TB_EmailCliente
            // 
            this.TB_EmailCliente.Location = new System.Drawing.Point(126, 203);
            this.TB_EmailCliente.Name = "TB_EmailCliente";
            this.TB_EmailCliente.Size = new System.Drawing.Size(416, 22);
            this.TB_EmailCliente.TabIndex = 10;
            this.TB_EmailCliente.Visible = false;
            // 
            // TB_NumEstudanteCliente
            // 
            this.TB_NumEstudanteCliente.Location = new System.Drawing.Point(126, 171);
            this.TB_NumEstudanteCliente.MaxLength = 10;
            this.TB_NumEstudanteCliente.Name = "TB_NumEstudanteCliente";
            this.TB_NumEstudanteCliente.Size = new System.Drawing.Size(145, 22);
            this.TB_NumEstudanteCliente.TabIndex = 9;
            this.TB_NumEstudanteCliente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(2, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Num. Estudante:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(71, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            this.label6.Visible = false;
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Location = new System.Drawing.Point(432, 29);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(121, 24);
            this.CB_Categoria.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(350, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria:";
            // 
            // TB_NifCliente
            // 
            this.TB_NifCliente.Location = new System.Drawing.Point(126, 138);
            this.TB_NifCliente.MaxLength = 9;
            this.TB_NifCliente.Name = "TB_NifCliente";
            this.TB_NifCliente.Size = new System.Drawing.Size(145, 22);
            this.TB_NifCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(85, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adicionar Clientes";
            // 
            // TB_NomeCliente
            // 
            this.TB_NomeCliente.Location = new System.Drawing.Point(126, 106);
            this.TB_NomeCliente.Name = "TB_NomeCliente";
            this.TB_NomeCliente.Size = new System.Drawing.Size(416, 22);
            this.TB_NomeCliente.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Funcionários, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bt_Menu, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bt_Pratos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_Clientes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bt_Extras, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_reservas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_Multas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bt_sair, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.01117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.98883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 795);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 105);
            this.button1.TabIndex = 12;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_Funcionários
            // 
            this.bt_Funcionários.Location = new System.Drawing.Point(3, 542);
            this.bt_Funcionários.Name = "bt_Funcionários";
            this.bt_Funcionários.Size = new System.Drawing.Size(194, 65);
            this.bt_Funcionários.TabIndex = 7;
            this.bt_Funcionários.Text = "Funcionários";
            this.bt_Funcionários.UseVisualStyleBackColor = true;
            // 
            // bt_Menu
            // 
            this.bt_Menu.Location = new System.Drawing.Point(3, 466);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(194, 70);
            this.bt_Menu.TabIndex = 6;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            // 
            // bt_Pratos
            // 
            this.bt_Pratos.Location = new System.Drawing.Point(3, 114);
            this.bt_Pratos.Name = "bt_Pratos";
            this.bt_Pratos.Size = new System.Drawing.Size(194, 61);
            this.bt_Pratos.TabIndex = 2;
            this.bt_Pratos.Text = "Pratos";
            this.bt_Pratos.UseVisualStyleBackColor = true;
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(3, 391);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(194, 68);
            this.bt_Clientes.TabIndex = 5;
            this.bt_Clientes.Text = "Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            // 
            // bt_Extras
            // 
            this.bt_Extras.Location = new System.Drawing.Point(3, 249);
            this.bt_Extras.Name = "bt_Extras";
            this.bt_Extras.Size = new System.Drawing.Size(194, 62);
            this.bt_Extras.TabIndex = 3;
            this.bt_Extras.Text = "Extras";
            this.bt_Extras.UseVisualStyleBackColor = true;
            // 
            // bt_reservas
            // 
            this.bt_reservas.Location = new System.Drawing.Point(3, 182);
            this.bt_reservas.Name = "bt_reservas";
            this.bt_reservas.Size = new System.Drawing.Size(194, 61);
            this.bt_reservas.TabIndex = 1;
            this.bt_reservas.Text = "Reservas";
            this.bt_reservas.UseVisualStyleBackColor = true;
            // 
            // bt_Multas
            // 
            this.bt_Multas.Location = new System.Drawing.Point(3, 318);
            this.bt_Multas.Name = "bt_Multas";
            this.bt_Multas.Size = new System.Drawing.Size(194, 66);
            this.bt_Multas.TabIndex = 4;
            this.bt_Multas.Text = "Multas";
            this.bt_Multas.UseVisualStyleBackColor = true;
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(3, 689);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(194, 103);
            this.bt_sair.TabIndex = 8;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 70);
            this.button2.TabIndex = 13;
            this.button2.Text = "Saldo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1285, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GB_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBox_Clientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.GB_Clientes.ResumeLayout(false);
            this.GB_Clientes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ListBox LBox_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_AdicionarClientes;
        private System.Windows.Forms.Button BT_EditarClientes;
        private System.Windows.Forms.Button BT_RemoverClientes;
        private System.Windows.Forms.GroupBox GB_Clientes;
        private System.Windows.Forms.TextBox TB_NifCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NomeCliente;
        private System.Windows.Forms.ComboBox CB_Categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_EmailCliente;
        private System.Windows.Forms.TextBox TB_NumEstudanteCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Funcionários;
        private System.Windows.Forms.Button bt_Menu;
        private System.Windows.Forms.Button bt_Pratos;
        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.Button bt_Extras;
        private System.Windows.Forms.Button bt_reservas;
        private System.Windows.Forms.Button bt_Multas;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button button2;
    }
}