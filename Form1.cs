using ProjetoPFinal;
using System;
using System.Windows.Forms;

namespace ProjetoPFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este é um exemplo simples para validação do login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Definir credenciais de exemplo
            string usuario = "admin";
            string senha = "12345";

            // Pegar o texto inserido pelo usuário
            string email = usuario;
            string senhaUsuario = senha;

            // Validar login
            if (email == usuario && senhaUsuario == senha)
            {
                // Se o login for bem-sucedido, abre o MenuPrincipal
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();  // Abre o MenuPrincipal
                this.Hide();  // Esconde a tela de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão de cadastro, que abre a tela de cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.Show();  // Abre a tela de cadastro
            this.Hide();  // Esconde a tela de login
        }
    }
}
