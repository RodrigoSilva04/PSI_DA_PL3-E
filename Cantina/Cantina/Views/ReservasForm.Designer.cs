﻿namespace Cantina
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_removerPrato = new System.Windows.Forms.Button();
            this.bt_adicionarPrato = new System.Windows.Forms.Button();
            this.bt_removerExtra = new System.Windows.Forms.Button();
            this.bt_adicionarextra = new System.Windows.Forms.Button();
            this.LBox_Clientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_precoProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_precoEstudante = new System.Windows.Forms.TextBox();
            this.BT_RemoverMenu = new System.Windows.Forms.Button();
            this.BT_EditarMenu = new System.Windows.Forms.Button();
            this.BT_AdicionarMenu = new System.Windows.Forms.Button();
            this.LBox_Menus = new System.Windows.Forms.ListBox();
            this.DTHora_Menu = new System.Windows.Forms.DateTimePicker();
            this.LBox_ExtrasMenu = new System.Windows.Forms.ListBox();
            this.LBox_PratosReserva = new System.Windows.Forms.ListBox();
            this.DTData_Menu = new System.Windows.Forms.DateTimePicker();
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
            this.tabPage1.Controls.Add(this.bt_removerPrato);
            this.tabPage1.Controls.Add(this.bt_adicionarPrato);
            this.tabPage1.Controls.Add(this.bt_removerExtra);
            this.tabPage1.Controls.Add(this.bt_adicionarextra);
            this.tabPage1.Controls.Add(this.LBox_Clientes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_Quantidade);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TB_precoProfessor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TB_precoEstudante);
            this.tabPage1.Controls.Add(this.BT_RemoverMenu);
            this.tabPage1.Controls.Add(this.BT_EditarMenu);
            this.tabPage1.Controls.Add(this.BT_AdicionarMenu);
            this.tabPage1.Controls.Add(this.LBox_Menus);
            this.tabPage1.Controls.Add(this.DTHora_Menu);
            this.tabPage1.Controls.Add(this.LBox_ExtrasMenu);
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
            // bt_removerPrato
            // 
            this.bt_removerPrato.Location = new System.Drawing.Point(186, 371);
            this.bt_removerPrato.Margin = new System.Windows.Forms.Padding(2);
            this.bt_removerPrato.Name = "bt_removerPrato";
            this.bt_removerPrato.Size = new System.Drawing.Size(62, 34);
            this.bt_removerPrato.TabIndex = 58;
            this.bt_removerPrato.Text = "Remover Prato";
            this.bt_removerPrato.UseVisualStyleBackColor = true;
            // 
            // bt_adicionarPrato
            // 
            this.bt_adicionarPrato.Location = new System.Drawing.Point(543, 204);
            this.bt_adicionarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adicionarPrato.Name = "bt_adicionarPrato";
            this.bt_adicionarPrato.Size = new System.Drawing.Size(62, 34);
            this.bt_adicionarPrato.TabIndex = 57;
            this.bt_adicionarPrato.Text = "Adicionar";
            this.bt_adicionarPrato.UseVisualStyleBackColor = true;
            // 
            // bt_removerExtra
            // 
            this.bt_removerExtra.Location = new System.Drawing.Point(62, 371);
            this.bt_removerExtra.Margin = new System.Windows.Forms.Padding(2);
            this.bt_removerExtra.Name = "bt_removerExtra";
            this.bt_removerExtra.Size = new System.Drawing.Size(62, 34);
            this.bt_removerExtra.TabIndex = 56;
            this.bt_removerExtra.Text = "Remover Extra";
            this.bt_removerExtra.UseVisualStyleBackColor = true;
            // 
            // bt_adicionarextra
            // 
            this.bt_adicionarextra.Location = new System.Drawing.Point(543, 384);
            this.bt_adicionarextra.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adicionarextra.Name = "bt_adicionarextra";
            this.bt_adicionarextra.Size = new System.Drawing.Size(62, 34);
            this.bt_adicionarextra.TabIndex = 55;
            this.bt_adicionarextra.Text = "Adicionar";
            this.bt_adicionarextra.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Quantidade";
            // 
            // tb_Quantidade
            // 
            this.tb_Quantidade.Location = new System.Drawing.Point(306, 333);
            this.tb_Quantidade.Name = "tb_Quantidade";
            this.tb_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantidade.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Preço Professor:";
            // 
            // TB_precoProfessor
            // 
            this.TB_precoProfessor.Location = new System.Drawing.Point(306, 273);
            this.TB_precoProfessor.Name = "TB_precoProfessor";
            this.TB_precoProfessor.Size = new System.Drawing.Size(100, 20);
            this.TB_precoProfessor.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Preço Estudante:";
            // 
            // TB_precoEstudante
            // 
            this.TB_precoEstudante.Location = new System.Drawing.Point(306, 204);
            this.TB_precoEstudante.Name = "TB_precoEstudante";
            this.TB_precoEstudante.Size = new System.Drawing.Size(100, 20);
            this.TB_precoEstudante.TabIndex = 48;
            // 
            // BT_RemoverMenu
            // 
            this.BT_RemoverMenu.Location = new System.Drawing.Point(105, 513);
            this.BT_RemoverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverMenu.Name = "BT_RemoverMenu";
            this.BT_RemoverMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_RemoverMenu.TabIndex = 47;
            this.BT_RemoverMenu.Text = "Remover";
            this.BT_RemoverMenu.UseVisualStyleBackColor = true;
            // 
            // BT_EditarMenu
            // 
            this.BT_EditarMenu.Location = new System.Drawing.Point(105, 461);
            this.BT_EditarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_EditarMenu.Name = "BT_EditarMenu";
            this.BT_EditarMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_EditarMenu.TabIndex = 46;
            this.BT_EditarMenu.Text = "Editar";
            this.BT_EditarMenu.UseVisualStyleBackColor = true;
            // 
            // BT_AdicionarMenu
            // 
            this.BT_AdicionarMenu.Location = new System.Drawing.Point(105, 409);
            this.BT_AdicionarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarMenu.Name = "BT_AdicionarMenu";
            this.BT_AdicionarMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_AdicionarMenu.TabIndex = 45;
            this.BT_AdicionarMenu.Text = "Adicionar Menu";
            this.BT_AdicionarMenu.UseVisualStyleBackColor = true;
            // 
            // LBox_Menus
            // 
            this.LBox_Menus.FormattingEnabled = true;
            this.LBox_Menus.Location = new System.Drawing.Point(68, 204);
            this.LBox_Menus.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_Menus.Name = "LBox_Menus";
            this.LBox_Menus.Size = new System.Drawing.Size(186, 121);
            this.LBox_Menus.TabIndex = 44;
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
            // LBox_ExtrasMenu
            // 
            this.LBox_ExtrasMenu.FormattingEnabled = true;
            this.LBox_ExtrasMenu.Location = new System.Drawing.Point(484, 246);
            this.LBox_ExtrasMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_ExtrasMenu.Name = "LBox_ExtrasMenu";
            this.LBox_ExtrasMenu.Size = new System.Drawing.Size(186, 134);
            this.LBox_ExtrasMenu.TabIndex = 42;
            // 
            // LBox_PratosReserva
            // 
            this.LBox_PratosReserva.FormattingEnabled = true;
            this.LBox_PratosReserva.Location = new System.Drawing.Point(484, 66);
            this.LBox_PratosReserva.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_PratosReserva.Name = "LBox_PratosReserva";
            this.LBox_PratosReserva.Size = new System.Drawing.Size(186, 134);
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
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 662);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button bt_removerPrato;
        private System.Windows.Forms.Button bt_adicionarPrato;
        private System.Windows.Forms.Button bt_removerExtra;
        private System.Windows.Forms.Button bt_adicionarextra;
        private System.Windows.Forms.ListBox LBox_Clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_precoProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_precoEstudante;
        private System.Windows.Forms.Button BT_RemoverMenu;
        private System.Windows.Forms.Button BT_EditarMenu;
        private System.Windows.Forms.Button BT_AdicionarMenu;
        private System.Windows.Forms.ListBox LBox_Menus;
        private System.Windows.Forms.DateTimePicker DTHora_Menu;
        private System.Windows.Forms.ListBox LBox_ExtrasMenu;
        private System.Windows.Forms.ListBox LBox_PratosReserva;
        private System.Windows.Forms.DateTimePicker DTData_Menu;
    }
}