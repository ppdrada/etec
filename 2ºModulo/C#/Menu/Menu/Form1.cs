using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você esbarrou na opção sair", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (MessageBox.Show("Você realmente tem a total certeza que deseja mesmo fechar essa aplicação", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            new Perfil().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bum().Show();
        }
    }
}
