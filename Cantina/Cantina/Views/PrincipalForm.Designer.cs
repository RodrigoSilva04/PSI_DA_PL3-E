namespace Cantina
{
    partial class PrincipalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_reservas = new System.Windows.Forms.Button();
            this.bt_Pratos = new System.Windows.Forms.Button();
            this.bt_Extras = new System.Windows.Forms.Button();
            this.bt_Multas = new System.Windows.Forms.Button();
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.bt_Menu = new System.Windows.Forms.Button();
            this.bt_Funcionários = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_loginUt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_MenusSemana = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Saldo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo á cantina";
            // 
            // bt_reservas
            // 
            this.bt_reservas.Location = new System.Drawing.Point(107, 2);
            this.bt_reservas.Margin = new System.Windows.Forms.Padding(2);
            this.bt_reservas.Name = "bt_reservas";
            this.bt_reservas.Size = new System.Drawing.Size(101, 50);
            this.bt_reservas.TabIndex = 1;
            this.bt_reservas.Text = "Reservas";
            this.bt_reservas.UseVisualStyleBackColor = true;
            this.bt_reservas.Click += new System.EventHandler(this.bt_reservas_Click);
            // 
            // bt_Pratos
            // 
            this.bt_Pratos.Location = new System.Drawing.Point(212, 2);
            this.bt_Pratos.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Pratos.Name = "bt_Pratos";
            this.bt_Pratos.Size = new System.Drawing.Size(101, 50);
            this.bt_Pratos.TabIndex = 2;
            this.bt_Pratos.Text = "Pratos";
            this.bt_Pratos.UseVisualStyleBackColor = true;
            this.bt_Pratos.Click += new System.EventHandler(this.bt_Pratos_Click);
            // 
            // bt_Extras
            // 
            this.bt_Extras.Location = new System.Drawing.Point(317, 2);
            this.bt_Extras.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Extras.Name = "bt_Extras";
            this.bt_Extras.Size = new System.Drawing.Size(101, 50);
            this.bt_Extras.TabIndex = 3;
            this.bt_Extras.Text = "Extras";
            this.bt_Extras.UseVisualStyleBackColor = true;
            this.bt_Extras.Click += new System.EventHandler(this.bt_Extras_Click);
            // 
            // bt_Multas
            // 
            this.bt_Multas.Location = new System.Drawing.Point(2, 2);
            this.bt_Multas.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Multas.Name = "bt_Multas";
            this.bt_Multas.Size = new System.Drawing.Size(101, 50);
            this.bt_Multas.TabIndex = 4;
            this.bt_Multas.Text = "Multas";
            this.bt_Multas.UseVisualStyleBackColor = true;
            this.bt_Multas.Click += new System.EventHandler(this.bt_Multas_Click);
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(422, 2);
            this.bt_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(101, 50);
            this.bt_Clientes.TabIndex = 5;
            this.bt_Clientes.Text = "Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            this.bt_Clientes.Click += new System.EventHandler(this.bt_Clientes_Click);
            // 
            // bt_Menu
            // 
            this.bt_Menu.Location = new System.Drawing.Point(2, 56);
            this.bt_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(101, 50);
            this.bt_Menu.TabIndex = 6;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_Funcionários
            // 
            this.bt_Funcionários.Location = new System.Drawing.Point(107, 56);
            this.bt_Funcionários.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Funcionários.Name = "bt_Funcionários";
            this.bt_Funcionários.Size = new System.Drawing.Size(101, 50);
            this.bt_Funcionários.TabIndex = 7;
            this.bt_Funcionários.Text = "Funcionários";
            this.bt_Funcionários.UseVisualStyleBackColor = true;
            this.bt_Funcionários.Click += new System.EventHandler(this.bt_Funcionários_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(317, 56);
            this.bt_sair.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(101, 50);
            this.bt_sair.TabIndex = 8;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(364, 275);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(597, 156);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_Multas);
            this.flowLayoutPanel1.Controls.Add(this.bt_reservas);
            this.flowLayoutPanel1.Controls.Add(this.bt_Pratos);
            this.flowLayoutPanel1.Controls.Add(this.bt_Extras);
            this.flowLayoutPanel1.Controls.Add(this.bt_Clientes);
            this.flowLayoutPanel1.Controls.Add(this.bt_Menu);
            this.flowLayoutPanel1.Controls.Add(this.bt_Funcionários);
            this.flowLayoutPanel1.Controls.Add(this.bt_Saldo);
            this.flowLayoutPanel1.Controls.Add(this.bt_sair);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 17);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 122);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(541, 91);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(841, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecione um utilizador";
            // 
            // bt_loginUt
            // 
            this.bt_loginUt.Location = new System.Drawing.Point(841, 62);
            this.bt_loginUt.Margin = new System.Windows.Forms.Padding(2);
            this.bt_loginUt.Name = "bt_loginUt";
            this.bt_loginUt.Size = new System.Drawing.Size(92, 29);
            this.bt_loginUt.TabIndex = 13;
            this.bt_loginUt.Text = "Confirmar";
            this.bt_loginUt.UseVisualStyleBackColor = true;
            this.bt_loginUt.Click += new System.EventHandler(this.bt_loginUt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "user";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tl_MenusSemana
            // 
            this.tl_MenusSemana.ColumnCount = 5;
            this.tl_MenusSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tl_MenusSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tl_MenusSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tl_MenusSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tl_MenusSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tl_MenusSemana.Location = new System.Drawing.Point(26, 153);
            this.tl_MenusSemana.Name = "tl_MenusSemana";
            this.tl_MenusSemana.RowCount = 1;
            this.tl_MenusSemana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tl_MenusSemana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tl_MenusSemana.Size = new System.Drawing.Size(400, 100);
            this.tl_MenusSemana.TabIndex = 15;
            // 
            // bt_Saldo
            // 
            this.bt_Saldo.Location = new System.Drawing.Point(212, 56);
            this.bt_Saldo.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Saldo.Name = "bt_Saldo";
            this.bt_Saldo.Size = new System.Drawing.Size(101, 50);
            this.bt_Saldo.TabIndex = 9;
            this.bt_Saldo.Text = "Saldo";
            this.bt_Saldo.UseVisualStyleBackColor = true;
            this.bt_Saldo.Click += new System.EventHandler(this.bt_Saldo_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 482);
            this.Controls.Add(this.tl_MenusSemana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_loginUt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrincipalForm";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_reservas;
        private System.Windows.Forms.Button bt_Pratos;
        private System.Windows.Forms.Button bt_Extras;
        private System.Windows.Forms.Button bt_Multas;
        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.Button bt_Menu;
        private System.Windows.Forms.Button bt_Funcionários;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_loginUt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tl_MenusSemana;
        private System.Windows.Forms.Button bt_Saldo;
    }
}