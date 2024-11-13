namespace ProjetoPFinal
{
    partial class CadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            dtpDataAdmissao = new DateTimePicker();
            cbFuncao = new ComboBox();
            btnCadastrof = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 185);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 282);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 355);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 4;
            label5.Text = "Data de Admissão";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(540, 32);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 5;
            label6.Text = "Função";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 31);
            txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(70, 213);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(295, 31);
            txtSenha.TabIndex = 8;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(65, 310);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(300, 31);
            dtpDataNascimento.TabIndex = 9;
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Location = new Point(65, 383);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(300, 31);
            dtpDataAdmissao.TabIndex = 10;
            // 
            // cbFuncao
            // 
            cbFuncao.FormattingEnabled = true;
            cbFuncao.Location = new Point(540, 70);
            cbFuncao.Name = "cbFuncao";
            cbFuncao.Size = new Size(182, 33);
            cbFuncao.TabIndex = 11;
            // 
            // btnCadastrof
            // 
            btnCadastrof.Location = new Point(512, 385);
            btnCadastrof.Name = "btnCadastrof";
            btnCadastrof.Size = new Size(112, 34);
            btnCadastrof.TabIndex = 12;
            btnCadastrof.Text = "Cadastrar";
            btnCadastrof.UseVisualStyleBackColor = true;
            btnCadastrof.Click += btnCadastrof_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(676, 385);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrof);
            Controls.Add(cbFuncao);
            Controls.Add(dtpDataAdmissao);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private DateTimePicker dtpDataNascimento;
        private DateTimePicker dtpDataAdmissao;
        private ComboBox cbFuncao;
        private Button btnVoltar;
        private Button btnCadastrof;
    }
}