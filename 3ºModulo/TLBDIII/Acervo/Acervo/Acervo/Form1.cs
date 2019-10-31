using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Acervo
{
    public partial class FrmPrincipal : Form
    {
        public static MySqlConnection Conexao = new MySqlConnection("server=localhost;database=play;uid=root;sslmode=none");
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Conexao.Open();
            MessageBox.Show("Abriu");
        }

        
        private void álbunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAlbuns().ShowDialog();
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmArtistas().ShowDialog();
        }

        private void bandaGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBandas().ShowDialog();
        }

        private void gravadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGravadora().ShowDialog();
        }

        private void musicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMusicas().ShowDialog();
        }

        private void interpretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmIntegrantes().ShowDialog();
        }
    }
}
