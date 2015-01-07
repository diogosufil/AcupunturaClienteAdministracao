using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAdministracao
{
    public partial class FormHumanRes : Form
    {
        FormAdicionarHR adicionar = new FormAdicionarHR();
        FormEditarHR editar = new FormEditarHR();
        FormRemoverHR remover = new FormRemoverHR();

        public FormHumanRes()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            remover.ShowDialog();
        }
    }
}
