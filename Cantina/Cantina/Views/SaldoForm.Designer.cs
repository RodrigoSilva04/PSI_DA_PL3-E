namespace Cantina.Views
{
    partial class SaldoForm
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
            this.GB_Clientes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_saldoDisponivel = new System.Windows.Forms.TextBox();
            this.BT_RemoverClientes = new System.Windows.Forms.Button();
            this.BT_AdicionarClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_saldoAdicionar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBox_Clientes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Clientes
            // 
            this.GB_Clientes.Controls.Add(this.label4);
            this.GB_Clientes.Controls.Add(this.tb_saldoDisponivel);
            this.GB_Clientes.Controls.Add(this.BT_RemoverClientes);
            this.GB_Clientes.Controls.Add(this.BT_AdicionarClientes);
            this.GB_Clientes.Controls.Add(this.label3);
            this.GB_Clientes.Controls.Add(this.label2);
            this.GB_Clientes.Controls.Add(this.tb_saldoAdicionar);
            this.GB_Clientes.Location = new System.Drawing.Point(404, 157);
            this.GB_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Clientes.Name = "GB_Clientes";
            this.GB_Clientes.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Clientes.Size = new System.Drawing.Size(431, 291);
            this.GB_Clientes.TabIndex = 8;
            this.GB_Clientes.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo Disponivel:";
            // 
            // tb_saldoDisponivel
            // 
            this.tb_saldoDisponivel.Location = new System.Drawing.Point(131, 131);
            this.tb_saldoDisponivel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_saldoDisponivel.Name = "tb_saldoDisponivel";
            this.tb_saldoDisponivel.ReadOnly = true;
            this.tb_saldoDisponivel.Size = new System.Drawing.Size(59, 20);
            this.tb_saldoDisponivel.TabIndex = 5;
            // 
            // BT_RemoverClientes
            // 
            this.BT_RemoverClientes.Location = new System.Drawing.Point(277, 214);
            this.BT_RemoverClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverClientes.Name = "BT_RemoverClientes";
            this.BT_RemoverClientes.Size = new System.Drawing.Size(94, 54);
            this.BT_RemoverClientes.TabIndex = 4;
            this.BT_RemoverClientes.Text = "Remover Saldo";
            this.BT_RemoverClientes.UseVisualStyleBackColor = true;
            this.BT_RemoverClientes.Click += new System.EventHandler(this.BT_RemoverClientes_Click);
            // 
            // BT_AdicionarClientes
            // 
            this.BT_AdicionarClientes.Location = new System.Drawing.Point(83, 214);
            this.BT_AdicionarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarClientes.Name = "BT_AdicionarClientes";
            this.BT_AdicionarClientes.Size = new System.Drawing.Size(94, 54);
            this.BT_AdicionarClientes.TabIndex = 2;
            this.BT_AdicionarClientes.Text = "Adicionar Saldo";
            this.BT_AdicionarClientes.UseVisualStyleBackColor = true;
            this.BT_AdicionarClientes.Click += new System.EventHandler(this.BT_AdicionarClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(169, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo Cliente";
            // 
            // tb_saldoAdicionar
            // 
            this.tb_saldoAdicionar.Location = new System.Drawing.Point(131, 87);
            this.tb_saldoAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.tb_saldoAdicionar.Name = "tb_saldoAdicionar";
            this.tb_saldoAdicionar.Size = new System.Drawing.Size(59, 20);
            this.tb_saldoAdicionar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(388, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saldo";
            // 
            // LBox_Clientes
            // 
            this.LBox_Clientes.FormattingEnabled = true;
            this.LBox_Clientes.Location = new System.Drawing.Point(65, 157);
            this.LBox_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Clientes.Name = "LBox_Clientes";
            this.LBox_Clientes.ScrollAlwaysVisible = true;
            this.LBox_Clientes.Size = new System.Drawing.Size(314, 290);
            this.LBox_Clientes.TabIndex = 6;
            this.LBox_Clientes.SelectedIndexChanged += new System.EventHandler(this.LBox_Clientes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 61);
            this.button1.TabIndex = 25;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaldoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GB_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBox_Clientes);
            this.Name = "SaldoForm";
            this.Text = "SaldoForm";
            this.GB_Clientes.ResumeLayout(false);
            this.GB_Clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_saldoDisponivel;
        private System.Windows.Forms.Button BT_RemoverClientes;
        private System.Windows.Forms.Button BT_AdicionarClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_saldoAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBox_Clientes;
        private System.Windows.Forms.Button button1;
    }
}