using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DomainModel;
using AcupunturaExcel;
using ClienteAdministracao.ServiceReferenceAcupuntura;

namespace ClienteAdministracao
{
    public partial class FormDataManagment : Form
    {
        OpenFileDialog openExcel = new OpenFileDialog();
        ServiceReferenceAcupuntura.Service1Client servico;

        public FormDataManagment()
        {
            InitializeComponent();
            txtAbrirExcel.ReadOnly = true;
            richTextBoxSintomas.ReadOnly = true;
            richTextBoxDiagnosticos.ReadOnly = true;
            buttonReadExcel.Enabled = false;
            buttonImportData.Enabled = false;
            labelProgress.Hide();
            servico = new ServiceReferenceAcupuntura.Service1Client();
        }

        private void buttonProcurarExcel_Click(object sender, EventArgs e)
        {
            //Procurar Excel:
            try
            {
                openExcel.Title = "Carregar Ficheiro";
                openExcel.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openExcel.ShowDialog();
                txtAbrirExcel.Text = Path.GetFileName(openExcel.FileName);
                buttonReadExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }

        }

        private void buttonReadExcel_Click(object sender, EventArgs e)
        {
            //Ler Excel:

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                labelProgress.Text = "Reading Excel\nPlease Wait...";
                if (!txtAbrirExcel.Text.Equals(""))
                {
                    labelProgress.Show();
                    List<Sintoma> listaSintomas = ExcelHandler.readSintomasFromExcel(openExcel.FileName);
                    List<Diagnostico> listaDiagnosticos = ExcelHandler.readDiagnosticosFromExcel(openExcel.FileName);
                    String leituraSintomas = "";
                    String leituraDiagnosticos = "";

                    foreach (Sintoma s in listaSintomas)
                    {
                        leituraSintomas += s.getNome + Environment.NewLine;
                    }
                    foreach (Diagnostico d in listaDiagnosticos)
                    {
                        leituraDiagnosticos += d.getNome + " -> " + d.getDescricao + Environment.NewLine;
                    }
                    richTextBoxSintomas.Text = leituraSintomas;
                    richTextBoxDiagnosticos.Text = leituraDiagnosticos;

                    labelProgress.Text = "*Not imported";
                    buttonImportData.Enabled = true;
                    MessageBox.Show("Excel file successfully Readed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtAbrirExcel.Text.Equals(""))
                {
                    MessageBox.Show("Insert Excel file!", "Missing file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while reading excel file!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImportData_Click(object sender, EventArgs e)
        {
            //Importar para o web service e gerar o Xml:

            labelProgress.Text = "Importing Data\nPlease Wait...";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //servico.writeToXmlFile(listaSintomas, listaDiagnosticos);

                labelProgress.Text = Path.GetFileName(openExcel.FileName) + " Imported!";
                MessageBox.Show("Data successfully imported!\nXML file successfully generated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while importing data!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
