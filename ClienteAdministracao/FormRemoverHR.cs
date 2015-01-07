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
    public partial class FormRemoverHR : Form
    {
        int biPesquisa;
        String nome;
        int bi;
        int idTerapeuta;
        DateTime dataNascimento;
        String username;
        String password;
        string token = ClienteAdministracao.Properties.Settings.Default.token;
        ServiceReferenceAcupuntura.Service1Client servico;


        public FormRemoverHR()
        {
            InitializeComponent();
            servico = new ServiceReferenceAcupuntura.Service1Client();
            txtNome.ReadOnly = true;
            txtBI.ReadOnly = true;
            dateTimeDataNascim.Enabled = false;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            groupBoxDadosPessoais.Visible = true;
            groupBoxDadosPessoais.Visible = true;
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEscolherTipo.Text.Equals("Terapeuta"))
                {
                  int  biPesquisa = Convert.ToInt32(txtPesquisarBI.Text);

                    if (servico.removerTerapeuta(token, biPesquisa ))
                    {
                        MessageBox.Show("Terapeuta removido com sucesso!");
                    }
                    else MessageBox.Show("Terapeuta não foi removido com Sucesso!");
                }
                if (comboBoxEscolherTipo.Text.Equals("Paciente"))
                {
                    biPesquisa = Convert.ToInt32(txtPesquisarBI.Text);
                    int idTerapeuta = 0;
             
                    if (servico.removerPaciente(token, biPesquisa, idTerapeuta ))
                    {
                        MessageBox.Show("Paciente removido com sucesso!");
                    }
                    else MessageBox.Show("Paciente não foi removido com Sucesso!");
                }
            }

            catch
            {
                MessageBox.Show("BI inválido!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesquisarBI_Click_1(object sender, EventArgs e)
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

        private void FormRemoverHR_Load(object sender, EventArgs e)
        {
           
        }
    }
}
