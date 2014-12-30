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
    public partial class FormLogin : Form
    {
        private String username;
        private String password;
        private String token = "";
        ServiceReferenceAcupuntura.Service1Client servico;

        public FormLogin()
        {
            InitializeComponent();
            servico = new ServiceReferenceAcupuntura.Service1Client();
            labelPleaseWait.Text = "Logging in\nPlease wait...";
            labelPleaseWait.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Botão Login
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                labelPleaseWait.Show();
                token = servico.logIn(username, password);
                if (servico.isAdmin(token))
                {
                    ClienteAdministracao.Properties.Settings.Default.token = token;
                    ClienteAdministracao.Properties.Settings.Default.Save();
                    labelPleaseWait.Hide();
                    this.Hide();
                    FormMain f = new FormMain();
                    f.Show();
                }
                else
                {
                    throw new Exception("User is not administrator!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonLogin;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!token.Equals(""))
            {
                if (servico.isLoggedIn(token))
                    servico.logOut(token);
            }
            Application.Exit();
        }
    }
}
