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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_removerPrato = new System.Windows.Forms.Button();
            this.bt_adicionarPrato = new System.Windows.Forms.Button();
            this.bt_removerExtra = new System.Windows.Forms.Button();
            this.bt_adicionarextra = new System.Windows.Forms.Button();
            this.LBox_TodosMenus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_precoProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_precoEstudante = new System.Windows.Forms.TextBox();
            this.BT_RemoverMenu = new System.Windows.Forms.Button();
            this.BT_EditarMenu = new System.Windows.Forms.Button();
            this.BT_AdicionarMenu = new System.Windows.Forms.Button();
            this.LBox_MenuAtual = new System.Windows.Forms.ListBox();
            this.DTHora_Menu = new System.Windows.Forms.DateTimePicker();
            this.LBox_ExtrasMenu = new System.Windows.Forms.ListBox();
            this.LBox_PratosMenu = new System.Windows.Forms.ListBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTData_Menu
            // 
            this.DTData_Menu.Location = new System.Drawing.Point(246, 33);
            this.DTData_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.DTData_Menu.Name = "DTData_Menu";
            this.DTData_Menu.Size = new System.Drawing.Size(151, 20);
            this.DTData_Menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(419, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Menus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_removerPrato);
            this.groupBox1.Controls.Add(this.bt_adicionarPrato);
            this.groupBox1.Controls.Add(this.bt_removerExtra);
            this.groupBox1.Controls.Add(this.bt_adicionarextra);
            this.groupBox1.Controls.Add(this.LBox_TodosMenus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Quantidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_precoProfessor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_precoEstudante);
            this.groupBox1.Controls.Add(this.BT_RemoverMenu);
            this.groupBox1.Controls.Add(this.BT_EditarMenu);
            this.groupBox1.Controls.Add(this.BT_AdicionarMenu);
            this.groupBox1.Controls.Add(this.LBox_MenuAtual);
            this.groupBox1.Controls.Add(this.DTHora_Menu);
            this.groupBox1.Controls.Add(this.LBox_ExtrasMenu);
            this.groupBox1.Controls.Add(this.LBox_PratosMenu);
            this.groupBox1.Controls.Add(this.DTData_Menu);
            this.groupBox1.Location = new System.Drawing.Point(138, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(624, 492);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_removerPrato
            // 
            this.bt_removerPrato.Location = new System.Drawing.Point(546, 144);
            this.bt_removerPrato.Margin = new System.Windows.Forms.Padding(2);
            this.bt_removerPrato.Name = "bt_removerPrato";
            this.bt_removerPrato.Size = new System.Drawing.Size(62, 34);
            this.bt_removerPrato.TabIndex = 39;
            this.bt_removerPrato.Text = "Remover Prato";
            this.bt_removerPrato.UseVisualStyleBackColor = true;
            this.bt_removerPrato.Click += new System.EventHandler(this.bt_removerPrato_Click);
            // 
            // bt_adicionarPrato
            // 
            this.bt_adicionarPrato.Location = new System.Drawing.Point(93, 171);
            this.bt_adicionarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adicionarPrato.Name = "bt_adicionarPrato";
            this.bt_adicionarPrato.Size = new System.Drawing.Size(62, 34);
            this.bt_adicionarPrato.TabIndex = 38;
            this.bt_adicionarPrato.Text = "Adicionar";
            this.bt_adicionarPrato.UseVisualStyleBackColor = true;
            this.bt_adicionarPrato.Click += new System.EventHandler(this.bt_adicionarPrato_Click);
            // 
            // bt_removerExtra
            // 
            this.bt_removerExtra.Location = new System.Drawing.Point(422, 144);
            this.bt_removerExtra.Margin = new System.Windows.Forms.Padding(2);
            this.bt_removerExtra.Name = "bt_removerExtra";
            this.bt_removerExtra.Size = new System.Drawing.Size(62, 34);
            this.bt_removerExtra.TabIndex = 37;
            this.bt_removerExtra.Text = "Remover Extra";
            this.bt_removerExtra.UseVisualStyleBackColor = true;
            this.bt_removerExtra.Click += new System.EventHandler(this.bt_removerExtra_Click);
            // 
            // bt_adicionarextra
            // 
            this.bt_adicionarextra.Location = new System.Drawing.Point(93, 386);
            this.bt_adicionarextra.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adicionarextra.Name = "bt_adicionarextra";
            this.bt_adicionarextra.Size = new System.Drawing.Size(62, 34);
            this.bt_adicionarextra.TabIndex = 36;
            this.bt_adicionarextra.Text = "Adicionar";
            this.bt_adicionarextra.UseVisualStyleBackColor = true;
            this.bt_adicionarextra.Click += new System.EventHandler(this.bt_adicionarextra_Click);
            // 
            // LBox_TodosMenus
            // 
            this.LBox_TodosMenus.FormattingEnabled = true;
            this.LBox_TodosMenus.Location = new System.Drawing.Point(422, 347);
            this.LBox_TodosMenus.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_TodosMenus.Name = "LBox_TodosMenus";
            this.LBox_TodosMenus.Size = new System.Drawing.Size(186, 134);
            this.LBox_TodosMenus.TabIndex = 35;
            this.LBox_TodosMenus.SelectedIndexChanged += new System.EventHandler(this.LBox_TodosMenus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantidade";
            // 
            // tb_Quantidade
            // 
            this.tb_Quantidade.Location = new System.Drawing.Point(272, 260);
            this.tb_Quantidade.Name = "tb_Quantidade";
            this.tb_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantidade.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Preço Professor:";
            // 
            // TB_precoProfessor
            // 
            this.TB_precoProfessor.Location = new System.Drawing.Point(272, 200);
            this.TB_precoProfessor.Name = "TB_precoProfessor";
            this.TB_precoProfessor.Size = new System.Drawing.Size(100, 20);
            this.TB_precoProfessor.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Preço Estudante:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_precoEstudante
            // 
            this.TB_precoEstudante.Location = new System.Drawing.Point(272, 131);
            this.TB_precoEstudante.Name = "TB_precoEstudante";
            this.TB_precoEstudante.Size = new System.Drawing.Size(100, 20);
            this.TB_precoEstudante.TabIndex = 28;
            this.TB_precoEstudante.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BT_RemoverMenu
            // 
            this.BT_RemoverMenu.Location = new System.Drawing.Point(465, 286);
            this.BT_RemoverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoverMenu.Name = "BT_RemoverMenu";
            this.BT_RemoverMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_RemoverMenu.TabIndex = 27;
            this.BT_RemoverMenu.Text = "Remover";
            this.BT_RemoverMenu.UseVisualStyleBackColor = true;
            this.BT_RemoverMenu.Click += new System.EventHandler(this.BT_RemoverMenu_Click);
            // 
            // BT_EditarMenu
            // 
            this.BT_EditarMenu.Location = new System.Drawing.Point(465, 234);
            this.BT_EditarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_EditarMenu.Name = "BT_EditarMenu";
            this.BT_EditarMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_EditarMenu.TabIndex = 26;
            this.BT_EditarMenu.Text = "Editar";
            this.BT_EditarMenu.UseVisualStyleBackColor = true;
            this.BT_EditarMenu.Click += new System.EventHandler(this.BT_EditarMenu_Click);
            // 
            // BT_AdicionarMenu
            // 
            this.BT_AdicionarMenu.Location = new System.Drawing.Point(465, 182);
            this.BT_AdicionarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AdicionarMenu.Name = "BT_AdicionarMenu";
            this.BT_AdicionarMenu.Size = new System.Drawing.Size(112, 48);
            this.BT_AdicionarMenu.TabIndex = 25;
            this.BT_AdicionarMenu.Text = "Adicionar Menu";
            this.BT_AdicionarMenu.UseVisualStyleBackColor = true;
            this.BT_AdicionarMenu.Click += new System.EventHandler(this.BT_AdicionarMenu_Click);
            // 
            // LBox_MenuAtual
            // 
            this.LBox_MenuAtual.FormattingEnabled = true;
            this.LBox_MenuAtual.Location = new System.Drawing.Point(422, 32);
            this.LBox_MenuAtual.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_MenuAtual.Name = "LBox_MenuAtual";
            this.LBox_MenuAtual.Size = new System.Drawing.Size(186, 108);
            this.LBox_MenuAtual.TabIndex = 24;
            this.LBox_MenuAtual.SelectedIndexChanged += new System.EventHandler(this.LBox_MenuAtual_SelectedIndexChanged);
            // 
            // DTHora_Menu
            // 
            this.DTHora_Menu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHora_Menu.Location = new System.Drawing.Point(246, 56);
            this.DTHora_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.DTHora_Menu.Name = "DTHora_Menu";
            this.DTHora_Menu.Size = new System.Drawing.Size(151, 20);
            this.DTHora_Menu.TabIndex = 23;
            // 
            // LBox_ExtrasMenu
            // 
            this.LBox_ExtrasMenu.FormattingEnabled = true;
            this.LBox_ExtrasMenu.Location = new System.Drawing.Point(34, 248);
            this.LBox_ExtrasMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_ExtrasMenu.Name = "LBox_ExtrasMenu";
            this.LBox_ExtrasMenu.Size = new System.Drawing.Size(186, 134);
            this.LBox_ExtrasMenu.TabIndex = 22;
            this.LBox_ExtrasMenu.SelectedIndexChanged += new System.EventHandler(this.LBox_ExtrasMenu_SelectedIndexChanged);
            // 
            // LBox_PratosMenu
            // 
            this.LBox_PratosMenu.FormattingEnabled = true;
            this.LBox_PratosMenu.Location = new System.Drawing.Point(34, 33);
            this.LBox_PratosMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LBox_PratosMenu.Name = "LBox_PratosMenu";
            this.LBox_PratosMenu.Size = new System.Drawing.Size(186, 134);
            this.LBox_PratosMenu.TabIndex = 21;
            this.LBox_PratosMenu.SelectedIndexChanged += new System.EventHandler(this.LBox_PratosMenu_SelectedIndexChanged);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(25, 579);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(131, 61);
            this.bt_voltar.TabIndex = 34;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 667);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTData_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBox_ExtrasMenu;
        private System.Windows.Forms.ListBox LBox_PratosMenu;
        private System.Windows.Forms.DateTimePicker DTHora_Menu;
        private System.Windows.Forms.ListBox LBox_MenuAtual;
        private System.Windows.Forms.Button BT_RemoverMenu;
        private System.Windows.Forms.Button BT_EditarMenu;
        private System.Windows.Forms.Button BT_AdicionarMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_precoEstudante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_precoProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Quantidade;
        private System.Windows.Forms.Button bt_removerPrato;
        private System.Windows.Forms.Button bt_adicionarPrato;
        private System.Windows.Forms.Button bt_removerExtra;
        private System.Windows.Forms.Button bt_adicionarextra;
        private System.Windows.Forms.ListBox LBox_TodosMenus;
        private System.Windows.Forms.Button bt_voltar;
    }
}