namespace BodyShape_TI.Forms
{
    partial class TelaSprint4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSprint4));
            pnlnavegacao = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSair = new Label();
            pnlBotao3 = new Panel();
            pnlBtnPlanos = new Panel();
            btnProfissionais = new Button();
            pnlLogo = new Panel();
            pictureLogo = new PictureBox();
            pnlBotao2 = new Panel();
            pnlBtnProf = new Panel();
            btnCadPlano = new Button();
            pnlBotao1 = new Panel();
            pnlBtnAlunos = new Panel();
            btnCadAluno = new Button();
            BoasVindas = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlnavegacao.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBotao3.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            pnlBotao2.SuspendLayout();
            pnlBotao1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlnavegacao
            // 
            pnlnavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlnavegacao.BackColor = Color.FromArgb(36, 44, 50);
            pnlnavegacao.Controls.Add(panel1);
            pnlnavegacao.Controls.Add(pnlBotao3);
            pnlnavegacao.Controls.Add(pnlLogo);
            pnlnavegacao.Controls.Add(pnlBotao2);
            pnlnavegacao.Controls.Add(pnlBotao1);
            pnlnavegacao.Location = new Point(-5, -9);
            pnlnavegacao.Margin = new Padding(3, 4, 3, 4);
            pnlnavegacao.MinimumSize = new Size(141, 855);
            pnlnavegacao.Name = "pnlnavegacao";
            pnlnavegacao.Size = new Size(222, 855);
            pnlnavegacao.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSair);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(50, 427);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 69);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSair.ForeColor = SystemColors.Control;
            lblSair.Location = new Point(47, 12);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(60, 35);
            lblSair.TabIndex = 0;
            lblSair.Text = "Sair";
            // 
            // pnlBotao3
            // 
            pnlBotao3.Controls.Add(pnlBtnPlanos);
            pnlBotao3.Controls.Add(btnProfissionais);
            pnlBotao3.Location = new Point(3, 305);
            pnlBotao3.Margin = new Padding(3, 4, 3, 4);
            pnlBotao3.Name = "pnlBotao3";
            pnlBotao3.Size = new Size(218, 56);
            pnlBotao3.TabIndex = 147;
            // 
            // pnlBtnPlanos
            // 
            pnlBtnPlanos.BackColor = Color.Aquamarine;
            pnlBtnPlanos.Location = new Point(200, -2);
            pnlBtnPlanos.Margin = new Padding(3, 4, 3, 4);
            pnlBtnPlanos.Name = "pnlBtnPlanos";
            pnlBtnPlanos.Size = new Size(13, 56);
            pnlBtnPlanos.TabIndex = 12;
            pnlBtnPlanos.Visible = false;
            // 
            // btnProfissionais
            // 
            btnProfissionais.Cursor = Cursors.Hand;
            btnProfissionais.FlatAppearance.BorderSize = 0;
            btnProfissionais.FlatStyle = FlatStyle.Popup;
            btnProfissionais.Font = new Font("Impact", 9F);
            btnProfissionais.ForeColor = SystemColors.ButtonHighlight;
            btnProfissionais.Location = new Point(11, 4);
            btnProfissionais.Margin = new Padding(3, 4, 3, 4);
            btnProfissionais.Name = "btnProfissionais";
            btnProfissionais.Size = new Size(183, 45);
            btnProfissionais.TabIndex = 2;
            btnProfissionais.Text = "Associar aluno ao plano";
            btnProfissionais.UseVisualStyleBackColor = true;
            btnProfissionais.Click += btnProfissionais_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureLogo);
            pnlLogo.Location = new Point(41, 22);
            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(123, 123);
            pnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(13, 4);
            pictureLogo.Margin = new Padding(3, 4, 3, 4);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(95, 115);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // pnlBotao2
            // 
            pnlBotao2.Controls.Add(pnlBtnProf);
            pnlBotao2.Controls.Add(btnCadPlano);
            pnlBotao2.Location = new Point(3, 248);
            pnlBotao2.Margin = new Padding(3, 4, 3, 4);
            pnlBotao2.Name = "pnlBotao2";
            pnlBotao2.Size = new Size(218, 56);
            pnlBotao2.TabIndex = 146;
            // 
            // pnlBtnProf
            // 
            pnlBtnProf.BackColor = Color.Aquamarine;
            pnlBtnProf.Location = new Point(200, 0);
            pnlBtnProf.Margin = new Padding(3, 4, 3, 4);
            pnlBtnProf.Name = "pnlBtnProf";
            pnlBtnProf.Size = new Size(13, 55);
            pnlBtnProf.TabIndex = 11;
            pnlBtnProf.Visible = false;
            // 
            // btnCadPlano
            // 
            btnCadPlano.Cursor = Cursors.Hand;
            btnCadPlano.FlatAppearance.BorderSize = 0;
            btnCadPlano.FlatStyle = FlatStyle.Popup;
            btnCadPlano.Font = new Font("Impact", 13.8F);
            btnCadPlano.ForeColor = SystemColors.ButtonHighlight;
            btnCadPlano.Location = new Point(15, 5);
            btnCadPlano.Margin = new Padding(3, 4, 3, 4);
            btnCadPlano.Name = "btnCadPlano";
            btnCadPlano.Size = new Size(179, 45);
            btnCadPlano.TabIndex = 1;
            btnCadPlano.Text = "Cadastrar Plano";
            btnCadPlano.UseVisualStyleBackColor = true;
            btnCadPlano.Click += btnCadPlano_Click;
            // 
            // pnlBotao1
            // 
            pnlBotao1.Controls.Add(pnlBtnAlunos);
            pnlBotao1.Controls.Add(btnCadAluno);
            pnlBotao1.Location = new Point(3, 192);
            pnlBotao1.Margin = new Padding(3, 4, 3, 4);
            pnlBotao1.Name = "pnlBotao1";
            pnlBotao1.Size = new Size(213, 56);
            pnlBotao1.TabIndex = 145;
            // 
            // pnlBtnAlunos
            // 
            pnlBtnAlunos.BackColor = Color.Aquamarine;
            pnlBtnAlunos.Location = new Point(200, 1);
            pnlBtnAlunos.Margin = new Padding(3, 4, 3, 4);
            pnlBtnAlunos.Name = "pnlBtnAlunos";
            pnlBtnAlunos.Size = new Size(13, 55);
            pnlBtnAlunos.TabIndex = 11;
            pnlBtnAlunos.Visible = false;
            // 
            // btnCadAluno
            // 
            btnCadAluno.Cursor = Cursors.Hand;
            btnCadAluno.FlatAppearance.BorderColor = Color.White;
            btnCadAluno.FlatAppearance.BorderSize = 0;
            btnCadAluno.FlatStyle = FlatStyle.Popup;
            btnCadAluno.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadAluno.ForeColor = SystemColors.ButtonHighlight;
            btnCadAluno.Location = new Point(11, 5);
            btnCadAluno.Margin = new Padding(3, 4, 3, 4);
            btnCadAluno.Name = "btnCadAluno";
            btnCadAluno.Size = new Size(183, 45);
            btnCadAluno.TabIndex = 0;
            btnCadAluno.Text = "Cadastrar Aluno";
            btnCadAluno.UseVisualStyleBackColor = true;
            btnCadAluno.Click += btnCadAluno_Click;
            // 
            // BoasVindas
            // 
            BoasVindas.AutoSize = true;
            BoasVindas.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoasVindas.Location = new Point(440, 182);
            BoasVindas.Name = "BoasVindas";
            BoasVindas.Size = new Size(276, 17);
            BoasVindas.TabIndex = 5;
            BoasVindas.Text = "Seja bem-vindo à Sharp Academy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 205);
            label1.Name = "label1";
            label1.Size = new Size(567, 28);
            label1.TabIndex = 6;
            label1.Text = "Onde seu corpo fica tão definido quanto seu código em C#!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(523, 249);
            label2.Name = "label2";
            label2.Size = new Size(114, 46);
            label2.TabIndex = 7;
            label2.Text = "💪💻";
            // 
            // TelaSprint4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BoasVindas);
            Controls.Add(pnlnavegacao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaSprint4";
            Text = "Home Page";
            pnlnavegacao.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBotao3.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            pnlBotao2.ResumeLayout(false);
            pnlBotao1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlnavegacao;
        private Panel pnlLogo;
        private PictureBox pictureLogo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblSair;
        private Panel pnlBotao4;
        private Panel pnlBtnAulas;
        private Button btnPlanos;
        private Panel pnlBotao3;
        private Panel pnlBtnPlanos;
        private Button btnProfissionais;
        private Panel pnlBotao2;
        private Panel pnlBtnProf;
        private Button btnCadPlano;
        private Panel pnlBotao1;
        private Panel pnlBtnAlunos;
        private Button btnCadAluno;
        private Label BoasVindas;
        private Label label1;
        private Label label2;
    }
}