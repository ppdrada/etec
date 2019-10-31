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

namespace CadastroExemplo
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string fnComando(string cInstrucao)
        {
            if (Tag == "ATORES")
            {
                switch (cInstrucao)
                {
                    case "SELECT":
                        return "SELECT ATRCODIGO Codigo, ATRNOME Ator FROM ATORES WHERE ATRNOME LIKE '%" + txtPesquisa.Text + "%'";
                        break;
                    case "INSERT":
                        return "INSERT INTO ATORES (ATRNOME) VALUES (@nome)";
                        break;
                    case "DELETE":
                        return "DELETE FROM ATORES WHERE ATRCODIGO = @codigo";
                        break;
                    case "UPDATE":
                        return "UPDATE ATORES SET ATRNOME = @nome WHERE ATRCODIGO = @codigo";
                        break;
                }
            }
            if (Tag == "GENEROS")
            {
                switch (cInstrucao)
                {
                    case "SELECT":
                        return "SELECT GNRCODIGO Codigo, GNRNOME Ator FROM GENEROS WHERE GNRNOME LIKE '%" + txtPesquisa.Text + "%'";
                        break;
                    case "INSERT":
                        return "INSERT INTO GENEROS (GNRNOME) VALUES (@nome)";
                        break;
                    case "DELETE":
                        return "DELETE FROM GENEROS WHERE GNRCODIGO = @codigo";
                        break;
                    case "UPDATE":
                        return "UPDATE GENEROS SET GNRNOME = @nome WHERE GNRCODIGO = @codigo";
                        break;
                }
            }

            if (Tag == "DIRETORES")
            {
                switch (cInstrucao)
                {
                    case "SELECT":
                        return "SELECT DRTCODIGO Codigo, DRTNOME Diretor FROM DIRETORES WHERE DRTNOME LIKE '%" + txtPesquisa.Text + "%'";
                        break;
                    case "INSERT":
                        return "INSERT INTO DIRETORES(DRTNOME) VALUES (@nome)";
                        break;
                    case "DELETE":
                        return "DELETE FROM DIRETORES WHERE DRTCODIGO = @codigo";
                        break;
                    case "UPDATE":
                        return "UPDATE DIRETORES SET DRTNOME = @nome WHERE DRTCODIGO = @codigo";
                        break;
                }
            }

            return "";
        }
        private void fnBusca()
        {
            string cSQL = fnComando("SELECT");
            MySqlDataAdapter oTabela = new MySqlDataAdapter(cSQL, frmPrincipal.oCon);
            DataTable oDados = new DataTable();

            oTabela.Fill(oDados);
            grdLista.DataSource = oDados;

        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            //DECLARAR E CRIAR A VARIAVEL QUE EXECUTARA OS COMANDOS NA BASE DE DADOS
            MySqlCommand oCmd = new MySqlCommand();

            //ASSOCIANDO A CONEXAO PRINCIPAL COM A VARIAVEL DE COMANDOS
            oCmd.Connection = frmPrincipal.oCon;
            //PREPARANDO O COMANDO QUE SERA EXECUTADO
            if (Convert.ToInt32(txtNome.Tag) == 0)
                oCmd.CommandText = fnComando("INSERT");
            else
                oCmd.CommandText = fnComando("UPDATE");

            //PREENCHE A(S) VARIAVEL(IS) EXISTENTES NA INSTRUCAO SQL
            //TODAS AS VARIAVEIS SAO INICIADAS POR "@"
            oCmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
            if (Convert.ToInt32(txtNome.Tag) != 0)
                oCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = (int)txtNome.Tag;

            //EXECUTA O COMANDO CONTRA A BASE DE DADOS
            oCmd.ExecuteNonQuery();

            txtNome.Text = "";
            txtNome.Tag = 0;
            fnBusca();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            fnBusca();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            //PEGA O VALOR DA SEGUNDA CELULA DA PRIMEIRA LINHA SELECIONADA (PODE HAVER MAIS DE UMA LINHA SELECIONADA)
            //E ATRIBUI NA PROPRIEDADE TEXT DA CAIXA DE TEXTO
            txtNome.Text = grdLista.SelectedRows[0].Cells[1].Value.ToString();
            //PEGA O VALOR DA PRIMEIRA CELULA DA PRIMEIRA LINHA SELECIONADA (PODE HAVER MAIS DE UMA LINHA SELECIONADA)
            //E ATRIBUI NA PROPRIEDADE TAG DA CAIXA DE TEXTO
            //LEMBRANDO QUE A PROPRIEDADE TAG NAO SERVE PARA BOSTA NENHUMA
            txtNome.Tag = grdLista.SelectedRows[0].Cells[0].Value;
        }

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //PEGA O VALOR DA SEGUNDA CELULA DA PRIMEIRA LINHA SELECIONADA (PODE HAVER MAIS DE UMA LINHA SELECIONADA)
            //E ATRIBUI NA PROPRIEDADE TEXT DA CAIXA DE TEXTO
            txtNome.Text = grdLista.SelectedRows[0].Cells[1].Value.ToString();
            //PEGA O VALOR DA PRIMEIRA CELULA DA PRIMEIRA LINHA SELECIONADA (PODE HAVER MAIS DE UMA LINHA SELECIONADA)
            //E ATRIBUI NA PROPRIEDADE TAG DA CAIXA DE TEXTO
            //LEMBRANDO QUE A PROPRIEDADE TAG NAO SERVE PARA BOSTA NENHUMA
            txtNome.Tag = grdLista.SelectedRows[0].Cells[0].Value;
        }

        private void cmdApagar_Click(object sender, EventArgs e)
        {
            //DECLARAR E CRIAR A VARIAVEL QUE EXECUTARA OS COMANDOS NA BASE DE DADOS
            MySqlCommand oCmd = new MySqlCommand();

            //ASSOCIANDO A CONEXAO PRINCIPAL COM A VARIAVEL DE COMANDOS
            oCmd.Connection = frmPrincipal.oCon;
            //PREPARANDO O COMANDO QUE SERA EXECUTADO
            oCmd.CommandText = fnComando("DELETE");

            //PREENCHE A(S) VARIAVEL(IS) EXISTENTES NA INSTRUCAO SQL
            //TODAS AS VARIAVEIS SAO INICIADAS POR "@"
            oCmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = grdLista.SelectedRows[0].Cells[0].Value; ;

            //EXECUTA O COMANDO CONTRA A BASE DE DADOS
            if (MessageBox.Show ("Voce realmente deseja excluir o registro selecionado?", "Confirmar operacao", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                oCmd.ExecuteNonQuery();

            txtNome.Text = "";
            txtNome.Tag = 0;
            fnBusca();

        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            fnBusca();
        }
    }
}
