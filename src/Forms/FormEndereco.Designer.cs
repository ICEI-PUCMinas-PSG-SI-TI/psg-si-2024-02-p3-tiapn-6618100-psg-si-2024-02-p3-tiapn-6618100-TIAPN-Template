namespace BodyShape_TI.Forms
{
    partial class FormEndereco
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
            lblNome = new Label();
            txtLogradouro = new TextBox();
            label1 = new Label();
            maskedCEP = new MaskedTextBox();
            btnProcurar = new Button();
            txtBairro = new TextBox();
            label2 = new Label();
            txtLocalidade = new TextBox();
            label3 = new Label();
            txtUF = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            panel1.Size = new Size(474, 42);
            panel1.TabIndex = 1;
            // 
            // lblSair
            // 
            lblSair.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(428, 10);
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
            lblTitulo.Size = new Size(152, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Pesquisar Endereço";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(23, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 22);
            lblNome.TabIndex = 34;
            lblNome.Text = "CEP:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(23, 151);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.ReadOnly = true;
            txtLogradouro.Size = new Size(418, 27);
            txtLogradouro.TabIndex = 741;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(23, 126);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 36;
            label1.Text = "Logradouro:";
            // 
            // maskedCEP
            // 
            maskedCEP.Location = new Point(69, 76);
            maskedCEP.Mask = "00000-000";
            maskedCEP.Name = "maskedCEP";
            maskedCEP.Size = new Size(125, 27);
            maskedCEP.TabIndex = 1;
            maskedCEP.Leave += maskedCEP_Leave;
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.WhiteSmoke;
            btnProcurar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcurar.Location = new Point(209, 76);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(94, 29);
            btnProcurar.TabIndex = 39;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(23, 222);
            txtBairro.Name = "txtBairro";
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(418, 27);
            txtBairro.TabIndex = 742;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(24, 197);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 41;
            label2.Text = "Bairro:";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocalidade.Location = new Point(22, 293);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.ReadOnly = true;
            txtLocalidade.Size = new Size(297, 27);
            txtLocalidade.TabIndex = 743;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 10.8F);
            label3.Location = new Point(22, 268);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 43;
            label3.Text = "Localidade:";
            // 
            // txtUF
            // 
            txtUF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUF.Location = new Point(342, 293);
            txtUF.Name = "txtUF";
            txtUF.ReadOnly = true;
            txtUF.Size = new Size(99, 27);
            txtUF.TabIndex = 744;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 10.8F);
            label4.Location = new Point(342, 268);
            label4.Name = "label4";
            label4.Size = new Size(31, 22);
            label4.TabIndex = 45;
            label4.Text = "UF:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(24, 355);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 50);
            btnCancelar.TabIndex = 746;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(314, 355);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 745;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 433);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtUF);
            Controls.Add(label4);
            Controls.Add(txtLocalidade);
            Controls.Add(label3);
            Controls.Add(txtBairro);
            Controls.Add(label2);
            Controls.Add(btnProcurar);
            Controls.Add(maskedCEP);
            Controls.Add(txtLogradouro);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEndereco";
            Text = "FormEndereco";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtLogradouro;
        private Label label1;
        private MaskedTextBox maskedCEP;
        private Button btnProcurar;
        private TextBox txtBairro;
        private Label label2;
        private TextBox txtLocalidade;
        private Label label3;
        private TextBox txtUF;
        private Label label4;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}