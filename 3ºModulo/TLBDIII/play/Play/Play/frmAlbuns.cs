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

namespace Play
{
    public partial class frmAlbuns : Form
    {
        public frmAlbuns()
        {
            InitializeComponent();
        }

        private void frmAlbuns_Load(object sender, EventArgs e)
        {
           imgCapa.Image = Bitmap.FromFile("D:\\imagens\\noimage.png");
           MySqlDataAdapter gravadora = new MySqlDataAdapter("select * from gravadoras", frmPrincipal.conexao);



            DataTable dados = new DataTable();
           gravadora.Fill(dados);
           cmbGravadora.DataSource = dados;


        }

        private void imgCapa_Click(object sender, EventArgs e)
        {
           
           objArquivo.ShowDialog();
           imgCapa.Image = Bitmap.FromFile(objArquivo.FileName);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
           // MySqlCommand command = new MySqlCommand("INSERT INTO disco (dscnome, dscbanda , dscanolanc, dscgravadora) VALUES (@disco)", frmPrincipal.conexao);
           

            //command.ExecuteNonQuery();
            imgCapa.Image.Save("D:\\imagens\\capa0.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void radioBanda_CheckedChanged(object sender, EventArgs e)
        {
            string cSql = radioBanda.Checked ? " SELECT BDSCODIGO CODIGO BDSNOME NOME BANDAS" : "SELECT CODIGO CODIGO NOME NOME ARTISTA";

            MySqlDataAdapter lista = new MySqlDataAdapter("select * from gravadoras", frmPrincipal.conexao);

            DataTable dados = new DataTable();
            lista.Fill(dados);
            cmbGravadora.DataSource = dados;
        }
    }
}
