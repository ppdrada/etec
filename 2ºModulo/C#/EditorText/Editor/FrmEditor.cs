using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FrmEditor : Form
    {
        public FrmEditor()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objSalvar.ShowDialog();

            if (objSalvar.FileName != "") //Testa se o nome do arquivo do objSalvar é vazio.
            {
                txtTexto.SaveFile(objSalvar.FileName); //Salva o arquivo com caminho e nome especificado.
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objAbrir.ShowDialog();

            for (int i = 0; i < objAbrir.FileNames.Length; i++)
            {
                FrmEditor janela = new FrmEditor();

                if (objAbrir.FileNames[i] != "") //Testa se o nome do arquivo do objAbrir é vazio.
                {
                    switch (objAbrir.FilterIndex)
                    {
                        case 1:
                            janela.txtTexto.LoadFile(objAbrir.FileNames[i], RichTextBoxStreamType.RichText); //Abre o arquivo com caminho e nome especificado.
                            break;
                        case 2:
                            janela.txtTexto.LoadFile(objAbrir.FileNames[i], RichTextBoxStreamType.PlainText); //Abre o arquivo com caminho e nome especificado.
                            break;
                    }
                }

                janela.MdiParent = FrmPrincipal.ActiveForm;
                janela.Show();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Fecha o formulario atual.
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Fecha a aplicação inteira.
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tenta recortar o texto
            try
            {
                Clipboard.SetText(txtTexto.SelectedText); //Move o texto selecionado para a area de transferencia.
                txtTexto.SelectedText = ""; //Apaga o texto selecionado.
            }
            catch(Exception erro)
            {
                //caso não consiga (Fazer nada)
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Clipboard.SetText(txtTexto.SelectedText); //Move o texto selecionado para a area de transferencia.
            }
            catch (Exception erro)
            {
                //fazer nada
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.SelectedText = Clipboard.GetText(); //Copia o texto da area de transferencia para a area selecionada.
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.SelectAll(); //Seleciona todo o texto dentro do objeto txtTexto.
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objFonte.ShowDialog();
            txtTexto.SelectionFont = objFonte.Font; 
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objColor.ShowDialog();
            txtTexto.SelectionColor = objColor.Color;
        }
    }
}
