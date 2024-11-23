namespace BodyShape_TI.Forms
{
    partial class FormCadastroAlunoPlano
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
            btnCancelar = new Button();
            txtAlunoID = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            txtPlanoID = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            txtDataInicioPlano = new MaskedTextBox();
            lblDataNascimento = new Label();
            txtDataFimPlano = new MaskedTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(66, 249);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 51);
            btnCancelar.TabIndex = 134;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtAlunoID
            // 
            txtAlunoID.Location = new Point(305, 97);
            txtAlunoID.Name = "txtAlunoID";
            txtAlunoID.Size = new Size(170, 27);
            txtAlunoID.TabIndex = 132;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(305, 249);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(170, 51);
            btnSalvar.TabIndex = 130;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(305, 69);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 129;
            label1.Text = "Aluno (ID):";
            // 
            // txtPlanoID
            // 
            txtPlanoID.Location = new Point(66, 97);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(158, 27);
            txtPlanoID.TabIndex = 127;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(66, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 22);
            lblNome.TabIndex = 128;
            lblNome.Text = "Plano (ID):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 43);
            panel1.TabIndex = 126;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(475, 11);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(22, 21);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(13, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Associar aluno a um plano";
            // 
            // txtDataInicioPlano
            // 
            txtDataInicioPlano.Location = new Point(68, 188);
            txtDataInicioPlano.Mask = "00/00/0000";
            txtDataInicioPlano.Name = "txtDataInicioPlano";
            txtDataInicioPlano.Size = new Size(156, 27);
            txtDataInicioPlano.TabIndex = 135;
            txtDataInicioPlano.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(68, 160);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(113, 22);
            lblDataNascimento.TabIndex = 136;
            lblDataNascimento.Text = "Data de início:";
            // 
            // txtDataFimPlano
            // 
            txtDataFimPlano.Location = new Point(305, 188);
            txtDataFimPlano.Mask = "00/00/0000";
            txtDataFimPlano.Name = "txtDataFimPlano";
            txtDataFimPlano.Size = new Size(170, 27);
            txtDataFimPlano.TabIndex = 137;
            txtDataFimPlano.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(305, 160);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 138;
            label2.Text = "Data de fim:";
            // 
            // FormCadastroAlunoPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 329);
            Controls.Add(txtDataFimPlano);
            Controls.Add(label2);
            Controls.Add(txtDataInicioPlano);
            Controls.Add(lblDataNascimento);
            Controls.Add(btnCancelar);
            Controls.Add(txtAlunoID);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtPlanoID);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroAlunoPlano";
            Text = "FormCadastroAlunoPlano";
            Load += FormCadastroAlunoPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtAlunoID;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtPlanoID;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private MaskedTextBox txtDataInicioPlano;
        private Label lblDataNascimento;
        private MaskedTextBox txtDataFimPlano;
        private Label label2;
    }
}