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
            this.BT_AdicionarMulta = new System.Windows.Forms.Button();
            this.BT_EditarMulta = new System.Windows.Forms.Button();
            this.BT_RemoverMulta = new System.Windows.Forms.Button();
            this.GB_CrudMultas = new System.Windows.Forms.GroupBox();
            this.L_HorasMulta = new System.Windows.Forms.Label();
            this.L_PrecoMulta = new System.Windows.Forms.Label();
            this.TB_PrecoMulta = new System.Windows.Forms.TextBox();
            this.TB_HorasMulta = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_CrudMultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Multas
            // 
            this.LB_Multas.FormattingEnabled = true;
            this.LB_Multas.ItemHeight = 16;
            this.LB_Multas.Location = new System.Drawing.Point(282, 143);
            this.LB_Multas.Name = "LB_Multas";
            this.LB_Multas.Size = new System.Drawing.Size(310, 260);
            this.LB_Multas.TabIndex = 0;
            this.LB_Multas.SelectedIndexChanged += new System.EventHandler(this.LBox_Multas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(576, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multas";
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
            // BT_AdicionarMulta
            // 
            this.BT_AdicionarMulta.Location = new System.Drawing.Point(282, 479);
            this.BT_AdicionarMulta.Name = "BT_AdicionarMulta";
            this.BT_AdicionarMulta.Size = new System.Drawing.Size(134, 69);
            this.BT_AdicionarMulta.TabIndex = 15;
            this.BT_AdicionarMulta.Text = "Adicionar";
            this.BT_AdicionarMulta.UseVisualStyleBackColor = true;
            this.BT_AdicionarMulta.Click += new System.EventHandler(this.button3_Click);
            // 
            // BT_EditarMulta
            // 
            this.BT_EditarMulta.Location = new System.Drawing.Point(543, 479);
            this.BT_EditarMulta.Name = "BT_EditarMulta";
            this.BT_EditarMulta.Size = new System.Drawing.Size(134, 69);
            this.BT_EditarMulta.TabIndex = 16;
            this.BT_EditarMulta.Text = "Editar";
            this.BT_EditarMulta.UseVisualStyleBackColor = true;
            this.BT_EditarMulta.Click += new System.EventHandler(this.BT_EditarMulta_Click);
            // 
            // BT_RemoverMulta
            // 
            this.BT_RemoverMulta.Location = new System.Drawing.Point(798, 479);
            this.BT_RemoverMulta.Name = "BT_RemoverMulta";
            this.BT_RemoverMulta.Size = new System.Drawing.Size(134, 69);
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
            this.GB_CrudMultas.Location = new System.Drawing.Point(657, 194);
            this.GB_CrudMultas.Name = "GB_CrudMultas";
            this.GB_CrudMultas.Size = new System.Drawing.Size(316, 171);
            this.GB_CrudMultas.TabIndex = 18;
            this.GB_CrudMultas.TabStop = false;
            // 
            // L_HorasMulta
            // 
            this.L_HorasMulta.AutoSize = true;
            this.L_HorasMulta.Location = new System.Drawing.Point(58, 106);
            this.L_HorasMulta.Name = "L_HorasMulta";
            this.L_HorasMulta.Size = new System.Drawing.Size(47, 16);
            this.L_HorasMulta.TabIndex = 2;
            this.L_HorasMulta.Text = "Horas:";
            // 
            // L_PrecoMulta
            // 
            this.L_PrecoMulta.AutoSize = true;
            this.L_PrecoMulta.Location = new System.Drawing.Point(58, 41);
            this.L_PrecoMulta.Name = "L_PrecoMulta";
            this.L_PrecoMulta.Size = new System.Drawing.Size(42, 16);
            this.L_PrecoMulta.TabIndex = 1;
            this.L_PrecoMulta.Text = "Valor:";
            this.L_PrecoMulta.Click += new System.EventHandler(this.label5_Click);
            // 
            // TB_PrecoMulta
            // 
            this.TB_PrecoMulta.Location = new System.Drawing.Point(110, 38);
            this.TB_PrecoMulta.Name = "TB_PrecoMulta";
            this.TB_PrecoMulta.Size = new System.Drawing.Size(100, 22);
            this.TB_PrecoMulta.TabIndex = 3;
            this.TB_PrecoMulta.TextChanged += new System.EventHandler(this.TB_PrecoMulta_TextChanged);
            // 
            // TB_HorasMulta
            // 
            this.TB_HorasMulta.Location = new System.Drawing.Point(110, 103);
            this.TB_HorasMulta.Name = "TB_HorasMulta";
            this.TB_HorasMulta.Size = new System.Drawing.Size(100, 22);
            this.TB_HorasMulta.TabIndex = 4;
            // 
            // MultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 815);
            this.Controls.Add(this.GB_CrudMultas);
            this.Controls.Add(this.BT_RemoverMulta);
            this.Controls.Add(this.BT_EditarMulta);
            this.Controls.Add(this.BT_AdicionarMulta);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Multas);
            this.Name = "MultasForm";
            this.Text = "Multas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_CrudMultas.ResumeLayout(false);
            this.GB_CrudMultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Multas;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button BT_AdicionarMulta;
        private System.Windows.Forms.Button BT_EditarMulta;
        private System.Windows.Forms.Button BT_RemoverMulta;
        private System.Windows.Forms.GroupBox GB_CrudMultas;
        private System.Windows.Forms.Label L_PrecoMulta;
        private System.Windows.Forms.Label L_HorasMulta;
        private System.Windows.Forms.TextBox TB_HorasMulta;
        private System.Windows.Forms.TextBox TB_PrecoMulta;
    }
}