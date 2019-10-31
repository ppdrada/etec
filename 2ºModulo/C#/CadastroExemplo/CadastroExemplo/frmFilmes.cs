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
    public partial class frmFilmes : Form
    {
        public frmFilmes()
        {
            InitializeComponent();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            MySqlCommand oFilme = new MySqlCommand();
            int nCodFilme;

            oFilme.Connection = frmPrincipal.oCon;
            oFilme.CommandText = "INSERT INTO FILMES (FLMNOME, FLMORIGINAL, FLMSINOPSE, FLMDIRETOR) VALUES (@nome, @nomeorig, @sinopse, @diretor)";
            oFilme.Transaction = frmPrincipal.oCon.BeginTransaction();

            oFilme.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
            oFilme.Parameters.Add("@nomeorig", MySqlDbType.VarChar).Value = txtOriginal.Text;
            oFilme.Parameters.Add("@sinopse", MySqlDbType.Text).Value = txtSinopse.Text;
            oFilme.Parameters.Add("@diretor", MySqlDbType.Int32).Value = cmbDiretor.SelectedValue;

            oFilme.ExecuteNonQuery();

            //OBTEM O ULTIMO CODIGO INSERIDO
            nCodFilme = (int)oFilme.LastInsertedId;

            /*
             * CUIDADO!!!
             * 
             * ESTE TRECHO FOI O QUE FIZ PARA DEMONSTRACAO!!!
             * ELE GRAVA APENAS UM GENERO.
             * UTILIZE-O COMO REFERENCIA
             * VEJA NO BLOCO ABAIXO COMO LER MAIS DE UM ITEM SELECIONADO E GRAVAR NA TABELA
             * 
            oFilme = new MySqlCommand();
            oFilme.Connection = frmPrincipal.oCon;
            oFilme.CommandText = "INSERT INTO GENEROS_FILMES (GFLFILME, GFLGENERO) VALUES (@filme, @genero)";

            oFilme.Parameters.Add("@filme", MySqlDbType.Int32).Value = 2;
            oFilme.Parameters.Add("@genero", MySqlDbType.Int32).Value = lstGenero.SelectedValue;

            oFilme.ExecuteNonQuery();*/

            //ESTE TRECHO E' O MESMO ACIMA, MAS CONSIDERANDO
            // A: O ULTIMO CODIGO DE FILME CRIADO
            // B: TODOS OS GENEROS SELECIONADOS

            oFilme.Parameters.Remove("@nome");
            oFilme.Parameters.Remove("@nomeorig");
            oFilme.Parameters.Remove("@sinopse");
            oFilme.Parameters.Remove("@diretor");

            oFilme.CommandText = "INSERT INTO GENEROS_FILMES (GFLFILME, GFLGENERO) VALUES (@filme, @genero)";

            oFilme.Parameters.Add("@filme", MySqlDbType.Int32).Value = nCodFilme;
            oFilme.Parameters.Add("@genero", MySqlDbType.Int32);

            foreach (DataRowView oSelecao in lstGenero.SelectedItems)
            {
                oFilme.Parameters["@genero"].Value = oSelecao["GNRCODIGO"];
                oFilme.ExecuteNonQuery();
            }

            oFilme.Parameters.Remove("@filme");
            oFilme.Parameters.Remove("@genero");

            oFilme.CommandText = "INSERT INTO ATORES_FILMES (AFLFILME, AFLATOR) VALUES (@filme, @ator)";

            oFilme.Parameters.Add("@filme", MySqlDbType.Int32).Value = nCodFilme;
            oFilme.Parameters.Add("@ator", MySqlDbType.Int32);

            foreach(DataRowView oSelecao in lstAtor.SelectedItems)
            {
                oFilme.Parameters["@ator"].Value = oSelecao["ATRCODIGO"];
                oFilme.ExecuteNonQuery();
            }
        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
            //PREENCHE A LISTA DE DIRETORES
            MySqlDataAdapter oDiret = new MySqlDataAdapter("SELECT DRTCODIGO, DRTNOME FROM DIRETORES", frmPrincipal.oCon);
            DataTable oDiretores = new DataTable();

            //NAO ESQUECA DE PREENCHER AS PROPRIEDADES DISPLAYMEMBER / VALUEMEMBER
            oDiret.Fill(oDiretores);
            cmbDiretor.DataSource = oDiretores;

            //REPETE O MESMO TRECHO, MAS AGORA PARA CARREGAR OS GENEROS
            MySqlDataAdapter oGener = new MySqlDataAdapter("SELECT GNRCODIGO, GNRNOME FROM GENEROS", frmPrincipal.oCon);
            DataTable oGeneros = new DataTable();

            oGener.Fill(oGeneros);
            lstGenero.DataSource = oGeneros;

            //PREENCHE A LISTA DE ATORES
            MySqlDataAdapter oAtor = new MySqlDataAdapter("SELECT ATRCODIGO, ATRNOME FROM ATORES", frmPrincipal.oCon);
            DataTable oAtores = new DataTable();

            oAtor.Fill(oAtores);
            lstAtor.DataSource = oAtores;
        }
    }
}
