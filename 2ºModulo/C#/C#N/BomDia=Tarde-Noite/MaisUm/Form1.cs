using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisUm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fnMensagem(string nValor)
        {
            if (nValor == "A" || nValor == "a")
            {
                return "Bom Dia";

            }
            if (nValor == "B" ||  nValor == "b")
            {
                return "Boa Tarde";
            }
            if (nValor == "D" || nValor == "d")
            {
                return "Boa Noite";
            }

            return "Já é madrugada?";
        }

        private void cmdTestar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fnMensagem(textOpcao.Text)); 

        }
    }
}
