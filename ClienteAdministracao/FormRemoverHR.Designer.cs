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
            this.btnPesquisarBI = new System.Windows.Forms.Button();
            this.txtPesquisarBI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxPaciente = new System.Windows.Forms.GroupBox();
            this.richTextBoxHistorico = new System.Windows.Forms.RichTextBox();
            this.comboBoxAssociarTerapeuta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.groupBoxPaciente.SuspendLayout();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBoxAutenticacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(482, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(397, 404);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarBI
            // 
            this.btnPesquisarBI.Location = new System.Drawing.Point(260, 18);
            this.btnPesquisarBI.Name = "btnPesquisarBI";
            this.btnPesquisarBI.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarBI.TabIndex = 32;
            this.btnPesquisarBI.Text = "Pesquisar";
            this.btnPesquisarBI.UseVisualStyleBackColor = true;
            // 
            // txtPesquisarBI
            // 
            this.txtPesquisarBI.Location = new System.Drawing.Point(126, 20);
            this.txtPesquisarBI.Name = "txtPesquisarBI";
            this.txtPesquisarBI.Size = new System.Drawing.Size(108, 20);
            this.txtPesquisarBI.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pesquisar por BI:";
            // 
            // groupBoxPaciente
            // 
            this.groupBoxPaciente.Controls.Add(this.richTextBoxHistorico);
            this.groupBoxPaciente.Controls.Add(this.comboBoxAssociarTerapeuta);
            this.groupBoxPaciente.Controls.Add(this.label7);
            this.groupBoxPaciente.Controls.Add(this.label8);
            this.groupBoxPaciente.Location = new System.Drawing.Point(264, 216);
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
            // dateTimeDataNascim
            // 
            this.dateTimeDataNascim.Location = new System.Drawing.Point(272, 66);
            this.dateTimeDataNascim.Name = "dateTimeDataNascim";
            this.dateTimeDataNascim.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDataNascim.TabIndex = 7;
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
            this.groupBoxAutenticacao.Location = new System.Drawing.Point(20, 216);
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
            // FormRemoverHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 432);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnPesquisarBI);
            this.Controls.Add(this.txtPesquisarBI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxPaciente);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBoxAutenticacao);
            this.Name = "FormRemoverHR";
            this.Text = "FormRemoverHR";
            this.groupBoxPaciente.ResumeLayout(false);
            this.groupBoxPaciente.PerformLayout();
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
        private System.Windows.Forms.Button btnPesquisarBI;
        private System.Windows.Forms.TextBox txtPesquisarBI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.RichTextBox richTextBoxHistorico;
        private System.Windows.Forms.ComboBox comboBoxAssociarTerapeuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
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