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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 185);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 246);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 310);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 4;
            label5.Text = "Data de Admissão";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 53);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 5;
            label6.Text = "Função";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroForm";
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
    }
}