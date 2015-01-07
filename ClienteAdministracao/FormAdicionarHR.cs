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
    public partial class FormAdicionarHR : Form
    {
        String nome;
        int bi;
        DateTime dataNascimento;
        String username;
        String password;
        string token = ClienteAdministracao.Properties.Settings.Default.token;

        ServiceReferenceAcupuntura.Service1Client servico;

        public FormAdicionarHR()
        {
            InitializeComponent();
            servico = new ServiceReferenceAcupuntura.Service1Client();
            groupBoxAutenticacao.Visible = true;
            groupBoxDadosPessoais.Visible = true;

        }

        private void tbnAdicionar_Click(object sender, EventArgs e)
        {

        
            try
            {
                if (comboBoxEscolherTipo.Text.Equals("Paciente"))
                {
                    nome = txtNome.Text;
                    bi = Convert.ToInt32(txtBI.Text);
                    dataNascimento = dateTimeDataNascim.Value;
                    if (servico.adicionarPaciente(token, nome, bi, dataNascimento))
                    {
                        MessageBox.Show("Paciente Adicionado com sucesso!");
                    }
                    else MessageBox.Show("Paciente não foi Adicionado com Sucesso!");                
                }

                if (comboBoxEscolherTipo.Text.Equals("Administrador"))
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    if (servico.adicionarAdministrador(token, username, password))
                    {
                        MessageBox.Show("Administrador Adicionado com sucesso!");
                    }
                    else MessageBox.Show("Administrador não foi Adicionado com Sucesso!");
                }
                if (comboBoxEscolherTipo.Text.Equals("Terapeuta"))
                {

                    nome = txtNome.Text;
                    bi = Convert.ToInt32(txtBI.Text);
                    dataNascimento = dateTimeDataNascim.Value;
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    if (servico.adicionarTerapeuta(token, nome, bi,dataNascimento, username, password))
                    {
                        MessageBox.Show("Administrador Adicionado com sucesso!");
                    }
                    else MessageBox.Show("Administrador não foi Adicionado com Sucesso!");
                }

            }
            catch {
                MessageBox.Show("Erro");
            }
        }

        private void comboBoxEscolherTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEscolherTipo.Text.Equals("Paciente"))
            {
                groupBoxDadosPessoais.Visible = true;
                groupBoxAutenticacao.Visible = false;
            }


            if (comboBoxEscolherTipo.Text.Equals("Administrador"))
            {
                groupBoxDadosPessoais.Visible = false;
                groupBoxAutenticacao.Visible = true;
            }

            if (comboBoxEscolherTipo.Text.Equals("Terapeuta"))
            {
                groupBoxDadosPessoais.Visible = true;
                groupBoxAutenticacao.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    

    }
}
