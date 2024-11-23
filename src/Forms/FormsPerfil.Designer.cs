namespace BS_Projeto
{
    partial class FormsPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsPerfil));
            lblNomePerfil = new Label();
            pnlFaixaNomePerfil = new Panel();
            lblUser = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAlterarDados = new Button();
            pictureBox1 = new PictureBox();
            lblSair = new Label();
            lblUserLogado = new Label();
            lblEmailUser = new Label();
            lblSenhaUser = new Label();
            lblTelefoneUser = new Label();
            lblDataIngressoUser = new Label();
            lblAcessoUser = new Label();
            btnAcessarFicha = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNomePerfil
            // 
            lblNomePerfil.AutoSize = true;
            lblNomePerfil.Font = new Font("Impact", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomePerfil.Location = new Point(179, 85);
            lblNomePerfil.Name = "lblNomePerfil";
            lblNomePerfil.Size = new Size(320, 41);
            lblNomePerfil.TabIndex = 4;
            lblNomePerfil.Text = "Nome do Perfil Logado";
            // 
            // pnlFaixaNomePerfil
            // 
            pnlFaixaNomePerfil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFaixaNomePerfil.BackColor = Color.Aquamarine;
            pnlFaixaNomePerfil.Location = new Point(186, 142);
            pnlFaixaNomePerfil.Margin = new Padding(3, 4, 3, 4);
            pnlFaixaNomePerfil.Name = "pnlFaixaNomePerfil";
            pnlFaixaNomePerfil.Size = new Size(756, 12);
            pnlFaixaNomePerfil.TabIndex = 99999;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(186, 186);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 32);
            lblUser.TabIndex = 7;
            lblUser.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 245);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 362);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 9;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(186, 304);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 10;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(186, 421);
            label5.Name = "label5";
            label5.Size = new Size(193, 32);
            label5.TabIndex = 11;
            label5.Text = "Data de ingresso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(186, 499);
            label6.Name = "label6";
            label6.Size = new Size(173, 32);
            label6.TabIndex = 12;
            label6.Text = "Tipo de acesso:";
            // 
            // btnAlterarDados
            // 
            btnAlterarDados.BackColor = Color.Black;
            btnAlterarDados.Cursor = Cursors.Hand;
            btnAlterarDados.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterarDados.ForeColor = SystemColors.ButtonHighlight;
            btnAlterarDados.Location = new Point(186, 577);
            btnAlterarDados.Margin = new Padding(3, 4, 3, 4);
            btnAlterarDados.Name = "btnAlterarDados";
            btnAlterarDados.Size = new Size(173, 55);
            btnAlterarDados.TabIndex = 13;
            btnAlterarDados.Text = "Alterar dados";
            btnAlterarDados.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pnlSair_Click;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSair.Location = new Point(47, 9);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(60, 35);
            lblSair.TabIndex = 0;
            lblSair.Text = "Sair";
            lblSair.Click += pnlSair_Click;
            // 
            // lblUserLogado
            // 
            lblUserLogado.AutoSize = true;
            lblUserLogado.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserLogado.ForeColor = SystemColors.WindowFrame;
            lblUserLogado.Location = new Point(292, 191);
            lblUserLogado.Name = "lblUserLogado";
            lblUserLogado.Size = new Size(123, 25);
            lblUserLogado.TabIndex = 15;
            lblUserLogado.Text = "UserUserUser";
            // 
            // lblEmailUser
            // 
            lblEmailUser.AutoSize = true;
            lblEmailUser.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailUser.ForeColor = SystemColors.WindowFrame;
            lblEmailUser.Location = new Point(267, 250);
            lblEmailUser.Name = "lblEmailUser";
            lblEmailUser.Size = new Size(148, 25);
            lblEmailUser.TabIndex = 16;
            lblEmailUser.Text = "user@email.com";
            // 
            // lblSenhaUser
            // 
            lblSenhaUser.AutoSize = true;
            lblSenhaUser.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenhaUser.ForeColor = SystemColors.WindowFrame;
            lblSenhaUser.Location = new Point(276, 309);
            lblSenhaUser.Name = "lblSenhaUser";
            lblSenhaUser.Size = new Size(98, 25);
            lblSenhaUser.TabIndex = 17;
            lblSenhaUser.Text = "senhaUser";
            // 
            // lblTelefoneUser
            // 
            lblTelefoneUser.AutoSize = true;
            lblTelefoneUser.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefoneUser.ForeColor = SystemColors.WindowFrame;
            lblTelefoneUser.Location = new Point(301, 368);
            lblTelefoneUser.Name = "lblTelefoneUser";
            lblTelefoneUser.Size = new Size(166, 25);
            lblTelefoneUser.TabIndex = 18;
            lblTelefoneUser.Text = "(DDD) 99999-9999";
            // 
            // lblDataIngressoUser
            // 
            lblDataIngressoUser.AutoSize = true;
            lblDataIngressoUser.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataIngressoUser.ForeColor = SystemColors.WindowFrame;
            lblDataIngressoUser.Location = new Point(383, 426);
            lblDataIngressoUser.Name = "lblDataIngressoUser";
            lblDataIngressoUser.Size = new Size(116, 25);
            lblDataIngressoUser.TabIndex = 19;
            lblDataIngressoUser.Text = "00/00/0000";
            // 
            // lblAcessoUser
            // 
            lblAcessoUser.AutoSize = true;
            lblAcessoUser.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcessoUser.ForeColor = SystemColors.WindowFrame;
            lblAcessoUser.Location = new Point(365, 506);
            lblAcessoUser.Name = "lblAcessoUser";
            lblAcessoUser.Size = new Size(108, 25);
            lblAcessoUser.TabIndex = 20;
            lblAcessoUser.Text = "Tipo Acesso";
            // 
            // btnAcessarFicha
            // 
            btnAcessarFicha.BackColor = Color.DarkSlateGray;
            btnAcessarFicha.Cursor = Cursors.Hand;
            btnAcessarFicha.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcessarFicha.ForeColor = SystemColors.ButtonHighlight;
            btnAcessarFicha.Location = new Point(749, 577);
            btnAcessarFicha.Margin = new Padding(3, 4, 3, 4);
            btnAcessarFicha.Name = "btnAcessarFicha";
            btnAcessarFicha.Size = new Size(173, 55);
            btnAcessarFicha.TabIndex = 21;
            btnAcessarFicha.Text = "Mostrar Ficha";
            btnAcessarFicha.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Aquamarine;
            panel1.Location = new Point(186, 544);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 12);
            panel1.TabIndex = 9999;
            // 
            // FormsPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 850);
            Controls.Add(panel1);
            Controls.Add(btnAcessarFicha);
            Controls.Add(lblAcessoUser);
            Controls.Add(lblDataIngressoUser);
            Controls.Add(lblTelefoneUser);
            Controls.Add(lblSenhaUser);
            Controls.Add(lblEmailUser);
            Controls.Add(lblUserLogado);
            Controls.Add(btnAlterarDados);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUser);
            Controls.Add(pnlFaixaNomePerfil);
            Controls.Add(lblNomePerfil);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormsPerfil";
            Text = "FormsPerfil";
            Controls.SetChildIndex(lblNomePerfil, 0);
            Controls.SetChildIndex(pnlFaixaNomePerfil, 0);
            Controls.SetChildIndex(lblUser, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(btnAlterarDados, 0);
            Controls.SetChildIndex(lblUserLogado, 0);
            Controls.SetChildIndex(lblEmailUser, 0);
            Controls.SetChildIndex(lblSenhaUser, 0);
            Controls.SetChildIndex(lblTelefoneUser, 0);
            Controls.SetChildIndex(lblDataIngressoUser, 0);
            Controls.SetChildIndex(lblAcessoUser, 0);
            Controls.SetChildIndex(btnAcessarFicha, 0);
            Controls.SetChildIndex(panel1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.Panel pnlFaixaNomePerfil;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.Label lblEmailUser;
        private System.Windows.Forms.Label lblSenhaUser;
        private System.Windows.Forms.Label lblTelefoneUser;
        private System.Windows.Forms.Label lblDataIngressoUser;
        private System.Windows.Forms.Label lblAcessoUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Button btnAcessarFicha;
        private Panel panel1;
    }
}