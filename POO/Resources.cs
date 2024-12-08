using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POO
{
    public partial class Resources : Form
    {
        private string connectionString = "Data Source=PT-DSI-HC1\\SQLEXPRESS;Initial Catalog=POO_CivilProtection;Integrated Security=True";

        public Resources()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        // Método para carregar os dados no DataGridView
        private void CarregarDados()
        {
            try
            {
                // Cria a conexão com o banco
                using (SqlCo conexao = new SqlConnection(connectionString))
                {
                    // Consulta SQL que você deseja executar
                    string query = "SELECT * FROM NomeDaTabela";

                    // Cria o comando SQL
                    SqlCommand comando = new SqlCommand(query, conexao);

                    // Abre a conexão
                    conexao.Open();

                    // DataAdapter para preencher o DataGridView
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    // DataTable para armazenar os dados
                    DataTable tabela = new DataTable();

                    // Preenche a DataTable com os dados da consulta
                    adaptador.Fill(tabela);

                    // Exibe os dados no DataGridView
                    dataGridView1.DataSource = tabela;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        // Evento do botão para carregar os dados
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
