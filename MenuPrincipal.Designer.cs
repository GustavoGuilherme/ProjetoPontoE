namespace ProjetoPFinal
{
    partial class MenuPrincipal
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
            pictureBox1 = new PictureBox();
            btnPonto = new Button();
            btnBancoHoras = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconusuario;
            pictureBox1.Location = new Point(104, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(69, 271);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(179, 58);
            btnPonto.TabIndex = 1;
            btnPonto.Text = "Ponto Eletrônico";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnBancoHoras
            // 
            btnBancoHoras.Location = new Point(69, 468);
            btnBancoHoras.Name = "btnBancoHoras";
            btnBancoHoras.Size = new Size(179, 58);
            btnBancoHoras.TabIndex = 2;
            btnBancoHoras.Text = "Banco de Horas";
            btnBancoHoras.UseVisualStyleBackColor = true;
            btnBancoHoras.Click += btnBancoHoras_Click;
            // 
            // button3
            // 
            button3.Location = new Point(375, 271);
            button3.Name = "button3";
            button3.Size = new Size(179, 58);
            button3.TabIndex = 3;
            button3.Text = "Histórico de Ponto";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(375, 468);
            button4.Name = "button4";
            button4.Size = new Size(179, 58);
            button4.TabIndex = 4;
            button4.Text = "Funcionários";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(690, 271);
            button5.Name = "button5";
            button5.Size = new Size(179, 58);
            button5.TabIndex = 5;
            button5.Text = "Regularização de Ponto";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(690, 468);
            button6.Name = "button6";
            button6.Size = new Size(179, 58);
            button6.TabIndex = 6;
            button6.Text = "Notificaçoes";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(993, 271);
            button7.Name = "button7";
            button7.Size = new Size(179, 58);
            button7.TabIndex = 7;
            button7.Text = "Compliance";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(993, 468);
            button8.Name = "button8";
            button8.Size = new Size(179, 58);
            button8.TabIndex = 8;
            button8.Text = "Painel Administrativo";
            button8.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 604);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnBancoHoras);
            Controls.Add(btnPonto);
            Controls.Add(pictureBox1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPonto;
        private Button btnBancoHoras;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}