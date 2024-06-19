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
            this.L_NumEstudante = new System.Windows.Forms.Label();
            this.L_EmailCliente = new System.Windows.Forms.Label();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NifCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NomeCliente = new System.Windows.Forms.TextBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.GB_Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox_Clientes
            // 
            this.LBox_Clientes.FormattingEnabled = true;
            this.LBox_Clientes.Location = new System.Drawing.Point(108, 189);
            this.LBox_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Clientes.Name = "LBox_Clientes";
            this.LBox_Clientes.ScrollAlwaysVisible = true;
            this.LBox_Clientes.Size = new System.Drawing.Size(314, 290);
            this.LBox_Clientes.TabIndex = 0;
            this.LBox_Clientes.SelectedIndexChanged += new System.EventHandler(this.LBox_Clientes_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(431, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // BT_AdicionarClientes
            // 
            this.BT_AdicionarClientes.Location = new System.Drawing.Point(18, 214);
            this.BT_AdicionarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarClientes.Name = "BT_AdicionarClientes";
            this.BT_AdicionarClientes.Size = new System.Drawing.Size(94, 54);
            this.BT_AdicionarClientes.TabIndex = 2;
            this.BT_AdicionarClientes.Text = "Adicionar";
            this.BT_AdicionarClientes.UseVisualStyleBackColor = true;
            this.BT_AdicionarClientes.Click += new System.EventHandler(this.BT_AdicionarClientes_Click_1);
            // 
            // BT_EditarClientes
            // 
            this.BT_EditarClientes.Location = new System.Drawing.Point(172, 214);
            this.BT_EditarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BT_EditarClientes.Name = "BT_EditarClientes";
            this.BT_EditarClientes.Size = new System.Drawing.Size(94, 54);
            this.BT_EditarClientes.TabIndex = 3;
            this.BT_EditarClientes.Text = "Editar";
            this.BT_EditarClientes.UseVisualStyleBackColor = true;
            this.BT_EditarClientes.Click += new System.EventHandler(this.BT_EditarClientes_Click);
            // 
            // BT_RemoverClientes
            // 
            this.BT_RemoverClientes.Location = new System.Drawing.Point(321, 214);
            this.BT_RemoverClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverClientes.Name = "BT_RemoverClientes";
            this.BT_RemoverClientes.Size = new System.Drawing.Size(94, 54);
            this.BT_RemoverClientes.TabIndex = 4;
            this.BT_RemoverClientes.Text = "Remover";
            this.BT_RemoverClientes.UseVisualStyleBackColor = true;
            this.BT_RemoverClientes.Click += new System.EventHandler(this.BT_RemoverClientes_Click);
            // 
            // GB_Clientes
            // 
            this.GB_Clientes.Controls.Add(this.TB_EmailCliente);
            this.GB_Clientes.Controls.Add(this.TB_NumEstudanteCliente);
            this.GB_Clientes.Controls.Add(this.L_NumEstudante);
            this.GB_Clientes.Controls.Add(this.L_EmailCliente);
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
            this.GB_Clientes.Location = new System.Drawing.Point(447, 189);
            this.GB_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Clientes.Name = "GB_Clientes";
            this.GB_Clientes.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Clientes.Size = new System.Drawing.Size(431, 291);
            this.GB_Clientes.TabIndex = 5;
            this.GB_Clientes.TabStop = false;
            // 
            // TB_EmailCliente
            // 
            this.TB_EmailCliente.Location = new System.Drawing.Point(94, 165);
            this.TB_EmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TB_EmailCliente.Name = "TB_EmailCliente";
            this.TB_EmailCliente.Size = new System.Drawing.Size(313, 20);
            this.TB_EmailCliente.TabIndex = 10;
            this.TB_EmailCliente.Visible = false;
            // 
            // TB_NumEstudanteCliente
            // 
            this.TB_NumEstudanteCliente.Location = new System.Drawing.Point(94, 139);
            this.TB_NumEstudanteCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NumEstudanteCliente.MaxLength = 10;
            this.TB_NumEstudanteCliente.Name = "TB_NumEstudanteCliente";
            this.TB_NumEstudanteCliente.Size = new System.Drawing.Size(110, 20);
            this.TB_NumEstudanteCliente.TabIndex = 9;
            this.TB_NumEstudanteCliente.Visible = false;
            // 
            // L_NumEstudante
            // 
            this.L_NumEstudante.AutoSize = true;
            this.L_NumEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.L_NumEstudante.Location = new System.Drawing.Point(2, 142);
            this.L_NumEstudante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_NumEstudante.Name = "L_NumEstudante";
            this.L_NumEstudante.Size = new System.Drawing.Size(98, 15);
            this.L_NumEstudante.TabIndex = 8;
            this.L_NumEstudante.Text = "Num. Estudante:";
            this.L_NumEstudante.Visible = false;
            // 
            // L_EmailCliente
            // 
            this.L_EmailCliente.AutoSize = true;
            this.L_EmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.L_EmailCliente.Location = new System.Drawing.Point(53, 166);
            this.L_EmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_EmailCliente.Name = "L_EmailCliente";
            this.L_EmailCliente.Size = new System.Drawing.Size(42, 15);
            this.L_EmailCliente.TabIndex = 7;
            this.L_EmailCliente.Text = "Email:";
            this.L_EmailCliente.Visible = false;
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Location = new System.Drawing.Point(324, 24);
            this.CB_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(92, 21);
            this.CB_Categoria.TabIndex = 6;
            this.CB_Categoria.SelectedIndexChanged += new System.EventHandler(this.CB_Categoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(262, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria:";
            // 
            // TB_NifCliente
            // 
            this.TB_NifCliente.Location = new System.Drawing.Point(94, 112);
            this.TB_NifCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NifCliente.MaxLength = 9;
            this.TB_NifCliente.Name = "TB_NifCliente";
            this.TB_NifCliente.Size = new System.Drawing.Size(110, 20);
            this.TB_NifCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(64, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adicionar Clientes";
            // 
            // TB_NomeCliente
            // 
            this.TB_NomeCliente.Location = new System.Drawing.Point(94, 86);
            this.TB_NomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NomeCliente.Name = "TB_NomeCliente";
            this.TB_NomeCliente.Size = new System.Drawing.Size(313, 20);
            this.TB_NomeCliente.TabIndex = 0;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(37, 567);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(131, 61);
            this.bt_voltar.TabIndex = 6;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 662);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.GB_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBox_Clientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.GB_Clientes.ResumeLayout(false);
            this.GB_Clientes.PerformLayout();
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
        private System.Windows.Forms.Label L_NumEstudante;
        private System.Windows.Forms.Label L_EmailCliente;
        private System.Windows.Forms.Button bt_voltar;
    }
}