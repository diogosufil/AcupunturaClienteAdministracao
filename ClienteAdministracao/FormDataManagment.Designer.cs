namespace ClienteAdministracao
{
    partial class FormDataManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataManagment));
            this.txtAbrirExcel = new System.Windows.Forms.TextBox();
            this.buttonReadExcel = new System.Windows.Forms.Button();
            this.buttonProcurarExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.richTextBoxSintomas = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDiagnosticos = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAbrirExcel
            // 
            this.txtAbrirExcel.Location = new System.Drawing.Point(92, 16);
            this.txtAbrirExcel.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbrirExcel.Name = "txtAbrirExcel";
            this.txtAbrirExcel.Size = new System.Drawing.Size(263, 22);
            this.txtAbrirExcel.TabIndex = 22;
            // 
            // buttonReadExcel
            // 
            this.buttonReadExcel.Location = new System.Drawing.Point(486, 13);
            this.buttonReadExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadExcel.Name = "buttonReadExcel";
            this.buttonReadExcel.Size = new System.Drawing.Size(115, 29);
            this.buttonReadExcel.TabIndex = 21;
            this.buttonReadExcel.Text = "Read Excel";
            this.buttonReadExcel.UseVisualStyleBackColor = true;
            this.buttonReadExcel.Click += new System.EventHandler(this.buttonReadExcel_Click);
            // 
            // buttonProcurarExcel
            // 
            this.buttonProcurarExcel.Location = new System.Drawing.Point(363, 13);
            this.buttonProcurarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcurarExcel.Name = "buttonProcurarExcel";
            this.buttonProcurarExcel.Size = new System.Drawing.Size(115, 29);
            this.buttonProcurarExcel.TabIndex = 20;
            this.buttonProcurarExcel.Text = "Search...";
            this.buttonProcurarExcel.UseVisualStyleBackColor = true;
            this.buttonProcurarExcel.Click += new System.EventHandler(this.buttonProcurarExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Excel File:";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelProgress.Location = new System.Drawing.Point(271, 422);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(125, 20);
            this.labelProgress.TabIndex = 23;
            this.labelProgress.Text = "labelProgress";
            // 
            // buttonImportData
            // 
            this.buttonImportData.Location = new System.Drawing.Point(608, 13);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(115, 30);
            this.buttonImportData.TabIndex = 24;
            this.buttonImportData.Text = "Import Data";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // richTextBoxSintomas
            // 
            this.richTextBoxSintomas.Location = new System.Drawing.Point(13, 72);
            this.richTextBoxSintomas.Name = "richTextBoxSintomas";
            this.richTextBoxSintomas.Size = new System.Drawing.Size(263, 337);
            this.richTextBoxSintomas.TabIndex = 25;
            this.richTextBoxSintomas.Text = "";
            // 
            // richTextBoxDiagnosticos
            // 
            this.richTextBoxDiagnosticos.Location = new System.Drawing.Point(298, 72);
            this.richTextBoxDiagnosticos.Name = "richTextBoxDiagnosticos";
            this.richTextBoxDiagnosticos.Size = new System.Drawing.Size(425, 337);
            this.richTextBoxDiagnosticos.TabIndex = 26;
            this.richTextBoxDiagnosticos.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Symptoms List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Diagnoses List";
            // 
            // FormDataManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxDiagnosticos);
            this.Controls.Add(this.richTextBoxSintomas);
            this.Controls.Add(this.buttonImportData);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.txtAbrirExcel);
            this.Controls.Add(this.buttonReadExcel);
            this.Controls.Add(this.buttonProcurarExcel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbrirExcel;
        private System.Windows.Forms.Button buttonReadExcel;
        private System.Windows.Forms.Button buttonProcurarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.RichTextBox richTextBoxSintomas;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnosticos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}