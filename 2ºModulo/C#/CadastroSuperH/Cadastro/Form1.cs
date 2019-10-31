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

namespace Cadastro
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao = new MySqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            conexao.ConnectionString = "database=cadastro; server=localhost; uid=root; SSLmode=none; pwd=quarterback5";
            conexao.Open();

            MySqlCommand MeuComando = new MySqlCommand();
            MeuComando.CommandText = "insert into cadastrar(numInden, nome, idade, identidade, poder, localiza)" +
                "values (@numInden, @nome, @idade, @identidade, @poder, @localiza);";

            MeuComando.Connection = conexao;

            MeuComando.Parameters.Add("@numIndent", MySqlDbType.VarChar).Value = txtNumIndent.Text;
            MeuComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
            MeuComando.Parameters.Add("@idade", MySqlDbType.Int64).Value = txtIdade.Text;
            MeuComando.Parameters.Add("@identidade", MySqlDbType.VarChar).Value = txtIdentidade.Text;
            MeuComando.Parameters.Add("@poder", MySqlDbType.VarChar).Value = txtPoder.Text;
            MeuComando.Parameters.Add("@localiza", MySqlDbType.VarChar).Value = txtLocaliza.Text;


            MeuComando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
