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
            btnSalvar = new Button();
            label1 = new Label();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            txtDataInicioPlano = new MaskedTextBox();
            lblDataNascimento = new Label();
            txtDataFimPlano = new MaskedTextBox();
            label2 = new Label();
            txtAlunoID = new TextBox();
            txtPlanoID = new TextBox();
            listViewPlanos = new ListView();
            listViewAlunos = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(508, 367);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 51);
            btnCancelar.TabIndex = 134;
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
            btnSalvar.Location = new Point(672, 367);
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
            label1.Location = new Point(373, 64);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 129;
            label1.Text = "Aluno (ID):";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(13, 64);
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
            panel1.Size = new Size(1039, 43);
            panel1.TabIndex = 126;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(820, 12);
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
            lblTitulo.Size = new Size(198, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Associar aluno a um plano";
            // 
            // txtDataInicioPlano
            // 
            txtDataInicioPlano.Location = new Point(155, 298);
            txtDataInicioPlano.Mask = "00/00/0000";
            txtDataInicioPlano.Name = "txtDataInicioPlano";
            txtDataInicioPlano.Size = new Size(96, 27);
            txtDataInicioPlano.TabIndex = 135;
            txtDataInicioPlano.ValidatingType = typeof(DateTime);
            txtDataInicioPlano.KeyPress += txtDataInicioPlano_KeyPress;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.BackColor = Color.Transparent;
            lblDataNascimento.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataNascimento.Location = new Point(23, 300);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(126, 25);
            lblDataNascimento.TabIndex = 136;
            lblDataNascimento.Text = "Data de início:";
            // 
            // txtDataFimPlano
            // 
            txtDataFimPlano.Location = new Point(155, 331);
            txtDataFimPlano.Mask = "00/00/0000";
            txtDataFimPlano.Name = "txtDataFimPlano";
            txtDataFimPlano.Size = new Size(96, 27);
            txtDataFimPlano.TabIndex = 137;
            txtDataFimPlano.ValidatingType = typeof(DateTime);
            txtDataFimPlano.KeyPress += txtDataFimPlano_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 333);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 138;
            label2.Text = "Data de fim:";
            // 
            // txtAlunoID
            // 
            txtAlunoID.Location = new Point(462, 62);
            txtAlunoID.Name = "txtAlunoID";
            txtAlunoID.Size = new Size(29, 27);
            txtAlunoID.TabIndex = 132;
            txtAlunoID.KeyPress += txtAlunoID_KeyPress;
            // 
            // txtPlanoID
            // 
            txtPlanoID.Location = new Point(103, 62);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(29, 27);
            txtPlanoID.TabIndex = 127;
            txtPlanoID.KeyPress += txtPlanoID_KeyPress;
            // 
            // listViewPlanos
            // 
            listViewPlanos.Location = new Point(13, 93);
            listViewPlanos.Margin = new Padding(3, 4, 3, 4);
            listViewPlanos.Name = "listViewPlanos";
            listViewPlanos.Size = new Size(313, 183);
            listViewPlanos.TabIndex = 139;
            listViewPlanos.UseCompatibleStateImageBehavior = false;
            listViewPlanos.SelectedIndexChanged += listViewPlanos_SelectedIndexChanged;
            // 
            // listViewAlunos
            // 
            listViewAlunos.Location = new Point(373, 93);
            listViewAlunos.Margin = new Padding(3, 4, 3, 4);
            listViewAlunos.Name = "listViewAlunos";
            listViewAlunos.Size = new Size(438, 183);
            listViewAlunos.TabIndex = 140;
            listViewAlunos.UseCompatibleStateImageBehavior = false;
            listViewAlunos.SelectedIndexChanged += listViewAlunos_SelectedIndexChanged;
            // 
            // FormCadastroAlunoPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 441);
            Controls.Add(listViewAlunos);
            Controls.Add(listViewPlanos);
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
        private Button btnSalvar;
        private Label label1;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private MaskedTextBox txtDataInicioPlano;
        private Label lblDataNascimento;
        private MaskedTextBox txtDataFimPlano;
        private Label label2;
        private TextBox txtAlunoID;
        private TextBox txtPlanoID;
        private ListView listViewPlanos;
        private ListView listViewAlunos;
    }
}