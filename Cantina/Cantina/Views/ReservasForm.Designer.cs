namespace Cantina
{
    partial class ReservasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_AdicionarExtraReserva = new System.Windows.Forms.Button();
            this.LBox_ExtrasReserva = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PrecoMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_qntPrato = new System.Windows.Forms.TextBox();
            this.bt_adicionarPratoReserva = new System.Windows.Forms.Button();
            this.bt_ConfirmarReserva = new System.Windows.Forms.Button();
            this.LBox_Clientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_qntExtra = new System.Windows.Forms.TextBox();
            this.LBox_Menus = new System.Windows.Forms.ListBox();
            this.DTHora_Menu = new System.Windows.Forms.DateTimePicker();
            this.LBox_Reserva = new System.Windows.Forms.ListBox();
            this.LBox_PratosReserva = new System.Windows.Forms.ListBox();
            this.DTData_Menu = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(286, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reservas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 662);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_Total);
            this.tabPage1.Controls.Add(this.bt_AdicionarExtraReserva);
            this.tabPage1.Controls.Add(this.LBox_ExtrasReserva);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_PrecoMenu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TB_qntPrato);
            this.tabPage1.Controls.Add(this.bt_adicionarPratoReserva);
            this.tabPage1.Controls.Add(this.bt_ConfirmarReserva);
            this.tabPage1.Controls.Add(this.LBox_Clientes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TB_qntExtra);
            this.tabPage1.Controls.Add(this.LBox_Menus);
            this.tabPage1.Controls.Add(this.DTHora_Menu);
            this.tabPage1.Controls.Add(this.LBox_Reserva);
            this.tabPage1.Controls.Add(this.LBox_PratosReserva);
            this.tabPage1.Controls.Add(this.DTData_Menu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Efetuar Reserva";
            // 
            // bt_AdicionarExtraReserva
            // 
            this.bt_AdicionarExtraReserva.Location = new System.Drawing.Point(582, 204);
            this.bt_AdicionarExtraReserva.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AdicionarExtraReserva.Name = "bt_AdicionarExtraReserva";
            this.bt_AdicionarExtraReserva.Size = new System.Drawing.Size(101, 34);
            this.bt_AdicionarExtraReserva.TabIndex = 63;
            this.bt_AdicionarExtraReserva.Text = "Adicionar á Reserva";
            this.bt_AdicionarExtraReserva.UseVisualStyleBackColor = true;
            this.bt_AdicionarExtraReserva.Click += new System.EventHandler(this.bt_AdicionarExtraReserva_Click);
            // 
            // LBox_ExtrasReserva
            // 
            this.LBox_ExtrasReserva.FormattingEnabled = true;
            this.LBox_ExtrasReserva.Location = new System.Drawing.Point(582, 66);
            this.LBox_ExtrasReserva.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_ExtrasReserva.Name = "LBox_ExtrasReserva";
            this.LBox_ExtrasReserva.Size = new System.Drawing.Size(101, 134);
            this.LBox_ExtrasReserva.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Preço:";
            // 
            // tb_PrecoMenu
            // 
            this.tb_PrecoMenu.Location = new System.Drawing.Point(306, 325);
            this.tb_PrecoMenu.Name = "tb_PrecoMenu";
            this.tb_PrecoMenu.Size = new System.Drawing.Size(100, 20);
            this.tb_PrecoMenu.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quantidade deste Prato:";
            // 
            // TB_qntPrato
            // 
            this.TB_qntPrato.Location = new System.Drawing.Point(306, 268);
            this.TB_qntPrato.Name = "TB_qntPrato";
            this.TB_qntPrato.Size = new System.Drawing.Size(100, 20);
            this.TB_qntPrato.TabIndex = 58;
            // 
            // bt_adicionarPratoReserva
            // 
            this.bt_adicionarPratoReserva.Location = new System.Drawing.Point(484, 204);
            this.bt_adicionarPratoReserva.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adicionarPratoReserva.Name = "bt_adicionarPratoReserva";
            this.bt_adicionarPratoReserva.Size = new System.Drawing.Size(94, 34);
            this.bt_adicionarPratoReserva.TabIndex = 57;
            this.bt_adicionarPratoReserva.Text = "Adicionar á Reserva";
            this.bt_adicionarPratoReserva.UseVisualStyleBackColor = true;
            this.bt_adicionarPratoReserva.Click += new System.EventHandler(this.bt_adicionarPratoReserva_Click);
            // 
            // bt_ConfirmarReserva
            // 
            this.bt_ConfirmarReserva.Location = new System.Drawing.Point(543, 384);
            this.bt_ConfirmarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ConfirmarReserva.Name = "bt_ConfirmarReserva";
            this.bt_ConfirmarReserva.Size = new System.Drawing.Size(62, 34);
            this.bt_ConfirmarReserva.TabIndex = 55;
            this.bt_ConfirmarReserva.Text = "Reservar";
            this.bt_ConfirmarReserva.UseVisualStyleBackColor = true;
            // 
            // LBox_Clientes
            // 
            this.LBox_Clientes.FormattingEnabled = true;
            this.LBox_Clientes.Location = new System.Drawing.Point(68, 66);
            this.LBox_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Clientes.Name = "LBox_Clientes";
            this.LBox_Clientes.Size = new System.Drawing.Size(186, 108);
            this.LBox_Clientes.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Quantidade deste extra:";
            // 
            // TB_qntExtra
            // 
            this.TB_qntExtra.Location = new System.Drawing.Point(306, 204);
            this.TB_qntExtra.Name = "TB_qntExtra";
            this.TB_qntExtra.Size = new System.Drawing.Size(100, 20);
            this.TB_qntExtra.TabIndex = 48;
            // 
            // LBox_Menus
            // 
            this.LBox_Menus.FormattingEnabled = true;
            this.LBox_Menus.Location = new System.Drawing.Point(68, 204);
            this.LBox_Menus.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Menus.Name = "LBox_Menus";
            this.LBox_Menus.Size = new System.Drawing.Size(186, 134);
            this.LBox_Menus.TabIndex = 44;
            this.LBox_Menus.SelectedIndexChanged += new System.EventHandler(this.LBox_Menus_SelectedIndexChanged);
            // 
            // DTHora_Menu
            // 
            this.DTHora_Menu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHora_Menu.Location = new System.Drawing.Point(280, 129);
            this.DTHora_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.DTHora_Menu.Name = "DTHora_Menu";
            this.DTHora_Menu.Size = new System.Drawing.Size(151, 20);
            this.DTHora_Menu.TabIndex = 43;
            // 
            // LBox_Reserva
            // 
            this.LBox_Reserva.FormattingEnabled = true;
            this.LBox_Reserva.Location = new System.Drawing.Point(484, 246);
            this.LBox_Reserva.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Reserva.Name = "LBox_Reserva";
            this.LBox_Reserva.Size = new System.Drawing.Size(186, 134);
            this.LBox_Reserva.TabIndex = 42;
            // 
            // LBox_PratosReserva
            // 
            this.LBox_PratosReserva.FormattingEnabled = true;
            this.LBox_PratosReserva.Location = new System.Drawing.Point(484, 66);
            this.LBox_PratosReserva.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_PratosReserva.Name = "LBox_PratosReserva";
            this.LBox_PratosReserva.Size = new System.Drawing.Size(94, 134);
            this.LBox_PratosReserva.TabIndex = 41;
            this.LBox_PratosReserva.SelectedIndexChanged += new System.EventHandler(this.LBox_PratosReserva_SelectedIndexChanged);
            // 
            // DTData_Menu
            // 
            this.DTData_Menu.Location = new System.Drawing.Point(280, 106);
            this.DTData_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.DTData_Menu.Name = "DTData_Menu";
            this.DTData_Menu.Size = new System.Drawing.Size(151, 20);
            this.DTData_Menu.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marcar Reserva como Efetuada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Total:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(306, 384);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(100, 20);
            this.tb_Total.TabIndex = 64;
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 662);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservasForm";
            this.Text = "Reservas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_adicionarPratoReserva;
        private System.Windows.Forms.Button bt_ConfirmarReserva;
        private System.Windows.Forms.ListBox LBox_Clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_qntExtra;
        private System.Windows.Forms.ListBox LBox_Menus;
        private System.Windows.Forms.DateTimePicker DTHora_Menu;
        private System.Windows.Forms.ListBox LBox_Reserva;
        private System.Windows.Forms.ListBox LBox_PratosReserva;
        private System.Windows.Forms.DateTimePicker DTData_Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_qntPrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_PrecoMenu;
        private System.Windows.Forms.Button bt_AdicionarExtraReserva;
        private System.Windows.Forms.ListBox LBox_ExtrasReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Total;
    }
}