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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM FORNECEDORES", Form1.connection);
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            cmbFornecedor.DataSource = dados;

            adapter = new MySqlDataAdapter("SELECT * FROM CATEGORIAS", Form1.connection);
            dados = new DataTable();
            adapter.Fill(dados);
            cmbcategoria.DataSource = dados;
        }
    }
}
