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
    public partial class FrmAlbuns : Form
    {
        public FrmAlbuns()
        {
            InitializeComponent();
        }

        private void FrmAlbuns_Load(object sender, EventArgs e)
        {
           ImgCapa.Image = Bitmap.FromFile("D:\\Imagens\\QualquerUM.png");
           MySqlDataAdapter Gravadoras = new MySqlDataAdapter("select*from gravadoras", FrmPrincipal.Conexao);
           DataTable Dados = new DataTable();
           Gravadoras.Fill(Dados);
           CmbGravadora.DataSource = Dados;
            escolha();
        }

        private void ImgCapa_Click(object sender, EventArgs e)
        {
            ObjArquivo.ShowDialog();
            ImgCapa.Image = Bitmap.FromFile(ObjArquivo.FileName);
        }

        

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            MySqlCommand Comando = new MySqlCommand("insert into disco(dscnome, dscbanda , dscanolanc, dscgravadora) values(@nome, @banda, @ano, @gravadadora)");
            ImgCapa.Image.Save("D:\\imagens\\Capa0.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void escolha()
        {
            if(radioBanda.Checked == true)
            {
                MySqlDataAdapter Gravadoras = new MySqlDataAdapter("select*from bandas", FrmPrincipal.Conexao);
                DataTable Dados = new DataTable();
                Gravadoras.Fill(Dados);
                CMBInterprete.DataSource = Dados;
                CMBInterprete.DisplayMember = "bdsnome";
                CMBInterprete.ValueMember = "bdscodigo";
            }
            if(radioArtista.Checked == true)
            {
                MySqlDataAdapter Gravadoras = new MySqlDataAdapter("select*from artistas", FrmPrincipal.Conexao);
                DataTable Dados = new DataTable();
                Gravadoras.Fill(Dados);
                CMBInterprete.DataSource = Dados;
                CMBInterprete.DisplayMember = "artnome";
                CMBInterprete.ValueMember = "artcodigo";
            }
        }

        private void radioBanda_CheckedChanged(object sender, EventArgs e)
        {
            escolha();
        }

        private void radioArtista_CheckedChanged(object sender, EventArgs e)
        {
            escolha();
        }

        private void CMBInterprete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
