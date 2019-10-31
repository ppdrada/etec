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

namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection oCon = new MySql.Data.MySqlClient.MySqlConnection("SERVER=localhost; UID=root; DATABASE=ACERVO; SSLMode=none");
            MySql.Data.MySqlClient.MySqlDataAdapter oTab = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT DSCCODIGO, DSCNOME FROM DISCOS", oCon);
            DataTable oDados = new DataTable();

            oCon.Open();
            oTab.Fill(oDados);

            cmbDisco.DataSource = oDados;
        }

        private void cmbDisco_SelectedIndexChanged(object sender, EventArgs e)
        {
            objLista.Navigate( "http://localhost/lista.php?txtDisco=" + cmbDisco.SelectedValue);
        }

        private void objLista_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
