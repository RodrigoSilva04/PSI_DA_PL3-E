namespace Cantina
{
    partial class MenuForm
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
            this.DTData_Menu = new System.Windows.Forms.DateTimePicker();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBox_PratosMenu = new System.Windows.Forms.ListBox();
            this.LBox_ExtrasMenu = new System.Windows.Forms.ListBox();
            this.DTHora_Menu = new System.Windows.Forms.DateTimePicker();
            this.LBox_MenuAtual = new System.Windows.Forms.ListBox();
            this.BT_AdicionarMenu = new System.Windows.Forms.Button();
            this.BT_EditarMenu = new System.Windows.Forms.Button();
            this.BT_RemoverMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTData_Menu
            // 
            this.DTData_Menu.Location = new System.Drawing.Point(328, 41);
            this.DTData_Menu.Name = "DTData_Menu";
            this.DTData_Menu.Size = new System.Drawing.Size(200, 22);
            this.DTData_Menu.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(670, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_RemoverMenu);
            this.groupBox1.Controls.Add(this.BT_EditarMenu);
            this.groupBox1.Controls.Add(this.BT_AdicionarMenu);
            this.groupBox1.Controls.Add(this.LBox_MenuAtual);
            this.groupBox1.Controls.Add(this.DTHora_Menu);
            this.groupBox1.Controls.Add(this.LBox_ExtrasMenu);
            this.groupBox1.Controls.Add(this.LBox_PratosMenu);
            this.groupBox1.Controls.Add(this.DTData_Menu);
            this.groupBox1.Location = new System.Drawing.Point(275, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 579);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LBox_PratosMenu
            // 
            this.LBox_PratosMenu.FormattingEnabled = true;
            this.LBox_PratosMenu.ItemHeight = 16;
            this.LBox_PratosMenu.Location = new System.Drawing.Point(45, 41);
            this.LBox_PratosMenu.Name = "LBox_PratosMenu";
            this.LBox_PratosMenu.Size = new System.Drawing.Size(247, 212);
            this.LBox_PratosMenu.TabIndex = 21;
            // 
            // LBox_ExtrasMenu
            // 
            this.LBox_ExtrasMenu.FormattingEnabled = true;
            this.LBox_ExtrasMenu.ItemHeight = 16;
            this.LBox_ExtrasMenu.Location = new System.Drawing.Point(45, 307);
            this.LBox_ExtrasMenu.Name = "LBox_ExtrasMenu";
            this.LBox_ExtrasMenu.Size = new System.Drawing.Size(247, 212);
            this.LBox_ExtrasMenu.TabIndex = 22;
            // 
            // DTHora_Menu
            // 
            this.DTHora_Menu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHora_Menu.Location = new System.Drawing.Point(328, 69);
            this.DTHora_Menu.Name = "DTHora_Menu";
            this.DTHora_Menu.Size = new System.Drawing.Size(200, 22);
            this.DTHora_Menu.TabIndex = 23;
            // 
            // LBox_MenuAtual
            // 
            this.LBox_MenuAtual.FormattingEnabled = true;
            this.LBox_MenuAtual.ItemHeight = 16;
            this.LBox_MenuAtual.Location = new System.Drawing.Point(563, 41);
            this.LBox_MenuAtual.Name = "LBox_MenuAtual";
            this.LBox_MenuAtual.Size = new System.Drawing.Size(247, 212);
            this.LBox_MenuAtual.TabIndex = 24;
            // 
            // BT_AdicionarMenu
            // 
            this.BT_AdicionarMenu.Location = new System.Drawing.Point(610, 307);
            this.BT_AdicionarMenu.Name = "BT_AdicionarMenu";
            this.BT_AdicionarMenu.Size = new System.Drawing.Size(150, 59);
            this.BT_AdicionarMenu.TabIndex = 25;
            this.BT_AdicionarMenu.Text = "Adicionar";
            this.BT_AdicionarMenu.UseVisualStyleBackColor = true;
            // 
            // BT_EditarMenu
            // 
            this.BT_EditarMenu.Location = new System.Drawing.Point(610, 379);
            this.BT_EditarMenu.Name = "BT_EditarMenu";
            this.BT_EditarMenu.Size = new System.Drawing.Size(150, 59);
            this.BT_EditarMenu.TabIndex = 26;
            this.BT_EditarMenu.Text = "Editar";
            this.BT_EditarMenu.UseVisualStyleBackColor = true;
            // 
            // BT_RemoverMenu
            // 
            this.BT_RemoverMenu.Location = new System.Drawing.Point(610, 455);
            this.BT_RemoverMenu.Name = "BT_RemoverMenu";
            this.BT_RemoverMenu.Size = new System.Drawing.Size(150, 59);
            this.BT_RemoverMenu.TabIndex = 27;
            this.BT_RemoverMenu.Text = "Remover";
            this.BT_RemoverMenu.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 821);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTData_Menu;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBox_ExtrasMenu;
        private System.Windows.Forms.ListBox LBox_PratosMenu;
        private System.Windows.Forms.DateTimePicker DTHora_Menu;
        private System.Windows.Forms.ListBox LBox_MenuAtual;
        private System.Windows.Forms.Button BT_RemoverMenu;
        private System.Windows.Forms.Button BT_EditarMenu;
        private System.Windows.Forms.Button BT_AdicionarMenu;
    }
}