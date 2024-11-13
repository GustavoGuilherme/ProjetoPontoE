using ProjetoPFinal;
using System;
using System.Windows.Forms;

namespace ProjetoPFinal
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

       
        private void btnCadastrof_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;
            DateTime dataAdmissao = dtpDataAdmissao.Value;
            string funcao = cbFuncao.SelectedItem?.ToString() ?? "Não definido";

            // Validação se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(funcao))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Caso esteja tudo funcionando;
            MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar campos após o cadastro
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDataNascimento.Value = DateTime.Today;
            dtpDataAdmissao.Value = DateTime.Today;
            cbFuncao.SelectedIndex = -1;
        }

        // Botão para voltar para a tela de Login
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Abrir a tela de login e fechar o formulário de cadastro
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        }
    }

