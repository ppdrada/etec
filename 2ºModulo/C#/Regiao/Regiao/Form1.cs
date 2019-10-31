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

namespace Regiao
{
    public partial class Form1 : Form
    {
        public static MySqlConnection conexao = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao.ConnectionString = "server= localhost; database=Brasil;uid=root; SSLmode=none; pwd=quarterback5";
            conexao.Open();
        }

        private void cadastrarRegiãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void cadastrarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
