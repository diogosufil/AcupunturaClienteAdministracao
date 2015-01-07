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
    public partial class FormEditarHR : Form
    {
        int biPesquisa;
        String nome;
        int bi;
        int idTerapeuta;
        DateTime dataNascimento;
        String userPesquisa;
        String username;
        String password;
        string token = ClienteAdministracao.Properties.Settings.Default.token;
        ServiceReferenceAcupuntura.Service1Client servico;

        public FormEditarHR()
        {
            InitializeComponent();
            servico = new ServiceReferenceAcupuntura.Service1Client();
            txtNome.ReadOnly = true;
            txtBI.ReadOnly = true;
            dateTimeDataNascim.Enabled = false;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            groupBoxAutenticacao.Visible = true;
            groupBoxDadosPessoais.Visible = true;


        }

        private void btnPesquisarBI_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEscolherTipo.Text.Equals("Paciente"))
                {
                    groupBoxAutenticacao.Visible = false;
                    biPesquisa = Convert.ToInt32(txtPesquisarBI.Text);
                    int idTerapeuta = 0;
                    PacienteWEB pWeb = servico.getPacientePorBi(token, biPesquisa, idTerapeuta);
                    nome = pWeb.nome;
                    bi = pWeb.bi;
                    dataNascimento = pWeb.dataNascimento;

                    txtNome.Text = nome;
                    txtBI.Text = Convert.ToInt32(bi).ToString();
                    dateTimeDataNascim.Value = dataNascimento;
                }

                //if (comboBoxEscolherTipo.Text.Equals("Administrador"))
                //{
                //userPesquisa = txtPesquisarBI.Text;
                //UtilizadorWEB aWeb = servico.getUtilizadorUsername(token, userPesquisa);
                //username = aWeb.username;
                //password = aWeb.password;

                //txtUsername.Text = username;
                //txtPassword.Text = password;
                //}

                if (comboBoxEscolherTipo.Text.Equals("Terapeuta"))
                {
                    biPesquisa = Convert.ToInt32(txtPesquisarBI.Text);

                    TerapeutaWEB tWeb = servico.getTerapeutaPorBi(token, bi);
                    nome = tWeb.nome;
                    bi = tWeb.bi;
                    dataNascimento = tWeb.dataNascimento;
                    UtilizadorWEB uWeb = servico.getUtilizadorIdTerapeura(token, tWeb.id);
                    username = uWeb.username;
                    password = uWeb.password;

                    txtNome.Text = nome;
                    txtBI.Text = Convert.ToInt32(biPesquisa).ToString();
                    dateTimeDataNascim.Value = dataNascimento;
                    txtUsername.Text = username;
                    txtPassword.Text = password;
                }

            }
            catch
            {

                MessageBox.Show("Erro!");
            }

        }

        private void FormEditarHR_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            dateTimeDataNascim.Enabled = true; 
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEscolherTipo.Text.Equals("Terapeuta"))
                {
                    nome = txtNome.Text;
                    dataNascimento = dateTimeDataNascim.Value;
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    if (servico.editarTerapeuta(token, nome, bi, dataNascimento, username, password))
                    {
                        MessageBox.Show("Terapeuta alterado com sucesso!");
                    }
                    else MessageBox.Show("Terapeuta não foi alterado com Sucesso!");
                }
                if (comboBoxEscolherTipo.Text.Equals("Paciente"))
                {
                    //biPesquisa = Convert.ToInt32(txtPesquisarBI.Text);
                    //TerapeutaWEB tWeb = servico.getTerapeutaID(token);
                    //idTerapeuta = tWeb.id;
                    nome = txtNome.Text;
                    dataNascimento = dateTimeDataNascim.Value;
                    if (servico.editarPaciente(token, 2, nome, bi, dataNascimento))
                    {
                        MessageBox.Show("Paciente alterado com sucesso!");
                    }
                    else MessageBox.Show("Paciente não foi alterado com Sucesso!");
                }
            }

            catch
            {
                MessageBox.Show("Erro!");
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

