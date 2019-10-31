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

namespace Play
{
    public partial class frmPrincipal : Form
    {

        public static MySqlConnection conexao = new MySqlConnection("server=localhost;database=play;uid=root;sslmode=none");

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            conexao.Open();
            MessageBox.Show("Abrir");
        }

        private void btnAlbuns_Click(object sender, EventArgs e)
        {
            new frmAlbuns().ShowDialog();
        }
    }
}
