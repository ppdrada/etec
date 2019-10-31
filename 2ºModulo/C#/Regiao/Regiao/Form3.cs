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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //crinado uma cópia da tabela regiões na memória 
            MySqlDataAdapter tabela = new MySqlDataAdapter("select rgsCodigo, rgsNome from  regiao order by rgsNome", Form1.conexao);

            //criando uma variavel que vai associar a tabela com a lista
            DataTable dados = new DataTable();

            //Pegando os dados da memória e jogando 
            tabela.Fill(dados);

            // Pegando o dados e listando  
            cmbRegiao.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("insert into estados(stdUF, stdCidade,stdCapital, stdRegiao, stdPopulacao)"  +
                "valeus(@stdUF, @stdCidade, @stdCapital, @stdRegiao, @stdPopulacao)");
            comando.Parameters.Add("@stdUF", MySqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("@stdCidade", MySqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@stdCapital", MySqlDbType.VarChar).Value = txtCapital.Text;
            comando.Parameters.Add("@stdPopulacao", MySqlDbType.VarChar).Value = txtPopulacao.Text;

            comando.ExecuteNonQuery();

            
        }

        private void cmbRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
