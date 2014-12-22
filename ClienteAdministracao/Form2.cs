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
    public partial class Form2 : Form
    {
        private String token;
        public Form2()
        {
            InitializeComponent();
            token = ClienteAdministracao.Properties.Settings.Default.token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(token);
        }
    }
}
