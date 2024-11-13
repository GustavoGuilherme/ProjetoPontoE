using ProjetoPFinal;
using System;
using System.Windows.Forms;

namespace ProjetoPFinal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Evento para o botão que abre a tela de Ponto Eletrônico
        private void btnPonto_Click(object sender, EventArgs e)
        {
            // Cria e exibe a tela de Ponto Eletrônico
            PontoForm pontoForm = new PontoForm();
            pontoForm.Show();  // Exibe a tela de Ponto
            this.Hide();       // Esconde a tela atual (MenuPrincipal)
        }

        // Evento para o botão que abre a tela de Banco de Horas
        private void btnBancoHoras_Click(object sender, EventArgs e)
        {
            // Cria e exibe a tela de Banco de Horas
            Banco bancoForm = new Banco();
            bancoForm.Show();  // Exibe a tela de Banco de Horas
            this.Hide();       // Esconde a tela atual (MenuPrincipal)
        }
    }
}
