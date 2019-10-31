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
    public partial class Form1 : Form
    {

        public static MySqlConnection conexao = new MySqlConnection("server=localhost;database=brasil;uid=root;sslmode=none");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao.Open();
        }

       
        private void MouseClick(object sender, MouseEventArgs e)
        {
            frmcadastroCidade.Estado = ((Label)sender).Tag.ToString();
            //MessageBox.Show(((Label)sender).Tag.ToString());
            // new frmcadastroCidade().ShowDialog();
            mnuOpcao.Show(this,e.Y +((Label)sender).Left, e.X+ ((Label)sender).Top);
        }

        private void sairDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exibirGráficoPopulacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGraficu().Show();
        }

        private void adiconarRemoverCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmcadastroCidade().ShowDialog();
        }

        private void listarCidadesDoEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListarCidades().ShowDialog();
        }

        
    }
}
