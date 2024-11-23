namespace BodyShape_TI.Forms
{
    partial class FormCadastroPlano
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
            btnEditarPlano = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            txtValorPlano = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            txtTipoPlano = new TextBox();
            button1 = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarPlano
            // 
            btnEditarPlano.BackColor = Color.FromArgb(0, 192, 192);
            btnEditarPlano.Cursor = Cursors.Hand;
            btnEditarPlano.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPlano.ForeColor = Color.Black;
            btnEditarPlano.Location = new Point(59, 149);
            btnEditarPlano.Margin = new Padding(3, 4, 3, 4);
            btnEditarPlano.Name = "btnEditarPlano";
            btnEditarPlano.Size = new Size(144, 43);
            btnEditarPlano.TabIndex = 119;
            btnEditarPlano.Text = "Editar um plano";
            btnEditarPlano.UseVisualStyleBackColor = false;
            btnEditarPlano.Click += btnEditarPlano_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(299, 214);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(143, 51);
            btnSalvar.TabIndex = 118;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(299, 69);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 115;
            label1.Text = "Tipo do Plano:";
            // 
            // txtValorPlano
            // 
            txtValorPlano.Location = new Point(60, 94);
            txtValorPlano.Name = "txtValorPlano";
            txtValorPlano.Size = new Size(143, 27);
            txtValorPlano.TabIndex = 102;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(60, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(96, 22);
            lblNome.TabIndex = 105;
            lblNome.Text = "Valor Plano:";
            lblNome.Click += lblNome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 43);
            panel1.TabIndex = 101;
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
            lblTitulo.Size = new Size(140, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Plano";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // txtTipoPlano
            // 
            txtTipoPlano.Location = new Point(299, 94);
            txtTipoPlano.Name = "txtTipoPlano";
            txtTipoPlano.Size = new Size(143, 27);
            txtTipoPlano.TabIndex = 123;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(299, 149);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 43);
            button1.TabIndex = 124;
            button1.Text = "Excluir um plano";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(60, 214);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 51);
            btnCancelar.TabIndex = 125;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastroPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 301);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(txtTipoPlano);
            Controls.Add(btnEditarPlano);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtValorPlano);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroPlano";
            Text = "FormCadastroPlano";
            Load += FormCadastroPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button btnAdicionarBioimpedancia;
        private Button btnEditarPlano;
        private Button btnSalvar;
        private ComboBox cboxPlano;
        private Label lblPlano;
        private TextBox txtIDAtendente;
        private Label label1;
        private TextBox txtValorPlano;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox txtTipoPlano;
        private Button button1;
        private Button btnCancelar;
    }
}