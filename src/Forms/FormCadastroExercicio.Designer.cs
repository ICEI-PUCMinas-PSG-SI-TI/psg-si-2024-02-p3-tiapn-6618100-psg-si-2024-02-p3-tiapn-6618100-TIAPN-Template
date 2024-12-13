namespace BodyShape_TI.Forms
{
    partial class FormCadastroExercicio
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
            txtNome = new TextBox();
            lblNome = new Label();
            textBox1 = new TextBox();
            lblRepeticao = new Label();
            textBox2 = new TextBox();
            lblIntervalo = new Label();
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
            panel1.Size = new Size(518, 42);
            panel1.TabIndex = 2;
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
            lblTitulo.Size = new Size(165, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Exercício";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(46, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 27);
            txtNome.TabIndex = 1;
            txtNome.Tag = "NomeExercicio";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(46, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 28;
            lblNome.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(46, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            textBox1.Tag = "Repeticoes";
            // 
            // lblRepeticao
            // 
            lblRepeticao.AutoSize = true;
            lblRepeticao.BackColor = Color.Transparent;
            lblRepeticao.Font = new Font("Impact", 10.8F);
            lblRepeticao.Location = new Point(46, 153);
            lblRepeticao.Name = "lblRepeticao";
            lblRepeticao.Size = new Size(88, 22);
            lblRepeticao.TabIndex = 30;
            lblRepeticao.Text = "Repetição:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(288, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 3;
            textBox2.Tag = "Intervalo";
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Impact", 10.8F);
            lblIntervalo.Location = new Point(288, 153);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(78, 22);
            lblIntervalo.TabIndex = 32;
            lblIntervalo.Text = "Intervalo:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(46, 236);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Black;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(336, 236);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroExercicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 312);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(textBox2);
            Controls.Add(lblIntervalo);
            Controls.Add(textBox1);
            Controls.Add(lblRepeticao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroExercicio";
            Text = "FormCadastroExercicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox textBox1;
        private Label lblRepeticao;
        private TextBox textBox2;
        private Label lblIntervalo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}