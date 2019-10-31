using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroRegioes
{
    public partial class frmGraficu : Form
    {
        public frmGraficu()
        {
            InitializeComponent();
        }

        private void frmGraficu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://localhost/re1.php?regiao=numero");
        }
    }
}
