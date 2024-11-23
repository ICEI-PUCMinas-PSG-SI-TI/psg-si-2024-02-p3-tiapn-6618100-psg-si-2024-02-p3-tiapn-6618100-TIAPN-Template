namespace BodyShape_TI.Forms
{
    partial class FormExcluirPlano
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
            botaoExcluir = new Button();
            txtPlanoID = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            panel1 = new Panel();
            lblSair = new Label();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // botaoExcluir
            // 
            botaoExcluir.BackColor = Color.Black;
            botaoExcluir.Cursor = Cursors.Hand;
            botaoExcluir.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaoExcluir.ForeColor = SystemColors.ButtonHighlight;
            botaoExcluir.Location = new Point(468, 126);
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.Size = new Size(111, 38);
            botaoExcluir.TabIndex = 146;
            botaoExcluir.Text = "Excluir";
            botaoExcluir.UseVisualStyleBackColor = false;
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // txtPlanoID
            // 
            txtPlanoID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlanoID.Location = new Point(325, 70);
            txtPlanoID.Margin = new Padding(3, 2, 3, 2);
            txtPlanoID.Name = "txtPlanoID";
            txtPlanoID.Size = new Size(149, 23);
            txtPlanoID.TabIndex = 144;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 10.8F);
            label2.Location = new Point(325, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 145;
            label2.Text = "Informe o ID do Plano:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(221, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 38);
            btnCancelar.TabIndex = 143;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(174, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 32);
            panel1.TabIndex = 138;
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
            lblTitulo.Size = new Size(89, 19);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Excluir Plano";
            // 
            // FormExcluirPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoExcluir);
            Controls.Add(txtPlanoID);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Name = "FormExcluirPlano";
            Text = "FormExcluirPlano";
            Load += FormExcluirPlano_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoExcluir;
        private TextBox txtPlanoID;
        private Label label2;
        private Button btnCancelar;
        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
    }
}