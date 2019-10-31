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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditor janela = new FrmEditor(); //criar uma janela frmEditor
            janela.MdiParent = this; //configura pra abrir dentro do formulario atual
            janela.Show(); //mostrar o role
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditor frmEditor = new FrmEditor(); //criar uma janela frmEditor

            frmEditor.objAbrir.ShowDialog();

            for (int i = 0; i < frmEditor.objAbrir.FileNames.Length; i++)
            {
                FrmEditor janela = new FrmEditor();

                if (frmEditor.objAbrir.FileNames[i] != "") //Testa se o nome do arquivo do objAbrir é vazio.
                {
                    switch (janela.objAbrir.FilterIndex)
                    {
                        case 1:
                            janela.txtTexto.LoadFile(frmEditor.objAbrir.FileNames[i], RichTextBoxStreamType.RichText); //Abre o arquivo com caminho e nome especificado.
                            break;
                        case 2:
                            janela.txtTexto.LoadFile(frmEditor.objAbrir.FileNames[i], RichTextBoxStreamType.PlainText); //Abre o arquivo com caminho e nome especificado.
                            break;
                    }
                }

                janela.MdiParent = FrmPrincipal.ActiveForm;
                janela.Show();
            }
        }
    }
}
