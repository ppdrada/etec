using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LOGIN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //CRIA VARIAVEL PARA EXECUTAR COMANDOS
            SqlCommand oPesquisa = new SqlCommand();

            //QUAL O BANCO QUE EU QUERO EXECUTAR O COMANDO?
            oPesquisa.Connection = Form1.oCon;
            //QUAL O COMANDO QUE VOU EXECUTAR?
            oPesquisa.CommandText = "SELECT USRNIVEL FROM USUARIOS WHERE '" + txtNome.Text + "' IN (USRLOGIN, USREMAIL) AND USRSENHA = '" + txtSenha.Text + "'"; 

            //EXECUTA O COMANDO NA BASE DE DADOS
            if (oPesquisa.ExecuteScalar() == null)
                MessageBox.Show("Usuário ou senha inválidos");
            else
            {
                Form1.nNivel = (int) oPesquisa.ExecuteScalar();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
