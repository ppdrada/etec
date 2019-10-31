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

namespace cadastroRegioes
{
    public partial class frmListarCidades : Form
    {
        public frmListarCidades()
        {
            InitializeComponent();
        }
        private void ListarCidades_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter oTab = new MySqlDataAdapter("Select cid_cod Codigo, cid_nome Nome,cid_estado Estado, cid_populacao Populacao , cid_capital Capital" +
                " from cidade where cid_estado = '" + frmcadastroCidade.Estado + "' order by 5 desc", Form1.conexao);
            DataTable oDados = new DataTable();
            oTab.Fill(oDados);
            dtCidade.DataSource = oDados;
        }
    }
}
