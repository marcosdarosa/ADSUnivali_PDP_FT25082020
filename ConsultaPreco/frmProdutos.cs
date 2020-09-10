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


namespace ConsultaPreco
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento da Descrição!"); // Valida o preenchimento do campo Descrição

                txtDescricao.Focus();

                return;
            }

            //Crio a estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "consulta_preco";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            //Realizo a conexão com o banco
            MySqlConnection abreConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                abreConexaoBD.Open(); // Inicia (abertura) conexão com o banco de dados

                MySqlCommand executacomandoMySql = abreConexaoBD.CreateCommand(); //Crio um comando SQL
                executacomandoMySql.CommandText = "INSERT INTO produto (descricaoProduto, codigobarrasProduto, unidadeMedidaProduto, aplicacaoProduto, precoProduto) " +
                    "VALUES('" + txtDescricao.Text + "', '" + txtCodBar.Text + "', '" + txtUn.Text + "', '" + txtAplicacao.Text + "', '" + mtxtPreco.Text + "')";
                executacomandoMySql.ExecuteNonQuery();

                abreConexaoBD.Close(); // Finaliza (fechamento) conexão com o banco de dados

                MessageBox.Show("Produto incluído com sucesso");

                txtDescricao.Text = "";
                txtCodBar.Text = "";
                txtUn.Text = "";
                txtAplicacao.Text = "";
                mtxtPreco.Text = "";

                txtDescricao.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel realizar a conexão com o banco de dados! ");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
