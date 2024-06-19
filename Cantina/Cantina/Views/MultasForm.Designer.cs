namespace Cantina
{
    partial class MultasForm
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
            this.LB_Multas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_AdicionarMulta = new System.Windows.Forms.Button();
            this.BT_EditarMulta = new System.Windows.Forms.Button();
            this.BT_RemoverMulta = new System.Windows.Forms.Button();
            this.GB_CrudMultas = new System.Windows.Forms.GroupBox();
            this.TB_HorasMulta = new System.Windows.Forms.TextBox();
            this.TB_PrecoMulta = new System.Windows.Forms.TextBox();
            this.L_HorasMulta = new System.Windows.Forms.Label();
            this.L_PrecoMulta = new System.Windows.Forms.Label();
            this.LB_Reservas = new System.Windows.Forms.ListBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.GB_CrudMultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Multas
            // 
            this.LB_Multas.FormattingEnabled = true;
            this.LB_Multas.Location = new System.Drawing.Point(113, 87);
            this.LB_Multas.Margin = new System.Windows.Forms.Padding(2);
            this.LB_Multas.Name = "LB_Multas";
            this.LB_Multas.Size = new System.Drawing.Size(234, 186);
            this.LB_Multas.TabIndex = 0;
            this.LB_Multas.SelectedIndexChanged += new System.EventHandler(this.LBox_Multas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(476, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multas";
            // 
            // BT_AdicionarMulta
            // 
            this.BT_AdicionarMulta.Location = new System.Drawing.Point(459, 398);
            this.BT_AdicionarMulta.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarMulta.Name = "BT_AdicionarMulta";
            this.BT_AdicionarMulta.Size = new System.Drawing.Size(100, 56);
            this.BT_AdicionarMulta.TabIndex = 15;
            this.BT_AdicionarMulta.Text = "Adicionar";
            this.BT_AdicionarMulta.UseVisualStyleBackColor = true;
            this.BT_AdicionarMulta.Click += new System.EventHandler(this.button3_Click);
            // 
            // BT_EditarMulta
            // 
            this.BT_EditarMulta.Location = new System.Drawing.Point(381, 470);
            this.BT_EditarMulta.Margin = new System.Windows.Forms.Padding(2);
            this.BT_EditarMulta.Name = "BT_EditarMulta";
            this.BT_EditarMulta.Size = new System.Drawing.Size(100, 56);
            this.BT_EditarMulta.TabIndex = 16;
            this.BT_EditarMulta.Text = "Editar";
            this.BT_EditarMulta.UseVisualStyleBackColor = true;
            this.BT_EditarMulta.Click += new System.EventHandler(this.BT_EditarMulta_Click);
            // 
            // BT_RemoverMulta
            // 
            this.BT_RemoverMulta.Location = new System.Drawing.Point(538, 470);
            this.BT_RemoverMulta.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverMulta.Name = "BT_RemoverMulta";
            this.BT_RemoverMulta.Size = new System.Drawing.Size(100, 56);
            this.BT_RemoverMulta.TabIndex = 17;
            this.BT_RemoverMulta.Text = "Remover";
            this.BT_RemoverMulta.UseVisualStyleBackColor = true;
            this.BT_RemoverMulta.Click += new System.EventHandler(this.BT_RemoverMulta_Click);
            // 
            // GB_CrudMultas
            // 
            this.GB_CrudMultas.Controls.Add(this.TB_HorasMulta);
            this.GB_CrudMultas.Controls.Add(this.TB_PrecoMulta);
            this.GB_CrudMultas.Controls.Add(this.L_HorasMulta);
            this.GB_CrudMultas.Controls.Add(this.L_PrecoMulta);
            this.GB_CrudMultas.Location = new System.Drawing.Point(412, 195);
            this.GB_CrudMultas.Margin = new System.Windows.Forms.Padding(2);
            this.GB_CrudMultas.Name = "GB_CrudMultas";
            this.GB_CrudMultas.Padding = new System.Windows.Forms.Padding(2);
            this.GB_CrudMultas.Size = new System.Drawing.Size(237, 139);
            this.GB_CrudMultas.TabIndex = 18;
            this.GB_CrudMultas.TabStop = false;
            // 
            // TB_HorasMulta
            // 
            this.TB_HorasMulta.Location = new System.Drawing.Point(82, 84);
            this.TB_HorasMulta.Margin = new System.Windows.Forms.Padding(2);
            this.TB_HorasMulta.Name = "TB_HorasMulta";
            this.TB_HorasMulta.Size = new System.Drawing.Size(76, 20);
            this.TB_HorasMulta.TabIndex = 4;
            // 
            // TB_PrecoMulta
            // 
            this.TB_PrecoMulta.Location = new System.Drawing.Point(82, 31);
            this.TB_PrecoMulta.Margin = new System.Windows.Forms.Padding(2);
            this.TB_PrecoMulta.Name = "TB_PrecoMulta";
            this.TB_PrecoMulta.Size = new System.Drawing.Size(76, 20);
            this.TB_PrecoMulta.TabIndex = 3;
            // 
            // L_HorasMulta
            // 
            this.L_HorasMulta.AutoSize = true;
            this.L_HorasMulta.Location = new System.Drawing.Point(44, 86);
            this.L_HorasMulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_HorasMulta.Name = "L_HorasMulta";
            this.L_HorasMulta.Size = new System.Drawing.Size(38, 13);
            this.L_HorasMulta.TabIndex = 2;
            this.L_HorasMulta.Text = "Horas:";
            // 
            // L_PrecoMulta
            // 
            this.L_PrecoMulta.AutoSize = true;
            this.L_PrecoMulta.Location = new System.Drawing.Point(44, 33);
            this.L_PrecoMulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_PrecoMulta.Name = "L_PrecoMulta";
            this.L_PrecoMulta.Size = new System.Drawing.Size(34, 13);
            this.L_PrecoMulta.TabIndex = 1;
            this.L_PrecoMulta.Text = "Valor:";
            // 
            // LB_Reservas
            // 
            this.LB_Reservas.FormattingEnabled = true;
            this.LB_Reservas.Location = new System.Drawing.Point(113, 334);
            this.LB_Reservas.Margin = new System.Windows.Forms.Padding(2);
            this.LB_Reservas.Name = "LB_Reservas";
            this.LB_Reservas.Size = new System.Drawing.Size(234, 199);
            this.LB_Reservas.TabIndex = 19;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(30, 577);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(131, 61);
            this.bt_voltar.TabIndex = 24;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // MultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 662);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.LB_Reservas);
            this.Controls.Add(this.GB_CrudMultas);
            this.Controls.Add(this.BT_RemoverMulta);
            this.Controls.Add(this.BT_EditarMulta);
            this.Controls.Add(this.BT_AdicionarMulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Multas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MultasForm";
            this.Text = "Multas";
            this.GB_CrudMultas.ResumeLayout(false);
            this.GB_CrudMultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Multas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_AdicionarMulta;
        private System.Windows.Forms.Button BT_EditarMulta;
        private System.Windows.Forms.Button BT_RemoverMulta;
        private System.Windows.Forms.GroupBox GB_CrudMultas;
        private System.Windows.Forms.Label L_PrecoMulta;
        private System.Windows.Forms.Label L_HorasMulta;
        private System.Windows.Forms.TextBox TB_HorasMulta;
        private System.Windows.Forms.TextBox TB_PrecoMulta;
        private System.Windows.Forms.ListBox LB_Reservas;
        private System.Windows.Forms.Button bt_voltar;
    }
}