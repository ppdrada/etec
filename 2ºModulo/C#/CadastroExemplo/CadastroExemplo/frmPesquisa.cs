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


namespace CadastroExemplo
{
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter oTab = new MySqlDataAdapter("SELECT FLMCODIGO, FLMNOME Filme, DRTNOME Diretor FROM FILMES INNER JOIN DIRETORES ON DRTCODIGO = FLMDIRETOR", frmPrincipal.oCon);
            DataTable oDados = new DataTable();

            oTab.Fill(oDados);
            grdLista.DataSource = oDados;
            grdLista.Columns[0].Width = 0;
        }

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdLista.SelectedRows.Count >0)
            {
                Tag = grdLista.SelectedRows[0].Cells[0].Value;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
