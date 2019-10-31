using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficu
{
    public partial class FrmPrincipal : Form
    {
        int nX, nY;
        Graphics oTela;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objTela.Image = new Bitmap(objTela.Width, objTela.Height);
            oTela = Graphics.FromImage(objTela.Image);
        }

        private void fnConcluir(object sender, MouseEventArgs e)
        {
            int iX, iY;

            if(e.X < nX)
            {
                iX = e.X;
            }
            else
            {
                iX = nX;
            }

            if(e.Y < nY)
            {
                iY = e.Y;
            }
            else
            {
                iY = nY;
            }

            if (radFundo.Checked || radCompleto.Checked)
            {
                if (radRetangulo.Checked)
                {
                    oTela.FillRectangle(new SolidBrush(pnlFundo.BackColor), iX, iY, Math.Abs(e.X - nX), Math.Abs(e.Y - nY));
                }

                if (radCirculo.Checked)
                {
                    oTela.FillEllipse(new SolidBrush(pnlFundo.BackColor), iX, iY, Math.Abs(e.X - nX), Math.Abs(e.Y - nY));
                }
            }

            if (radContorno.Checked || radCompleto.Checked)
            {
                if (radRetangulo.Checked)
                {
                    oTela.DrawRectangle(new Pen(pnlCor.BackColor, (float)nmEspessura.Value), iX, iY, Math.Abs(e.X - nX), Math.Abs(e.Y - nY));
                }

                if (radCirculo.Checked)
                {
                    oTela.DrawEllipse(new Pen(pnlCor.BackColor, (float)nmEspessura.Value), iX, iY, Math.Abs(e.X - nX), Math.Abs(e.Y - nY));
                }  
            }

            if (radLinha.Checked)
            {
                oTela.DrawLine(new Pen(pnlCor.BackColor, (float)nmEspessura.Value), nX, nY, e.X, e.Y);
            }

            objTela.Refresh();
        }

        private void fnIniciar(object sender, MouseEventArgs e)
        {
            nX = e.X;
            nY = e.Y;
        }

        private void click_novo(object sender, EventArgs e)
        {
            objTela.Image = new Bitmap(objTela.Width, objTela.Height);
            oTela = Graphics.FromImage(objTela.Image);
        }

        private void click_abrir(object sender, EventArgs e)
        {
            objAbrir.ShowDialog();

            if (objAbrir.FileName != "")
            {
                objTela.Load(objAbrir.FileName);
                oTela = Graphics.FromImage(objTela.Image);
            }
        }

        private void click_salvar(object sender, EventArgs e)
        {
            objSalvar.ShowDialog();

            if (objSalvar.FileName != "")
            {
                objTela.Image.Save(objSalvar.FileName);
            }
        }

        private void selecionarCor(object sender, EventArgs e)
        {
            objCor.ShowDialog();
            ((Panel)sender).BackColor = objCor.Color;
        }
    }
}
