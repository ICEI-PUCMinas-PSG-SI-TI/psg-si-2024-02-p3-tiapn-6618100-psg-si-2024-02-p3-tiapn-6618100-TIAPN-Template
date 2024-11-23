namespace BodyShape_TI.Forms
{
    partial class FormEditarPlano
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
            txtTipoPlano = new TextBox();
            label1 = new Label();
            txtValorPlano = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            button2 = new Button();
            txtPlanoID = new TextBox();
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
            btnCancelar.Location = new Point(207, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 134;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTipoPlano
            // 
            txtTipoPlano.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTipoPlano.Location = new Point(416, 165);
            txtTipoPlano.Margin = new Padding(3, 2, 3, 2);
            txtTipoPlano.Name = "txtTipoPlano";
            txtTipoPlano.Size = new Size(149, 23);
            txtTipoPlano.TabIndex = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 10.8F);
            label1.Location = new Point(416, 144);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 129;
            label1.Text = "Tipo do Plano:";
            // 
            // txtValorPlano
            // 
            txtValorPlano.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValorPlano.Location = new Point(207, 165);
            txtValorPlano.Margin = new Padding(3, 2, 3, 2);
            txtValorPlano.Name = "txtValorPlano";
            txtValorPlano.Size = new Size(149, 23);
            txtValorPlano.TabIndex = 127;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(207, 144);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(83, 19);
            lblNome.TabIndex = 128;
            lblNome.Text = "Valor Plano:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(158, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 32);
            panel1.TabIndex = 126;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(416, 8);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(18, 18);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(11, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(84, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar Plano";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(454, 196);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 137;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtPlanoID
            // 
            txtPlanoID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlanoID.Location = new Point(309, 70);
            txtPlanoID.Margin = new Padding(3, 2, 3, 2);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(149, 23);
            txtPlanoID.TabIndex = 135;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(309, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 136;
            label2.Text = "Informe o ID do Plano:";
            // 
            // FormEditarPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(txtPlanoID);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(txtTipoPlano);
            Controls.Add(label1);
            Controls.Add(txtValorPlano);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Name = "FormEditarPlano";
            Text = "FormEditarPlano";
            Load += FormEditarPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private TextBox txtTipoPlano;
        private Label label1;
        private TextBox txtValorPlano;
        private Label lblNome;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private Button button2;
        private TextBox txtPlanoID;
        private Label label2;
    }
}