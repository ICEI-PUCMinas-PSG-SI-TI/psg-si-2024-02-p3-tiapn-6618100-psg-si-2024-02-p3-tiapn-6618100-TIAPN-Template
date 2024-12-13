﻿namespace BS_Projeto
{
    partial class FormCadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtNumero = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblDataNascimento = new Label();
            lblGenero = new Label();
            txtDataNasc = new MaskedTextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtTelefone = new MaskedTextBox();
            txtLogradouro = new TextBox();
            lblEndereco = new Label();
            txtGenero = new TextBox();
            txtBairro = new TextBox();
            label2 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtEstado = new TextBox();
            label4 = new Label();
            txtComplemento = new TextBox();
            label5 = new Label();
            txtIDAtendente = new TextBox();
            button1 = new Button();
            btnEditarPlano = new Button();
            button2 = new Button();
            listViewAtendente = new ListView();
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
            panel1.Size = new Size(923, 43);
            panel1.TabIndex = 0;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(567, 12);
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
            lblTitulo.Location = new Point(13, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Aluno";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(50, 56);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Left;
            txtNome.Location = new Point(50, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(494, 27);
            txtNome.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.Left;
            txtNumero.Location = new Point(427, 228);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(117, 27);
            txtNumero.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Impact", 10.8F);
            lblEmail.Location = new Point(427, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 22);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Numero:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Impact", 10.8F);
            lblTelefone.Location = new Point(427, 128);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 22);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 10.8F);
            lblDataNascimento.Location = new Point(50, 128);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(156, 22);
            lblDataNascimento.TabIndex = 11;
            lblDataNascimento.Text = "Data de nascimento:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Impact", 10.8F);
            lblGenero.Location = new Point(245, 128);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(108, 22);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Gênero (M/F):";
            // 
            // txtDataNasc
            // 
            txtDataNasc.Anchor = AnchorStyles.Left;
            txtDataNasc.Location = new Point(50, 156);
            txtDataNasc.Mask = "00/00/0000";
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(156, 27);
            txtDataNasc.TabIndex = 5;
            txtDataNasc.ValidatingType = typeof(DateTime);
            txtDataNasc.KeyPress += txtDataNasc_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(202, 416);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 17;
            label1.Text = "Atendente(ID):";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(276, 639);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 51);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(417, 698);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 51);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Left;
            txtTelefone.Location = new Point(427, 156);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(117, 27);
            txtTelefone.TabIndex = 3;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Left;
            txtLogradouro.Location = new Point(50, 228);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(353, 27);
            txtLogradouro.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Impact", 10.8F);
            lblEndereco.Location = new Point(50, 200);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(96, 22);
            lblEndereco.TabIndex = 24;
            lblEndereco.Text = "Logradouro:";
            lblEndereco.Click += lblEndereco_Click;
            // 
            // txtGenero
            // 
            txtGenero.Anchor = AnchorStyles.Left;
            txtGenero.Location = new Point(246, 156);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(106, 27);
            txtGenero.TabIndex = 101;
            txtGenero.TextChanged += txtGenero_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Left;
            txtBairro.Location = new Point(50, 300);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(179, 27);
            txtBairro.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(50, 272);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 103;
            label2.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Left;
            txtCidade.Location = new Point(246, 300);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(147, 27);
            txtCidade.TabIndex = 104;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 10.8F);
            label3.Location = new Point(245, 272);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 105;
            label3.Text = "Cidade:";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Left;
            txtEstado.Location = new Point(427, 300);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(117, 27);
            txtEstado.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 10.8F);
            label4.Location = new Point(427, 272);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 107;
            label4.Text = "Estado:";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.Left;
            txtComplemento.Location = new Point(52, 372);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(177, 27);
            txtComplemento.TabIndex = 108;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 10.8F);
            label5.Location = new Point(52, 344);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 109;
            label5.Text = "Complemento:";
            // 
            // txtIDAtendente
            // 
            txtIDAtendente.Location = new Point(322, 415);
            txtIDAtendente.Name = "txtIDAtendente";
            txtIDAtendente.Size = new Size(52, 27);
            txtIDAtendente.TabIndex = 110;
            txtIDAtendente.KeyPress += txtIDAtendente_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Impact", 9F);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(52, 698);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 53);
            button1.TabIndex = 126;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEditarPlano
            // 
            btnEditarPlano.BackColor = Color.Black;
            btnEditarPlano.Cursor = Cursors.Hand;
            btnEditarPlano.Font = new Font("Impact", 9F);
            btnEditarPlano.ForeColor = Color.White;
            btnEditarPlano.Location = new Point(417, 637);
            btnEditarPlano.Margin = new Padding(3, 4, 3, 4);
            btnEditarPlano.Name = "btnEditarPlano";
            btnEditarPlano.Size = new Size(127, 53);
            btnEditarPlano.TabIndex = 125;
            btnEditarPlano.Text = "Editar";
            btnEditarPlano.UseVisualStyleBackColor = false;
            btnEditarPlano.Click += btnEditarPlano_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 9F);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(52, 637);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(205, 53);
            button2.TabIndex = 127;
            button2.Text = "Associar aluno a um plano";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listViewAtendente
            // 
            listViewAtendente.Location = new Point(52, 449);
            listViewAtendente.Margin = new Padding(3, 4, 3, 4);
            listViewAtendente.Name = "listViewAtendente";
            listViewAtendente.Size = new Size(492, 157);
            listViewAtendente.TabIndex = 128;
            listViewAtendente.UseCompatibleStateImageBehavior = false;
            listViewAtendente.SelectedIndexChanged += listViewAtendente_SelectedIndexChanged;
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 769);
            Controls.Add(listViewAtendente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEditarPlano);
            Controls.Add(txtIDAtendente);
            Controls.Add(txtComplemento);
            Controls.Add(label5);
            Controls.Add(txtEstado);
            Controls.Add(label4);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtBairro);
            Controls.Add(label2);
            Controls.Add(txtGenero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtDataNasc);
            Controls.Add(lblGenero);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblTelefone);
            Controls.Add(txtNumero);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroAluno";
            Text = "Cadastro Aluno";
            Load += FormCadastroAluno_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label lblSair;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtNumero;
        private Label lblEmail;
        private TextBox txtBairro;
        private Label lblTelefone;
        private TextBox txtCidade;
        private Label lblDataNascimento;
        private TextBox txtEstado;
        private Label lblGenero;
        private MaskedTextBox txtDataNasc;
        private Label label1;
        private Button btnCancelar;
        private Button btnSalvar;
        private MaskedTextBox txtTelefone;
        private TextBox txtLogradouro;
        private Label lblEndereco;
        private TextBox txtGenero;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtComplemento;
        private Label label5;
        private TextBox txtIDAtendente;
        private Button button1;
        private Button btnEditarPlano;
        private Button button2;
        private ListView listViewAtendente;
    }
}