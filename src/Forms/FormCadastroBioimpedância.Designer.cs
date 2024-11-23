namespace BodyShape_TI.Forms
{
    partial class FormCadastroBioimpedância
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
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            textBox1 = new TextBox();
            lblAltura = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cboxPlano = new ComboBox();
            lblPlano = new Label();
            txtIDAtendente = new TextBox();
            label1 = new Label();
            cboxGenero = new ComboBox();
            txtDataNasc = new MaskedTextBox();
            lblGenero = new Label();
            lblDataNascimento = new Label();
            lblEducadorFisico = new Label();
            txtIdAluno = new TextBox();
            lblIdAluno = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtAltura = new MaskedTextBox();
            txtPeso = new MaskedTextBox();
            lblPeso = new Label();
            txtIdEducador = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 42);
            panel1.TabIndex = 1;
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
            lblTitulo.Location = new Point(13, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Bioimpedância";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(46, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 27);
            textBox1.TabIndex = 45;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Impact", 10.8F);
            lblAltura.Location = new Point(46, 229);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(57, 22);
            lblAltura.TabIndex = 44;
            lblAltura.Text = "Altura:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(46, 530);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 50);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(336, 530);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // cboxPlano
            // 
            cboxPlano.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxPlano.FormattingEnabled = true;
            cboxPlano.Location = new Point(236, 469);
            cboxPlano.Name = "cboxPlano";
            cboxPlano.Size = new Size(227, 28);
            cboxPlano.TabIndex = 40;
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.BackColor = Color.Transparent;
            lblPlano.Font = new Font("Impact", 10.8F);
            lblPlano.Location = new Point(236, 448);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(55, 22);
            lblPlano.TabIndex = 39;
            lblPlano.Text = "Plano:";
            // 
            // txtIDAtendente
            // 
            txtIDAtendente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDAtendente.Location = new Point(46, 470);
            txtIDAtendente.Name = "txtIDAtendente";
            txtIDAtendente.ReadOnly = true;
            txtIDAtendente.Size = new Size(156, 27);
            txtIDAtendente.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(46, 448);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 37;
            label1.Text = "Atendente:";
            // 
            // cboxGenero
            // 
            cboxGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Location = new Point(236, 394);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(227, 28);
            cboxGenero.TabIndex = 36;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(46, 395);
            txtDataNasc.Mask = "00/00/0000";
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(156, 27);
            txtDataNasc.TabIndex = 35;
            txtDataNasc.ValidatingType = typeof(DateTime);
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Impact", 10.8F);
            lblGenero.Location = new Point(236, 373);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(66, 22);
            lblGenero.TabIndex = 34;
            lblGenero.Text = "Gênero:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(46, 373);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(156, 22);
            lblDataNascimento.TabIndex = 33;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblEducadorFisico
            // 
            lblEducadorFisico.AutoSize = true;
            lblEducadorFisico.BackColor = Color.Transparent;
            lblEducadorFisico.Font = new Font("Impact", 10.8F);
            lblEducadorFisico.Location = new Point(251, 148);
            lblEducadorFisico.Name = "lblEducadorFisico";
            lblEducadorFisico.Size = new Size(145, 22);
            lblEducadorFisico.TabIndex = 30;
            lblEducadorFisico.Text = "ID Educador Físico:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdAluno.Location = new Point(46, 170);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.ReadOnly = true;
            txtIdAluno.Size = new Size(175, 27);
            txtIdAluno.TabIndex = 29;
            // 
            // lblIdAluno
            // 
            lblIdAluno.AutoSize = true;
            lblIdAluno.BackColor = Color.Transparent;
            lblIdAluno.Font = new Font("Impact", 10.8F);
            lblIdAluno.Location = new Point(46, 148);
            lblIdAluno.Name = "lblIdAluno";
            lblIdAluno.Size = new Size(73, 22);
            lblIdAluno.TabIndex = 28;
            lblIdAluno.Text = "ID Aluno:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(46, 95);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(417, 27);
            txtNome.TabIndex = 27;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(46, 73);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 26;
            lblNome.Text = "Nome:";
            // 
            // txtAltura
            // 
            txtAltura.Culture = new System.Globalization.CultureInfo("");
            txtAltura.Location = new Point(46, 254);
            txtAltura.Mask = "0.00";
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(175, 27);
            txtAltura.TabIndex = 46;
            // 
            // txtPeso
            // 
            txtPeso.Culture = new System.Globalization.CultureInfo("");
            txtPeso.Location = new Point(251, 254);
            txtPeso.Mask = "0.00";
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(212, 27);
            txtPeso.TabIndex = 48;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Impact", 10.8F);
            lblPeso.Location = new Point(251, 229);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(49, 22);
            lblPeso.TabIndex = 47;
            lblPeso.Text = "Peso:";
            // 
            // txtIdEducador
            // 
            txtIdEducador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdEducador.Location = new Point(251, 173);
            txtIdEducador.Name = "txtIdEducador";
            txtIdEducador.ReadOnly = true;
            txtIdEducador.Size = new Size(212, 27);
            txtIdEducador.TabIndex = 49;
            // 
            // FormCadastroBioimpedância
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 605);
            Controls.Add(txtIdEducador);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtAltura);
            Controls.Add(textBox1);
            Controls.Add(lblAltura);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboxPlano);
            Controls.Add(lblPlano);
            Controls.Add(txtIDAtendente);
            Controls.Add(label1);
            Controls.Add(cboxGenero);
            Controls.Add(txtDataNasc);
            Controls.Add(lblGenero);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblEducadorFisico);
            Controls.Add(txtIdAluno);
            Controls.Add(lblIdAluno);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroBioimpedância";
            Text = "FormCadastroBioimpedância";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox textBox1;
        private Label lblAltura;
        private MaskedTextBox maskedTextBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cboxPlano;
        private Label lblPlano;
        private TextBox txtIDAtendente;
        private Label label1;
        private ComboBox cboxGenero;
        private MaskedTextBox txtDataNasc;
        private Label lblGenero;
        private Label lblDataNascimento;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEducadorFisico;
        private TextBox txtIdAluno;
        private Label lblIdAluno;
        private TextBox txtNome;
        private Label lblNome;
        private MaskedTextBox txtAltura;
        private MaskedTextBox txtPeso;
        private Label lblPeso;
        private TextBox txtIdEducador;
    }
}