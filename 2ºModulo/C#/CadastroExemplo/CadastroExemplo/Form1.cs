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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //VARIAVEL DE CONEXAO
        //DECLARADA COMO PUBLICA PARA ACESSAR DOS DEMAIS FORMULARIOS
        public static MySqlConnection oCon = new MySqlConnection();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //IMAGEM DE FUNDO
            BackgroundImage = new Bitmap(Width, Height);
            Graphics oBorda = Graphics.FromImage(BackgroundImage);

            oBorda.DrawRectangle(new Pen(Color.Black, 60), -25, 0, Width + 50, Height +25);

            //DEFINE OS PARAMETROS DE CONEXAO
            //SERVIDOR, BANCO DE DADOS, USUARIO, SENHA (SE TIVER), MODO SEGURANCA
            oCon.ConnectionString = "SERVER=localhost; DATABASE=FILMES; UID=root; PWD=1234; SSLMode=none";
            //ABRE A CONEXAO COM A BASE DE DADOS
            oCon.Open();
        }

        private void cmdAtores_Click(object sender, EventArgs e)
        {
            //CHAMANDO FORMULARIO DE CADASTRO
            frmCadastro oTela = new frmCadastro();
            oTela.Tag = "ATORES";
            oTela.Show();
        }

        private void cmdGenero_Click(object sender, EventArgs e)
        {

            frmCadastro oTela = new frmCadastro();
            oTela.Tag = "GENEROS";
            oTela.Show();
        }

        private void cmdDiretor_Click(object sender, EventArgs e)
        {
            frmCadastro oTela = new frmCadastro();
            oTela.Tag = "DIRETORES";
            oTela.Show();

        }

        private void cmdFilme_Click(object sender, EventArgs e)
        {
            new frmFilmes().Show();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
