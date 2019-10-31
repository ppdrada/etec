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

namespace Acervo
{
    public partial class FrmIntegrantes : Form
    {
        public FrmIntegrantes()
        {
            InitializeComponent();
        }

        private void cmbBandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstArtitas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmIntegrantes_Load(object sender, EventArgs e)
        {
            art();
            banda();
        }

        private void art()
        {
            MySqlDataAdapter Gravadoras = new MySqlDataAdapter("select*from artistas", FrmPrincipal.Conexao);
            DataTable Dados = new DataTable();
            Gravadoras.Fill(Dados);
            lstArtitas.DataSource = Dados;
            lstArtitas.DisplayMember = "artnome";
            lstArtitas.ValueMember = "artcodigo";
        }
        private void banda()
        {
            MySqlDataAdapter Gravadoras = new MySqlDataAdapter("select*from bandas", FrmPrincipal.Conexao);
            DataTable Dados = new DataTable();
            Gravadoras.Fill(Dados);
            cmbBandas.DataSource = Dados;
            cmbBandas.DisplayMember = "bdsnome";
            cmbBandas.ValueMember = "bdscodigo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand();
            com.Connection = FrmPrincipal.Conexao;
            com.Transaction = FrmPrincipal.Conexao.BeginTransaction();
            com.CommandText = "insert into integrantes(itgbanda,itgartista) values(@banda, @artista)";

            com.Parameters.Add("@banda", MySqlDbType.Int32).Value = cmbBandas.SelectedValue;
            com.Parameters.Add("@artista", MySqlDbType.Int32);
            foreach (System.Data.DataRowView oSel in lstArtitas.SelectedItems) {
                com.Parameters["@artista"].Value = oSel[0];
            }
            com.Transaction.Commit();
            com.ExecuteNonQuery();
 


        }
    }
}
