namespace ClienteAdministracao
{
    partial class FormAdicionarHR
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
            this.tbnAdicionar = new System.Windows.Forms.Button();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dateTimeDataNascim = new System.Windows.Forms.DateTimePicker();
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
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBoxAutenticacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(509, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbnAdicionar
            // 
            this.tbnAdicionar.Location = new System.Drawing.Point(421, 382);
            this.tbnAdicionar.Name = "tbnAdicionar";
            this.tbnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.tbnAdicionar.TabIndex = 31;
            this.tbnAdicionar.Text = "Adicionar";
            this.tbnAdicionar.UseVisualStyleBackColor = true;
            this.tbnAdicionar.Click += new System.EventHandler(this.tbnAdicionar_Click);
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.dateTimeDataNascim);
            this.groupBoxDadosPessoais.Controls.Add(this.label2);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBI);
            this.groupBoxDadosPessoais.Controls.Add(this.label3);
            this.groupBoxDadosPessoais.Controls.Add(this.txtNome);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(24, 73);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(500, 107);
            this.groupBoxDadosPessoais.TabIndex = 30;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // dateTimeDataNascim
            // 
            this.dateTimeDataNascim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataNascim.Location = new System.Drawing.Point(272, 68);
            this.dateTimeDataNascim.Name = "dateTimeDataNascim";
            this.dateTimeDataNascim.Size = new System.Drawing.Size(99, 20);
            this.dateTimeDataNascim.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtBI
            // 
            this.txtBI.Location = new System.Drawing.Point(44, 68);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(100, 20);
            this.txtBI.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BI:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 71);
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
            this.groupBoxAutenticacao.Location = new System.Drawing.Point(24, 198);
            this.groupBoxAutenticacao.Name = "groupBoxAutenticacao";
            this.groupBoxAutenticacao.Size = new System.Drawing.Size(229, 132);
            this.groupBoxAutenticacao.TabIndex = 28;
            this.groupBoxAutenticacao.TabStop = false;
            this.groupBoxAutenticacao.Text = "Autenticação";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(117, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(82, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // comboBoxEscolherTipo
            // 
            this.comboBoxEscolherTipo.FormattingEnabled = true;
            this.comboBoxEscolherTipo.Items.AddRange(new object[] {
            "Administrador",
            "Terapeuta",
            "Paciente"});
            this.comboBoxEscolherTipo.Location = new System.Drawing.Point(24, 26);
            this.comboBoxEscolherTipo.Name = "comboBoxEscolherTipo";
            this.comboBoxEscolherTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolherTipo.TabIndex = 33;
            this.comboBoxEscolherTipo.Text = "Escolher tipo ";
            this.comboBoxEscolherTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxEscolherTipo_SelectedIndexChanged);
            // 
            // FormAdicionarHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 418);
            this.Controls.Add(this.comboBoxEscolherTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbnAdicionar);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBoxAutenticacao);
            this.Name = "FormAdicionarHR";
            this.Text = "FormAdicionarHR";
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBoxAutenticacao.ResumeLayout(false);
            this.groupBoxAutenticacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button tbnAdicionar;
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
        private System.Windows.Forms.DateTimePicker dateTimeDataNascim;
        private System.Windows.Forms.ComboBox comboBoxEscolherTipo;
    }
}