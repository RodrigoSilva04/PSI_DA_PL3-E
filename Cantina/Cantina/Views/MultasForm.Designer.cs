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
            this.LBox_Multas = new System.Windows.Forms.ListBox();
            this.GB_Multas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBox_TotalMultas = new System.Windows.Forms.ListBox();
            this.LBox_SaldoMultas = new System.Windows.Forms.ListBox();
            this.BT_PagarMultas = new System.Windows.Forms.Button();
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
            this.GB_Multas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox_Multas
            // 
            this.LBox_Multas.FormattingEnabled = true;
            this.LBox_Multas.ItemHeight = 16;
            this.LBox_Multas.Location = new System.Drawing.Point(280, 288);
            this.LBox_Multas.Name = "LBox_Multas";
            this.LBox_Multas.Size = new System.Drawing.Size(316, 260);
            this.LBox_Multas.TabIndex = 0;
            // 
            // GB_Multas
            // 
            this.GB_Multas.Controls.Add(this.label1);
            this.GB_Multas.Controls.Add(this.label2);
            this.GB_Multas.Controls.Add(this.LBox_TotalMultas);
            this.GB_Multas.Controls.Add(this.LBox_SaldoMultas);
            this.GB_Multas.Controls.Add(this.BT_PagarMultas);
            this.GB_Multas.Location = new System.Drawing.Point(684, 288);
            this.GB_Multas.Name = "GB_Multas";
            this.GB_Multas.Size = new System.Drawing.Size(246, 260);
            this.GB_Multas.TabIndex = 1;
            this.GB_Multas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo:";
            // 
            // LBox_TotalMultas
            // 
            this.LBox_TotalMultas.FormattingEnabled = true;
            this.LBox_TotalMultas.ItemHeight = 16;
            this.LBox_TotalMultas.Location = new System.Drawing.Point(74, 123);
            this.LBox_TotalMultas.Name = "LBox_TotalMultas";
            this.LBox_TotalMultas.Size = new System.Drawing.Size(132, 36);
            this.LBox_TotalMultas.TabIndex = 0;
            // 
            // LBox_SaldoMultas
            // 
            this.LBox_SaldoMultas.FormattingEnabled = true;
            this.LBox_SaldoMultas.ItemHeight = 16;
            this.LBox_SaldoMultas.Location = new System.Drawing.Point(74, 39);
            this.LBox_SaldoMultas.Name = "LBox_SaldoMultas";
            this.LBox_SaldoMultas.Size = new System.Drawing.Size(132, 36);
            this.LBox_SaldoMultas.TabIndex = 1;
            // 
            // BT_PagarMultas
            // 
            this.BT_PagarMultas.Location = new System.Drawing.Point(76, 189);
            this.BT_PagarMultas.Name = "BT_PagarMultas";
            this.BT_PagarMultas.Size = new System.Drawing.Size(96, 48);
            this.BT_PagarMultas.TabIndex = 0;
            this.BT_PagarMultas.Text = "Pagar";
            this.BT_PagarMultas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(580, 205);
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
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_Multas);
            this.Controls.Add(this.LBox_Multas);
            this.Name = "Multas";
            this.Text = "Multas";
            this.GB_Multas.ResumeLayout(false);
            this.GB_Multas.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBox_Multas;
        private System.Windows.Forms.GroupBox GB_Multas;
        private System.Windows.Forms.ListBox LBox_SaldoMultas;
        private System.Windows.Forms.Button BT_PagarMultas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBox_TotalMultas;
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
    }
}