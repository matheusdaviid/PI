using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código de inicialização se necessário
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ButtonEntrar.Enabled = !string.IsNullOrEmpty(TextBoxEmail.Text) &&
                                 !string.IsNullOrEmpty(TextBoxSenha.Text);
        }

        private void TextBoxSenha_TextChanged(object sender, EventArgs e)
        {
            ButtonEntrar.Enabled = !string.IsNullOrEmpty(TextBoxEmail.Text) &&
                                 !string.IsNullOrEmpty(TextBoxSenha.Text);
        }

        private void GroupBoxLogin_Enter(object sender, EventArgs e)
        {
            // Evento de entrada no GroupBox
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string senha = TextBoxSenha.Text;

            // Credenciais fixas para admin
            if (email == "admin" && senha == "123456")
            {
                TelaMenu menu = new TelaMenu();
                menu.Show();
                this.Hide();
                return;
            }

            string connectionString = "Server=localhost;Database=db_flowteams;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id FROM tb_cadastro WHERE email = @Email AND senha = @Senha";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        TelaMenu menu = new TelaMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos!", "Erro de Login",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message,
                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}