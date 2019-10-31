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
    public partial class Form1 : Form
    {

        public static SqlConnection oCon = new SqlConnection();
        public static int nNivel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CONECTA NA BASE DE DADOS
            oCon.ConnectionString = "data source=localhost; initial catalog=Seguranca; user id=sa; password=1234";
            oCon.Open();

            if (new frmLogin().ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void janela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nNivel < 2)
                new Form2().Show();
            else
                MessageBox.Show("Você não possui permissão para acessar esta tela");
        }

        private void janela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nNivel < 2)
                new Form3().Show();
            else
                MessageBox.Show("Você não possui permissão para acessar esta tela");

        }

        private void janela3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nNivel < 4)
                new Form4().Show();
            else
                MessageBox.Show("Você não possui permissão para acessar esta tela");

        }
    }
}
