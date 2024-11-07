namespace ProjetoPFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usuario = new TextBox();
            senha = new TextBox();
            btnLogin = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 112);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 187);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // usuario
            // 
            usuario.Location = new Point(313, 146);
            usuario.Name = "usuario";
            usuario.Size = new Size(150, 31);
            usuario.TabIndex = 2;
            // 
            // senha
            // 
            senha.Location = new Point(315, 229);
            senha.Name = "senha";
            senha.Size = new Size(150, 31);
            senha.TabIndex = 3;
            senha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(327, 303);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(327, 375);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 34);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar Funcionário";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLogin);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usuario;
        private TextBox senha;
        private Button btnLogin;
        private Button btnCadastrar;
    }
}
