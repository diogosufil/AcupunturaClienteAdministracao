using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteAdministracao.ServiceReferenceAcupuntura;

namespace ClienteAdministracao
{
    public partial class FormMain : Form
    {
        private String token;
        ServiceReferenceAcupuntura.Service1Client servico;

        public FormMain()
        {
            InitializeComponent();
            token = ClienteAdministracao.Properties.Settings.Default.token;
            servico = new ServiceReferenceAcupuntura.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(token);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //Logout:
            try
            {
                servico.logOut(token);
                this.Close();
                FormLogin f = new FormLogin();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }

        private void buttonDataMangmt_Click(object sender, EventArgs e)
        {
            //Gestão de dados (Excel):

            FormDataManagment fdm = new FormDataManagment();
            fdm.Show();
        }

        private void buttonHumanResources_Click(object sender, EventArgs e)
        {
            //Gestão de Recursos Humanos:

            FormHumanRes fhr = new FormHumanRes();
            fhr.Show();
        }
    }
}
