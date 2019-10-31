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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void cadastrar(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO FORNECEDORES (FRN_NOME) VALUES (@nome)", Form1.connection);
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtnome.Text;
            command.ExecuteNonQuery();

            txtnome.Text = "";
            fnPreencher();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            fnPreencher();
        }

        private void fnPreencher()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM FORNECEDORES ORDER BY FRN_CODIGO DESC", Form1.connection);
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            dtFornecedores.DataSource = dados;
        }
    }
}
