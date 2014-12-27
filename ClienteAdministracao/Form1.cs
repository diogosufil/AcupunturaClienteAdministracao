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
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        ServiceReferenceAcupuntura.Service1Client servico;

        public Form1()
        {
            InitializeComponent();

            servico = new ServiceReferenceAcupuntura.Service1Client();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Botão Login
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            try
            {
                String token = servico.logIn(username, password);
                ClienteAdministracao.Properties.Settings.Default.token = token;
                ClienteAdministracao.Properties.Settings.Default.Save();
                FormMain f = new FormMain();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }
    }
}
