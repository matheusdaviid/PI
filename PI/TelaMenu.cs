using System;
using System.Windows.Forms;

namespace PI
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            // Código de inicialização se necessário
        }

        private void buttonConsultarUsuario_Click(object sender, EventArgs e)
        {
            TelaUsuario telaUsuario = new TelaUsuario();
            telaUsuario.Show();
            this.Hide();
        }

        private void buttonConsultarProjetos_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
            this.Hide();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}