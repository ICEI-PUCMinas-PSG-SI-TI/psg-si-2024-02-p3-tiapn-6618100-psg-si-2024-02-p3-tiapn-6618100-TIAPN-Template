namespace BodyShape_TI
{
    partial class FormCadastroProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProfissional));
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            maskedTextBox1 = new MaskedTextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cboxSetor = new ComboBox();
            lblSetor = new Label();
            cboxGenero = new ComboBox();
            txtDataNasc = new MaskedTextBox();
            lblGenero = new Label();
            lblDataNascimento = new Label();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            tctIdProfissional = new TextBox();
            lblIdProfissional = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnPesquisaEndereco = new Button();
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
            lblSair.Click += lblSair_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(13, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Profissional";
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEndereco.Location = new Point(44, 318);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(384, 27);
            txtEndereco.TabIndex = 45;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Impact", 10.8F);
            lblEndereco.Location = new Point(44, 292);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(81, 22);
            lblEndereco.TabIndex = 44;
            lblEndereco.Text = "Endereço:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(334, 248);
            maskedTextBox1.Mask = "(99) 99999-9999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(117, 27);
            maskedTextBox1.TabIndex = 43;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(44, 530);
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
            btnSalvar.Location = new Point(334, 530);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboxSetor
            // 
            cboxSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxSetor.FormattingEnabled = true;
            cboxSetor.Location = new Point(44, 463);
            cboxSetor.Name = "cboxSetor";
            cboxSetor.Size = new Size(417, 28);
            cboxSetor.TabIndex = 40;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.BackColor = Color.Transparent;
            lblSetor.Font = new Font("Impact", 10.8F);
            lblSetor.Location = new Point(44, 438);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(52, 22);
            lblSetor.TabIndex = 39;
            lblSetor.Text = "Setor:";
            // 
            // cboxGenero
            // 
            cboxGenero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Location = new Point(234, 394);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(227, 28);
            cboxGenero.TabIndex = 36;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(44, 395);
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
            lblGenero.Location = new Point(234, 365);
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
            lblDataNascimento.Location = new Point(44, 365);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(156, 22);
            lblDataNascimento.TabIndex = 33;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Impact", 10.8F);
            lblTelefone.Location = new Point(334, 223);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 22);
            lblTelefone.TabIndex = 32;
            lblTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(44, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 31;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Impact", 10.8F);
            lblEmail.Location = new Point(44, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 22);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email:";
            // 
            // tctIdProfissional
            // 
            tctIdProfissional.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tctIdProfissional.Location = new Point(44, 170);
            tctIdProfissional.Name = "tctIdProfissional";
            tctIdProfissional.ReadOnly = true;
            tctIdProfissional.Size = new Size(417, 27);
            tctIdProfissional.TabIndex = 29;
            // 
            // lblIdProfissional
            // 
            lblIdProfissional.AutoSize = true;
            lblIdProfissional.BackColor = Color.Transparent;
            lblIdProfissional.Font = new Font("Impact", 10.8F);
            lblIdProfissional.Location = new Point(44, 146);
            lblIdProfissional.Name = "lblIdProfissional";
            lblIdProfissional.Size = new Size(119, 22);
            lblIdProfissional.TabIndex = 28;
            lblIdProfissional.Text = "ID Profissional:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(44, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 27);
            txtNome.TabIndex = 27;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(44, 73);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 26;
            lblNome.Text = "Nome:";
            // 
            // btnPesquisaEndereco
            // 
            btnPesquisaEndereco.BackColor = Color.Transparent;
            btnPesquisaEndereco.BackgroundImage = (Image)resources.GetObject("btnPesquisaEndereco.BackgroundImage");
            btnPesquisaEndereco.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisaEndereco.Location = new Point(434, 318);
            btnPesquisaEndereco.Name = "btnPesquisaEndereco";
            btnPesquisaEndereco.Size = new Size(27, 27);
            btnPesquisaEndereco.TabIndex = 101;
            btnPesquisaEndereco.UseVisualStyleBackColor = false;
            btnPesquisaEndereco.Click += btnPesquisaEndereco_Click;
            // 
            // FomCadastroProfissional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 605);
            Controls.Add(btnPesquisaEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboxSetor);
            Controls.Add(lblSetor);
            Controls.Add(cboxGenero);
            Controls.Add(txtDataNasc);
            Controls.Add(lblGenero);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(tctIdProfissional);
            Controls.Add(lblIdProfissional);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FomCadastroProfissional";
            Text = "FomCadastroProfissional";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private MaskedTextBox maskedTextBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cboxSetor;
        private Label lblSetor;
        private ComboBox cboxGenero;
        private MaskedTextBox txtDataNasc;
        private Label lblGenero;
        private Label lblDataNascimento;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox tctIdProfissional;
        private Label lblIdProfissional;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnPesquisaEndereco;
    }
}