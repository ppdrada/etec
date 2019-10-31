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

namespace Mercado
{
    public partial class Form1 : Form
    {
        public static MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=mercado;uid=root;sslmode=none";
            connection.Open();
            new Produtos().ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Categorias().ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fornecedores().ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
