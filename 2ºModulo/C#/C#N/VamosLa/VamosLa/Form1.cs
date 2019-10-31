using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VamosLa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minhafuncao(object sender, EventArgs e) // Tipos server para intentifivar o que vai na variavel
        {

            MessageBox.Show(((Button)sender).Text);
        }

        private void segundafuncao(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Button.ToString());

        }
    }
}
