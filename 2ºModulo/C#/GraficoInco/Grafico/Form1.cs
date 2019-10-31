using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        int nPosx, nPosy;
        Graphics oImg;

        private void fnTerminar(object sender, MouseEventArgs e)
        {
            if (radQuadrado.Checked)
            {
                if (radCompleto.Checked || radFundo.Checked)
                {
                    oImg.DrawRectangle(new Pen(pnlCor.BackColor, 5), nPosx, nPosy, e.X - nPosx, e.Y - nPosy);
                }
                if (radCompleto.Checked || radContorno.Checked)
                {
                    oImg.FillRectangle(new SolidBrush(pnlCor.BackColor), nPosx, nPosy, e.X - nPosx, e.Y - nPosy);
                }
            }
            else
            {
                if (radCompleto.Checked || radFundo.Checked) 
                { 
                oImg.DrawEllipse(new Pen(pnlCor.BackColor, 5), nPosx, nPosy, e.X - nPosx, e.Y - nPosy);//Cria circulo.
                }
                if (radCompleto.Checked || radContorno.Checked)
                {
                    oImg.FillEllipse(new SolidBrush(pnlFundo.BackColor), nPosx, nPosy, e.X - nPosx, e.Y - nPosy);
                }
            }


            objTela.Refresh();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            objTela.Image = new Bitmap(objTela.Width, objTela.Height);
            oImg = Graphics.FromImage(objTela.Image);
        }

        private void fnIniciar(object sender, MouseEventArgs e)
        {
            nPosx = e.X;
            nPosy = e.Y;
        }

        private void fnSeleciona_Cor(object sender, EventArgs e)
        {
            objCor.ShowDialog();
            ((Panel)sender).BackColor = objCor.Color;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFundo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {
            oImg = Graphics.FromImage(objTela.Image);
            oImg.Clear(objTela.BackColor);
            Refresh();
            Show();
        }
        private void abrir_Click(object sender, EventArgs e)
        {
            objAbrir.ShowDialog();
            if (objAbrir.FileName != "")
            {
             Bitmap.FromFile(objAbrir.FileName);
            }
        }
        private void salvar_Click(object sender, EventArgs e)
        {
            objSalvar.ShowDialog();
            if (objSalvar.FileName != "")
            {
                objTela.Image.Save(objSalvar.FileName);
            } 
        }

        private void objTela_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
