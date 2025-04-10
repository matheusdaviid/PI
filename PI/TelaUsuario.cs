using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            // Código de inicialização se necessário
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento de clique na célula
        }

        private void buttonListarUsuarios_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=srv724.hstgr.io;Database=u857606359_db_flowteams;Uid=u857606359_david;Pwd=FlowTeams123;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, email FROM tb_cadastro";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewUsuarios.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuários: " + ex.Message,
                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            TelaMenu menu = new TelaMenu();
            menu.Show();
            this.Hide();
        }
    }
}