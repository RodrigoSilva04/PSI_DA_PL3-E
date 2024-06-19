namespace Cantina
{
    partial class PratosForm
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

        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBox_Pratos = new System.Windows.Forms.ListBox();
            this.BT_AdicionarPratos = new System.Windows.Forms.Button();
            this.BT_EditarPratos = new System.Windows.Forms.Button();
            this.BT_RemoverPratos = new System.Windows.Forms.Button();
            this.GB_Pratos = new System.Windows.Forms.GroupBox();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.tb_Quantidade = new System.Windows.Forms.TextBox();
            this.ck_Ativo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.lb_teste = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.GB_Pratos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox_Pratos
            // 
            this.LBox_Pratos.FormattingEnabled = true;
            this.LBox_Pratos.Location = new System.Drawing.Point(137, 197);
            this.LBox_Pratos.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Pratos.Name = "LBox_Pratos";
            this.LBox_Pratos.Size = new System.Drawing.Size(278, 277);
            this.LBox_Pratos.TabIndex = 1;
            this.LBox_Pratos.SelectedIndexChanged += new System.EventHandler(this.LBox_Pratos_SelectedIndexChanged_1);
            // 
            // BT_AdicionarPratos
            // 
            this.BT_AdicionarPratos.Location = new System.Drawing.Point(759, 197);
            this.BT_AdicionarPratos.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarPratos.Name = "BT_AdicionarPratos";
            this.BT_AdicionarPratos.Size = new System.Drawing.Size(99, 64);
            this.BT_AdicionarPratos.TabIndex = 3;
            this.BT_AdicionarPratos.Text = "Adicionar";
            this.BT_AdicionarPratos.UseVisualStyleBackColor = true;
            this.BT_AdicionarPratos.Click += new System.EventHandler(this.BT_AdicionarPratos_Click);
            // 
            // BT_EditarPratos
            // 
            this.BT_EditarPratos.Location = new System.Drawing.Point(759, 304);
            this.BT_EditarPratos.Margin = new System.Windows.Forms.Padding(2);
            this.BT_EditarPratos.Name = "BT_EditarPratos";
            this.BT_EditarPratos.Size = new System.Drawing.Size(99, 64);
            this.BT_EditarPratos.TabIndex = 4;
            this.BT_EditarPratos.Text = "Editar";
            this.BT_EditarPratos.UseVisualStyleBackColor = true;
            this.BT_EditarPratos.Click += new System.EventHandler(this.BT_EditarPratos_Click);
            // 
            // BT_RemoverPratos
            // 
            this.BT_RemoverPratos.Location = new System.Drawing.Point(759, 409);
            this.BT_RemoverPratos.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverPratos.Name = "BT_RemoverPratos";
            this.BT_RemoverPratos.Size = new System.Drawing.Size(99, 64);
            this.BT_RemoverPratos.TabIndex = 5;
            this.BT_RemoverPratos.Text = "Remover";
            this.BT_RemoverPratos.UseVisualStyleBackColor = true;
            this.BT_RemoverPratos.Click += new System.EventHandler(this.BT_RemoverPratos_Click);
            // 
            // GB_Pratos
            // 
            this.GB_Pratos.Controls.Add(this.lb_quantidade);
            this.GB_Pratos.Controls.Add(this.tb_Quantidade);
            this.GB_Pratos.Controls.Add(this.ck_Ativo);
            this.GB_Pratos.Controls.Add(this.label6);
            this.GB_Pratos.Controls.Add(this.TB_Descricao);
            this.GB_Pratos.Controls.Add(this.label4);
            this.GB_Pratos.Controls.Add(this.label3);
            this.GB_Pratos.Controls.Add(this.label2);
            this.GB_Pratos.Controls.Add(this.CB_Tipo);
            this.GB_Pratos.Location = new System.Drawing.Point(461, 197);
            this.GB_Pratos.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Pratos.Name = "GB_Pratos";
            this.GB_Pratos.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Pratos.Size = new System.Drawing.Size(265, 276);
            this.GB_Pratos.TabIndex = 6;
            this.GB_Pratos.TabStop = false;
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantidade.Location = new System.Drawing.Point(95, 218);
            this.lb_quantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(83, 18);
            this.lb_quantidade.TabIndex = 35;
            this.lb_quantidade.Text = "Quantidade";
            // 
            // tb_Quantidade
            // 
            this.tb_Quantidade.Location = new System.Drawing.Point(88, 239);
            this.tb_Quantidade.Name = "tb_Quantidade";
            this.tb_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantidade.TabIndex = 34;
            // 
            // ck_Ativo
            // 
            this.ck_Ativo.AutoSize = true;
            this.ck_Ativo.Location = new System.Drawing.Point(103, 186);
            this.ck_Ativo.Name = "ck_Ativo";
            this.ck_Ativo.Size = new System.Drawing.Size(75, 17);
            this.ck_Ativo.TabIndex = 9;
            this.ck_Ativo.Text = "Disponivel";
            this.ck_Ativo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(100, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição";
            // 
            // TB_Descricao
            // 
            this.TB_Descricao.Location = new System.Drawing.Point(55, 98);
            this.TB_Descricao.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Descricao.Multiline = true;
            this.TB_Descricao.Name = "TB_Descricao";
            this.TB_Descricao.Size = new System.Drawing.Size(150, 54);
            this.TB_Descricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(112, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ativo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(100, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo Prato";
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Location = new System.Drawing.Point(88, 33);
            this.CB_Tipo.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(92, 21);
            this.CB_Tipo.TabIndex = 1;
            this.CB_Tipo.SelectedIndexChanged += new System.EventHandler(this.CB_Tipo_SelectedIndexChanged);
            // 
            // lb_teste
            // 
            this.lb_teste.AutoSize = true;
            this.lb_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_teste.Location = new System.Drawing.Point(511, 100);
            this.lb_teste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_teste.Name = "lb_teste";
            this.lb_teste.Size = new System.Drawing.Size(173, 25);
            this.lb_teste.TabIndex = 13;
            this.lb_teste.Text = "Pratos Disponivéis";
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(34, 566);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(131, 61);
            this.bt_voltar.TabIndex = 24;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // PratosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 664);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.lb_teste);
            this.Controls.Add(this.GB_Pratos);
            this.Controls.Add(this.BT_RemoverPratos);
            this.Controls.Add(this.BT_EditarPratos);
            this.Controls.Add(this.BT_AdicionarPratos);
            this.Controls.Add(this.LBox_Pratos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PratosForm";
            this.Text = "Pratos";
            this.GB_Pratos.ResumeLayout(false);
            this.GB_Pratos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBox_Pratos;
        private System.Windows.Forms.Button BT_AdicionarPratos;
        private System.Windows.Forms.Button BT_EditarPratos;
        private System.Windows.Forms.Button BT_RemoverPratos;
        private System.Windows.Forms.GroupBox GB_Pratos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Descricao;
        private System.Windows.Forms.CheckBox ck_Ativo;
        private System.Windows.Forms.Label lb_teste;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.TextBox tb_Quantidade;
        private System.Windows.Forms.Button bt_voltar;
    }
}