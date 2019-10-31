using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor;
        char opcao;

        public Form1()
        {
            InitializeComponent();
        }

        private void exibir(object sender, EventArgs e) //numeros
        {
            if (Convert.ToBoolean(txtValor.tag))
            {
                txtvalor.Text += ((Button)sender).Text; 
            }
            else
            {
                txtValor.Text = ((Button)sender).Text;
            }
            txtValor.tag = true;
        }
        private void operacao(object sender, EventArgs e) //operações
        {
           valor = Convert.ToDouble(textvalor.Text);
           opcao = ((Button)sender).Text[0];
            textvalor.Tag = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textvalor.Text = Convert.ToString(valor + Convert.ToDouble(textvalor.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValor.Tag = true;
        }

        private void mostrar(object sender, EventArgs e)
        {
            if ((bool)textvalor.Tag)
            {
                textvalor.Text += ((Button)sender).Text;
            }
            else {
                textvalor.Text = ((Button)sender).Text;
            }
            textvalor.Tag = true;
        }
    }
}
