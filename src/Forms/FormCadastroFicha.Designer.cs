namespace BodyShape_TI.Forms
{
    partial class FormCadastroFicha
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
            txtIdEducador = new TextBox();
            lblEducadorFisico = new Label();
            txtIdAluno = new TextBox();
            lblIdAluno = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblTitulo.Size = new Size(138, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cadastro de Ficha";
            // 
            // txtIdEducador
            // 
            txtIdEducador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdEducador.Location = new Point(251, 178);
            txtIdEducador.Name = "txtIdEducador";
            txtIdEducador.ReadOnly = true;
            txtIdEducador.Size = new Size(212, 27);
            txtIdEducador.TabIndex = 37;
            // 
            // lblEducadorFisico
            // 
            lblEducadorFisico.AutoSize = true;
            lblEducadorFisico.BackColor = Color.Transparent;
            lblEducadorFisico.Font = new Font("Impact", 10.8F);
            lblEducadorFisico.Location = new Point(251, 156);
            lblEducadorFisico.Name = "lblEducadorFisico";
            lblEducadorFisico.Size = new Size(145, 22);
            lblEducadorFisico.TabIndex = 36;
            lblEducadorFisico.Text = "ID Educador Físico:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdAluno.Location = new Point(46, 178);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.ReadOnly = true;
            txtIdAluno.Size = new Size(175, 27);
            txtIdAluno.TabIndex = 35;
            // 
            // lblIdAluno
            // 
            lblIdAluno.AutoSize = true;
            lblIdAluno.BackColor = Color.Transparent;
            lblIdAluno.Font = new Font("Impact", 10.8F);
            lblIdAluno.Location = new Point(46, 156);
            lblIdAluno.Name = "lblIdAluno";
            lblIdAluno.Size = new Size(73, 22);
            lblIdAluno.TabIndex = 34;
            lblIdAluno.Text = "ID Aluno:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(46, 99);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(417, 27);
            txtNome.TabIndex = 33;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(46, 77);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 22);
            lblNome.TabIndex = 32;
            lblNome.Text = "Nome:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Black;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ButtonHighlight;
            btnAdicionar.Location = new Point(46, 225);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(127, 34);
            btnAdicionar.TabIndex = 44;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Black;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(336, 225);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(127, 34);
            btnExcluir.TabIndex = 43;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(193, 225);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 34);
            btnEditar.TabIndex = 45;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(46, 583);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 50);
            btnCancelar.TabIndex = 47;
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
            btnSalvar.Location = new Point(336, 583);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 50);
            btnSalvar.TabIndex = 46;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 267);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(417, 291);
            dataGridView1.TabIndex = 48;
            // 
            // FormCadastroFicha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 656);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(txtIdEducador);
            Controls.Add(lblEducadorFisico);
            Controls.Add(txtIdAluno);
            Controls.Add(lblIdAluno);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroFicha";
            Text = "FormCadastroFicha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private TextBox txtIdEducador;
        private Label lblEducadorFisico;
        private TextBox txtIdAluno;
        private Label lblIdAluno;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnSalvar;
        private DataGridView dataGridView1;
    }
}