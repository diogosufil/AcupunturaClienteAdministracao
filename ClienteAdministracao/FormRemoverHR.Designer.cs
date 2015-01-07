namespace ClienteAdministracao
{
    partial class FormRemoverHR
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAutenticacao = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEscolherTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesquisarBI = new System.Windows.Forms.Button();
            this.txtPesquisarBI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDataNascim = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBoxAutenticacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(360, 273);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.dateTimeDataNascim);
            this.groupBoxDadosPessoais.Controls.Add(this.label2);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBI);
            this.groupBoxDadosPessoais.Controls.Add(this.label3);
            this.groupBoxDadosPessoais.Controls.Add(this.txtNome);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(20, 59);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(500, 109);
            this.groupBoxDadosPessoais.TabIndex = 28;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtBI
            // 
            this.txtBI.Location = new System.Drawing.Point(44, 66);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(100, 20);
            this.txtBI.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BI:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Nascimento:";
            // 
            // groupBoxAutenticacao
            // 
            this.groupBoxAutenticacao.Controls.Add(this.txtPassword);
            this.groupBoxAutenticacao.Controls.Add(this.label6);
            this.groupBoxAutenticacao.Controls.Add(this.txtUsername);
            this.groupBoxAutenticacao.Controls.Add(this.label5);
            this.groupBoxAutenticacao.Location = new System.Drawing.Point(23, 174);
            this.groupBoxAutenticacao.Name = "groupBoxAutenticacao";
            this.groupBoxAutenticacao.Size = new System.Drawing.Size(229, 103);
            this.groupBoxAutenticacao.TabIndex = 27;
            this.groupBoxAutenticacao.TabStop = false;
            this.groupBoxAutenticacao.Text = "Autenticação";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(82, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // comboBoxEscolherTipo
            // 
            this.comboBoxEscolherTipo.FormattingEnabled = true;
            this.comboBoxEscolherTipo.Items.AddRange(new object[] {
            "Terapeuta",
            "Paciente"});
            this.comboBoxEscolherTipo.Location = new System.Drawing.Point(86, 21);
            this.comboBoxEscolherTipo.Name = "comboBoxEscolherTipo";
            this.comboBoxEscolherTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolherTipo.TabIndex = 43;
            this.comboBoxEscolherTipo.Text = "Escolher tipo ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "por BI:";
            // 
            // btnPesquisarBI
            // 
            this.btnPesquisarBI.Location = new System.Drawing.Point(409, 20);
            this.btnPesquisarBI.Name = "btnPesquisarBI";
            this.btnPesquisarBI.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarBI.TabIndex = 41;
            this.btnPesquisarBI.Text = "Pesquisar";
            this.btnPesquisarBI.UseVisualStyleBackColor = true;
            this.btnPesquisarBI.Click += new System.EventHandler(this.btnPesquisarBI_Click_1);
            // 
            // txtPesquisarBI
            // 
            this.txtPesquisarBI.Location = new System.Drawing.Point(275, 22);
            this.txtPesquisarBI.Name = "txtPesquisarBI";
            this.txtPesquisarBI.Size = new System.Drawing.Size(108, 20);
            this.txtPesquisarBI.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Pesquisar";
            // 
            // dateTimeDataNascim
            // 
            this.dateTimeDataNascim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataNascim.Location = new System.Drawing.Point(272, 66);
            this.dateTimeDataNascim.Name = "dateTimeDataNascim";
            this.dateTimeDataNascim.Size = new System.Drawing.Size(99, 20);
            this.dateTimeDataNascim.TabIndex = 34;
            // 
            // FormRemoverHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 314);
            this.Controls.Add(this.comboBoxEscolherTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPesquisarBI);
            this.Controls.Add(this.txtPesquisarBI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBoxAutenticacao);
            this.Name = "FormRemoverHR";
            this.Text = "FormRemoverHR";
            this.Load += new System.EventHandler(this.FormRemoverHR_Load);
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBoxAutenticacao.ResumeLayout(false);
            this.groupBoxAutenticacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAutenticacao;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEscolherTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisarBI;
        private System.Windows.Forms.TextBox txtPesquisarBI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDataNascim;
    }
}