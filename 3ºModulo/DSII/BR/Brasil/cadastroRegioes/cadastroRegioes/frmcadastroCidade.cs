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



namespace cadastroRegioes
{
    public partial class frmcadastroCidade : Form
    {
        public frmcadastroCidade()
        {
            InitializeComponent();
        }
        public static String Estado;

       

        private void frmcadastroCidade_Load(object sender, EventArgs e)
        {
            
            buscar();
            this.BackgroundImage = Image.FromFile("G:/ETEC/3 MODULO/DS/BR/Brasil/Estados/"+Estado+".jpg");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {          

            MySqlCommand MeuComando = new MySqlCommand();
            MeuComando.CommandText = "insert into cidade(CID_NOME, CID_POPULACAO, cid_capital)" +
                "values (@cidade, @populacao)";

            MeuComando.Connection = Form1.conexao;

            MeuComando.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtcidade.Text;
            MeuComando.Parameters.Add("@populacao", MySqlDbType.Int32).Value = nudPopulacao.Value;
            MeuComando.Parameters.Add("@capital", MySqlDbType.Bit).Value = ckbCapital.Checked;


            MeuComando.ExecuteNonQuery();
            buscar();
            MessageBox.Show("Cadastro Feito com sucesso!");
            
        }

        private void buscar()
        {
            MySqlDataAdapter oTab = new MySqlDataAdapter("Select cid_cod Codigo, cid_nome Nome,cid_estado Estado, cid_populacao Populacao , cid_capital Capital"+
                " from cidade where cid_estado = '" + Estado +"' order by 5 desc", Form1.conexao);
            DataTable oDados = new DataTable();
            oTab.Fill(oDados);
            dtCidade.DataSource = oDados;
        }

        private void dtCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcidade.Tag = dtCidade.SelectedRows[0].Cells[0].Value.ToString();
            txtcidade.Text = dtCidade.SelectedRows[0].Cells[1].Value.ToString();
            nudPopulacao.Value = Convert.ToInt64(dtCidade.SelectedRows[0].Cells[3].Value);
            ckbCapital.Checked = Convert.ToBoolean(dtCidade.SelectedRows[0].Cells[4].Value);
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Realmente Excluir esses Dados", "Deletar", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes){
            MySqlCommand MeuComando = new MySqlCommand();
            MeuComando.CommandText = "delete from cidade where cid_cod = "+ txtcidade.Tag;

            MeuComando.Connection = Form1.conexao;
            MeuComando.ExecuteNonQuery();
            buscar();
            MessageBox.Show("Exclusão Feita com sucesso!");
            }
            else{

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand MeuComando = new MySqlCommand();
            MeuComando.CommandText = "update cidade set cid_nome = @cidade, cid_populacao = @populacao , cid_capital = @capital  where cid_cod = " + txtcidade.Tag;

            MeuComando.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = txtcidade.Text;
            MeuComando.Parameters.Add("@populacao", MySqlDbType.Int32).Value = nudPopulacao.Value;
            MeuComando.Parameters.Add("@capital", MySqlDbType.Bit).Value = ckbCapital.Checked;


            MeuComando.Connection = Form1.conexao;
            MeuComando.ExecuteNonQuery();
            buscar();
            MessageBox.Show("Alteração Feita com sucesso!");
        }
    }
}
