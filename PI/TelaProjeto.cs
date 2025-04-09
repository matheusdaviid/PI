using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI
{
    public partial class TelaProjeto : Form
    {
        public TelaProjeto()
        {
            InitializeComponent();
        }

        private void TelaProjeto_Load(object sender, EventArgs e)
        {
            // Código de inicialização se necessário
        }

        private void DataGridViewProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento de clique na célula
        }

        private void ButtonListarProjetos_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=db_flowteams;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT p.id, c.email AS 'Usuário', p.titulo, 
                                   p.data_inicio, p.data_termino, p.descricao, p.status 
                                   FROM tb_projetos p
                                   INNER JOIN tb_cadastro c ON p.id_usuario = c.id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataGridViewProjetos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar projetos: " + ex.Message,
                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            TelaMenu menu = new TelaMenu();
            menu.Show();
            this.Hide();
        }
    }
}