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
            this.groupBoxPaciente = new System.Windows.Forms.GroupBox();
            this.richTextBoxHistorico = new System.Windows.Forms.RichTextBox();
            this.comboBoxAssociarTerapeuta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEscolherTipo = new System.Windows.Forms.ComboBox();
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
            this.groupBoxPaciente.SuspendLayout();
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
            // 
            // tbnAdicionar
            // 
            this.tbnAdicionar.Location = new System.Drawing.Point(421, 382);
            this.tbnAdicionar.Name = "tbnAdicionar";
            this.tbnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.tbnAdicionar.TabIndex = 31;
            this.tbnAdicionar.Text = "Adicionar";
            this.tbnAdicionar.UseVisualStyleBackColor = true;
            // 
            // groupBoxPaciente
            // 
            this.groupBoxPaciente.Controls.Add(this.richTextBoxHistorico);
            this.groupBoxPaciente.Controls.Add(this.comboBoxAssociarTerapeuta);
            this.groupBoxPaciente.Controls.Add(this.label7);
            this.groupBoxPaciente.Controls.Add(this.label8);
            this.groupBoxPaciente.Location = new System.Drawing.Point(268, 198);
            this.groupBoxPaciente.Name = "groupBoxPaciente";
            this.groupBoxPaciente.Size = new System.Drawing.Size(316, 167);
            this.groupBoxPaciente.TabIndex = 29;
            this.groupBoxPaciente.TabStop = false;
            this.groupBoxPaciente.Text = "Paciente";
            // 
            // richTextBoxHistorico
            // 
            this.richTextBoxHistorico.Location = new System.Drawing.Point(77, 52);
            this.richTextBoxHistorico.Name = "richTextBoxHistorico";
            this.richTextBoxHistorico.Size = new System.Drawing.Size(216, 108);
            this.richTextBoxHistorico.TabIndex = 10;
            this.richTextBoxHistorico.Text = "";
            // 
            // comboBoxAssociarTerapeuta
            // 
            this.comboBoxAssociarTerapeuta.FormattingEnabled = true;
            this.comboBoxAssociarTerapeuta.Items.AddRange(new object[] {
            "Administrador",
            "Terapeuta",
            "Paciente"});
            this.comboBoxAssociarTerapeuta.Location = new System.Drawing.Point(126, 25);
            this.comboBoxAssociarTerapeuta.Name = "comboBoxAssociarTerapeuta";
            this.comboBoxAssociarTerapeuta.Size = new System.Drawing.Size(167, 21);
            this.comboBoxAssociarTerapeuta.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Associar Terapeuta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Historico:";
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.label1);
            this.groupBoxDadosPessoais.Controls.Add(this.comboBoxEscolherTipo);
            this.groupBoxDadosPessoais.Controls.Add(this.dateTimeDataNascim);
            this.groupBoxDadosPessoais.Controls.Add(this.label2);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBI);
            this.groupBoxDadosPessoais.Controls.Add(this.label3);
            this.groupBoxDadosPessoais.Controls.Add(this.txtNome);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(24, 12);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(500, 168);
            this.groupBoxDadosPessoais.TabIndex = 30;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolher tipo:";
            // 
            // comboBoxEscolherTipo
            // 
            this.comboBoxEscolherTipo.FormattingEnabled = true;
            this.comboBoxEscolherTipo.Items.AddRange(new object[] {
            "Administrador",
            "Terapeuta",
            "Paciente"});
            this.comboBoxEscolherTipo.Location = new System.Drawing.Point(95, 39);
            this.comboBoxEscolherTipo.Name = "comboBoxEscolherTipo";
            this.comboBoxEscolherTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolherTipo.TabIndex = 0;
            // 
            // dateTimeDataNascim
            // 
            this.dateTimeDataNascim.Location = new System.Drawing.Point(272, 118);
            this.dateTimeDataNascim.Name = "dateTimeDataNascim";
            this.dateTimeDataNascim.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDataNascim.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtBI
            // 
            this.txtBI.Location = new System.Drawing.Point(44, 118);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(100, 20);
            this.txtBI.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BI:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 121);
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
            // FormAdicionarHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 418);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbnAdicionar);
            this.Controls.Add(this.groupBoxPaciente);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBoxAutenticacao);
            this.Name = "FormAdicionarHR";
            this.Text = "FormAdicionarHR";
            this.groupBoxPaciente.ResumeLayout(false);
            this.groupBoxPaciente.PerformLayout();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBoxAutenticacao.ResumeLayout(false);
            this.groupBoxAutenticacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button tbnAdicionar;
        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.RichTextBox richTextBoxHistorico;
        private System.Windows.Forms.ComboBox comboBoxAssociarTerapeuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEscolherTipo;
        private System.Windows.Forms.DateTimePicker dateTimeDataNascim;
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
    }
}