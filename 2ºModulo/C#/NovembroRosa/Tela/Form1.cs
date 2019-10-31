using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class frmJanela : Form
    {
        public frmJanela()
        {
            InitializeComponent();
        }

        private void frmJanela_Load(object sender, EventArgs e)
        {

        }

        private void alteraImagem(object sender, EventArgs e)
        {
            btnIncluir.Image = null;
            btnListar.Image = null;
            btnSair.Image = null;

            ((Button)sender).Image = Tela.Properties.Resources.retanglo;
        }
    }
}
