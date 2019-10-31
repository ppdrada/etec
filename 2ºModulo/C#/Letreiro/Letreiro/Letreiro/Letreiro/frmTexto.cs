using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letreiro
{
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
        }

        private void cmdDefinir_Click(object sender, EventArgs e)
        {
            frmLetreiro.cTexto = txtTexto.Text;
            Close();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
