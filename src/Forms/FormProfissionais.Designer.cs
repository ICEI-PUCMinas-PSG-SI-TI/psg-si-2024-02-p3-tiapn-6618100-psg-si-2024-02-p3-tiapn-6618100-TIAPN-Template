namespace BS_Projeto
{
    partial class FormProfissionais
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
            dataGridView1 = new DataGridView();
            txtPesquisar = new TextBox();
            btnEditar = new Button();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 209);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(628, 478);
            dataGridView1.TabIndex = 25;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.ScrollBar;
            txtPesquisar.Font = new Font("Impact", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(175, 141);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(323, 28);
            txtPesquisar.TabIndex = 22;
            txtPesquisar.Text = "Pesquisar...";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(308, 82);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 50);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(175, 82);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(127, 50);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormProfissionais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 850);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormProfissionais";
            Text = "FormProfissionais";
            Controls.SetChildIndex(btnCadastrar, 0);
            Controls.SetChildIndex(btnEditar, 0);
            Controls.SetChildIndex(txtPesquisar, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}