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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void cadastrar(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO CATEGORIAS (CTG_DESCRICAO) VALUES (@desc)", Form1.connection);
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txtdesc.Text;
            command.ExecuteNonQuery();

            txtdesc.Text = "";
            fnPreencher();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            fnPreencher();
        }

        private void fnPreencher()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CATEGORIAS ORDER BY CTG_CODIGO DESC", Form1.connection);
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            dtCategorias.DataSource = dados;
        }
    }
}
