﻿namespace BodyShape_TI.Forms
{
    partial class FormCadastroBioimpedância
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
            lbl_Altura = new Label();
            btn_Cadastrar = new Button();
            lbl_Educador_Fisico = new Label();
            lblNome = new Label();
            lbl_Peso = new Label();
            txt_Aluno = new TextBox();
            lbl_Gordura = new Label();
            txt_gordura = new TextBox();
            txt_Peso = new TextBox();
            txt_Altura = new TextBox();
            lbl_Massa_Magra = new Label();
            txt_Massa_Magra = new TextBox();
            lbl_Aluno = new Label();
            txt_Id_Aluno = new TextBox();
            txt_Id_Educador_Fisico = new TextBox();
            lbl_Atendente = new Label();
            txt_Id_Atendente = new TextBox();
            btn_Editar = new Button();
            btn_Deletar = new Button();
            btn_Reset = new Button();
            btn_Pesquisar = new Button();
            lst_Bioimpedancias = new ListView();
            lst_Educador_Fisico = new ListView();
            lst_Alunos = new ListView();
            lst_Atendentes = new ListView();
            lbl_Educ_Fisico = new Label();
            lbl_Alunos = new Label();
            lbl_Atendentes = new Label();
            btn_Cancelar = new Button();
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
            panel1.Size = new Size(1155, 42);
            panel1.TabIndex = 1;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.DarkSlateGray;
            lblSair.Location = new Point(1112, 11);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(22, 21);
            lblSair.TabIndex = 2;
            lblSair.Text = "X";
            lblSair.Click += lblSair_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Impact", 10.8F);
            lblTitulo.Location = new Point(13, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bioimpedância";
            // 
            // lbl_Altura
            // 
            lbl_Altura.AutoSize = true;
            lbl_Altura.BackColor = Color.Transparent;
            lbl_Altura.Font = new Font("Impact", 10.8F);
            lbl_Altura.Location = new Point(49, 199);
            lbl_Altura.Name = "lbl_Altura";
            lbl_Altura.Size = new Size(57, 22);
            lbl_Altura.TabIndex = 44;
            lbl_Altura.Text = "Altura:";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.Black;
            btn_Cadastrar.Cursor = Cursors.Hand;
            btn_Cadastrar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cadastrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cadastrar.Location = new Point(258, 532);
            btn_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(127, 50);
            btn_Cadastrar.TabIndex = 41;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // lbl_Educador_Fisico
            // 
            lbl_Educador_Fisico.AutoSize = true;
            lbl_Educador_Fisico.BackColor = Color.Transparent;
            lbl_Educador_Fisico.Font = new Font("Impact", 10.8F);
            lbl_Educador_Fisico.Location = new Point(49, 448);
            lbl_Educador_Fisico.Name = "lbl_Educador_Fisico";
            lbl_Educador_Fisico.Size = new Size(145, 22);
            lbl_Educador_Fisico.TabIndex = 30;
            lbl_Educador_Fisico.Text = "ID Educador Físico:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Impact", 10.8F);
            lblNome.Location = new Point(426, 72);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(102, 22);
            lblNome.TabIndex = 26;
            lblNome.Text = "Nome Aluno: ";
            // 
            // lbl_Peso
            // 
            lbl_Peso.AutoSize = true;
            lbl_Peso.BackColor = Color.Transparent;
            lbl_Peso.Font = new Font("Impact", 10.8F);
            lbl_Peso.Location = new Point(49, 123);
            lbl_Peso.Name = "lbl_Peso";
            lbl_Peso.Size = new Size(49, 22);
            lbl_Peso.TabIndex = 47;
            lbl_Peso.Text = "Peso:";
            // 
            // txt_Aluno
            // 
            txt_Aluno.Location = new Point(544, 71);
            txt_Aluno.Name = "txt_Aluno";
            txt_Aluno.Size = new Size(452, 27);
            txt_Aluno.TabIndex = 49;
            // 
            // lbl_Gordura
            // 
            lbl_Gordura.AutoSize = true;
            lbl_Gordura.BackColor = Color.Transparent;
            lbl_Gordura.Font = new Font("Impact", 10.8F);
            lbl_Gordura.Location = new Point(49, 53);
            lbl_Gordura.Name = "lbl_Gordura";
            lbl_Gordura.Size = new Size(72, 22);
            lbl_Gordura.TabIndex = 50;
            lbl_Gordura.Text = "Gordura:";
            // 
            // txt_gordura
            // 
            txt_gordura.Location = new Point(49, 78);
            txt_gordura.Name = "txt_gordura";
            txt_gordura.Size = new Size(125, 27);
            txt_gordura.TabIndex = 51;
            // 
            // txt_Peso
            // 
            txt_Peso.Location = new Point(48, 148);
            txt_Peso.Name = "txt_Peso";
            txt_Peso.Size = new Size(125, 27);
            txt_Peso.TabIndex = 52;
            // 
            // txt_Altura
            // 
            txt_Altura.Location = new Point(49, 234);
            txt_Altura.Name = "txt_Altura";
            txt_Altura.Size = new Size(125, 27);
            txt_Altura.TabIndex = 53;
            // 
            // lbl_Massa_Magra
            // 
            lbl_Massa_Magra.AutoSize = true;
            lbl_Massa_Magra.BackColor = Color.Transparent;
            lbl_Massa_Magra.Font = new Font("Impact", 10.8F);
            lbl_Massa_Magra.Location = new Point(49, 281);
            lbl_Massa_Magra.Name = "lbl_Massa_Magra";
            lbl_Massa_Magra.Size = new Size(110, 22);
            lbl_Massa_Magra.TabIndex = 54;
            lbl_Massa_Magra.Text = "Massa Magra:";
            // 
            // txt_Massa_Magra
            // 
            txt_Massa_Magra.Location = new Point(48, 320);
            txt_Massa_Magra.Name = "txt_Massa_Magra";
            txt_Massa_Magra.Size = new Size(125, 27);
            txt_Massa_Magra.TabIndex = 55;
            // 
            // lbl_Aluno
            // 
            lbl_Aluno.AutoSize = true;
            lbl_Aluno.BackColor = Color.Transparent;
            lbl_Aluno.Font = new Font("Impact", 10.8F);
            lbl_Aluno.Location = new Point(49, 367);
            lbl_Aluno.Name = "lbl_Aluno";
            lbl_Aluno.Size = new Size(73, 22);
            lbl_Aluno.TabIndex = 56;
            lbl_Aluno.Text = "ID Aluno:";
            // 
            // txt_Id_Aluno
            // 
            txt_Id_Aluno.Location = new Point(48, 404);
            txt_Id_Aluno.Name = "txt_Id_Aluno";
            txt_Id_Aluno.ReadOnly = true;
            txt_Id_Aluno.Size = new Size(125, 27);
            txt_Id_Aluno.TabIndex = 57;
            // 
            // txt_Id_Educador_Fisico
            // 
            txt_Id_Educador_Fisico.Location = new Point(49, 486);
            txt_Id_Educador_Fisico.Name = "txt_Id_Educador_Fisico";
            txt_Id_Educador_Fisico.ReadOnly = true;
            txt_Id_Educador_Fisico.Size = new Size(125, 27);
            txt_Id_Educador_Fisico.TabIndex = 58;
            // 
            // lbl_Atendente
            // 
            lbl_Atendente.AutoSize = true;
            lbl_Atendente.BackColor = Color.Transparent;
            lbl_Atendente.Font = new Font("Impact", 10.8F);
            lbl_Atendente.Location = new Point(49, 530);
            lbl_Atendente.Name = "lbl_Atendente";
            lbl_Atendente.Size = new Size(105, 22);
            lbl_Atendente.TabIndex = 59;
            lbl_Atendente.Text = "ID Atendente:";
            // 
            // txt_Id_Atendente
            // 
            txt_Id_Atendente.Location = new Point(48, 555);
            txt_Id_Atendente.Name = "txt_Id_Atendente";
            txt_Id_Atendente.ReadOnly = true;
            txt_Id_Atendente.Size = new Size(125, 27);
            txt_Id_Atendente.TabIndex = 60;
            // 
            // btn_Editar
            // 
            btn_Editar.BackColor = Color.Black;
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar.ForeColor = SystemColors.ButtonHighlight;
            btn_Editar.Location = new Point(401, 532);
            btn_Editar.Margin = new Padding(3, 4, 3, 4);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(127, 50);
            btn_Editar.TabIndex = 61;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Deletar
            // 
            btn_Deletar.BackColor = Color.Black;
            btn_Deletar.Cursor = Cursors.Hand;
            btn_Deletar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Deletar.ForeColor = SystemColors.ButtonHighlight;
            btn_Deletar.Location = new Point(544, 532);
            btn_Deletar.Margin = new Padding(3, 4, 3, 4);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(127, 50);
            btn_Deletar.TabIndex = 62;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = false;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.Black;
            btn_Reset.Cursor = Cursors.Hand;
            btn_Reset.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Reset.ForeColor = SystemColors.ButtonHighlight;
            btn_Reset.Location = new Point(688, 532);
            btn_Reset.Margin = new Padding(3, 4, 3, 4);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(127, 50);
            btn_Reset.TabIndex = 63;
            btn_Reset.Text = "Resetar";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.Black;
            btn_Pesquisar.Cursor = Cursors.Hand;
            btn_Pesquisar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = SystemColors.ButtonHighlight;
            btn_Pesquisar.Location = new Point(1022, 53);
            btn_Pesquisar.Margin = new Padding(3, 4, 3, 4);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(94, 50);
            btn_Pesquisar.TabIndex = 64;
            btn_Pesquisar.Text = "Buscar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // lst_Bioimpedancias
            // 
            lst_Bioimpedancias.Location = new Point(426, 123);
            lst_Bioimpedancias.Name = "lst_Bioimpedancias";
            lst_Bioimpedancias.Size = new Size(690, 180);
            lst_Bioimpedancias.TabIndex = 65;
            lst_Bioimpedancias.UseCompatibleStateImageBehavior = false;
            lst_Bioimpedancias.SelectedIndexChanged += lst_Bioimpedancias_SelectedIndexChanged;
            // 
            // lst_Educador_Fisico
            // 
            lst_Educador_Fisico.Location = new Point(226, 346);
            lst_Educador_Fisico.Name = "lst_Educador_Fisico";
            lst_Educador_Fisico.Size = new Size(302, 179);
            lst_Educador_Fisico.TabIndex = 66;
            lst_Educador_Fisico.UseCompatibleStateImageBehavior = false;
            lst_Educador_Fisico.SelectedIndexChanged += lst_Educador_Fisico_SelectedIndexChanged;
            // 
            // lst_Alunos
            // 
            lst_Alunos.Location = new Point(543, 346);
            lst_Alunos.Name = "lst_Alunos";
            lst_Alunos.Size = new Size(292, 179);
            lst_Alunos.TabIndex = 67;
            lst_Alunos.UseCompatibleStateImageBehavior = false;
            lst_Alunos.SelectedIndexChanged += lst_Alunos_SelectedIndexChanged_1;
            // 
            // lst_Atendentes
            // 
            lst_Atendentes.Location = new Point(841, 346);
            lst_Atendentes.Name = "lst_Atendentes";
            lst_Atendentes.Size = new Size(292, 179);
            lst_Atendentes.TabIndex = 68;
            lst_Atendentes.UseCompatibleStateImageBehavior = false;
            lst_Atendentes.SelectedIndexChanged += lst_Atendentes_SelectedIndexChanged_1;
            // 
            // lbl_Educ_Fisico
            // 
            lbl_Educ_Fisico.AutoSize = true;
            lbl_Educ_Fisico.BackColor = Color.Transparent;
            lbl_Educ_Fisico.Font = new Font("Impact", 10.8F);
            lbl_Educ_Fisico.Location = new Point(226, 320);
            lbl_Educ_Fisico.Name = "lbl_Educ_Fisico";
            lbl_Educ_Fisico.Size = new Size(148, 22);
            lbl_Educ_Fisico.TabIndex = 69;
            lbl_Educ_Fisico.Text = "Educadores Fisicos";
            // 
            // lbl_Alunos
            // 
            lbl_Alunos.AutoSize = true;
            lbl_Alunos.BackColor = Color.Transparent;
            lbl_Alunos.Font = new Font("Impact", 10.8F);
            lbl_Alunos.Location = new Point(543, 320);
            lbl_Alunos.Name = "lbl_Alunos";
            lbl_Alunos.Size = new Size(59, 22);
            lbl_Alunos.TabIndex = 70;
            lbl_Alunos.Text = "Alunos";
            // 
            // lbl_Atendentes
            // 
            lbl_Atendentes.AutoSize = true;
            lbl_Atendentes.BackColor = Color.Transparent;
            lbl_Atendentes.Font = new Font("Impact", 10.8F);
            lbl_Atendentes.Location = new Point(841, 320);
            lbl_Atendentes.Name = "lbl_Atendentes";
            lbl_Atendentes.Size = new Size(91, 22);
            lbl_Atendentes.TabIndex = 71;
            lbl_Atendentes.Text = "Atendentes";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Black;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cancelar.Location = new Point(832, 532);
            btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(127, 50);
            btn_Cancelar.TabIndex = 72;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // FormCadastroBioimpedância
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 619);
            Controls.Add(btn_Cancelar);
            Controls.Add(lbl_Atendentes);
            Controls.Add(lbl_Alunos);
            Controls.Add(lbl_Educ_Fisico);
            Controls.Add(lst_Atendentes);
            Controls.Add(lst_Alunos);
            Controls.Add(lst_Educador_Fisico);
            Controls.Add(lst_Bioimpedancias);
            Controls.Add(btn_Pesquisar);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_Editar);
            Controls.Add(txt_Id_Atendente);
            Controls.Add(lbl_Atendente);
            Controls.Add(txt_Id_Educador_Fisico);
            Controls.Add(txt_Id_Aluno);
            Controls.Add(lbl_Aluno);
            Controls.Add(txt_Massa_Magra);
            Controls.Add(lbl_Massa_Magra);
            Controls.Add(txt_Altura);
            Controls.Add(txt_Peso);
            Controls.Add(txt_gordura);
            Controls.Add(lbl_Gordura);
            Controls.Add(txt_Aluno);
            Controls.Add(lbl_Peso);
            Controls.Add(lbl_Altura);
            Controls.Add(btn_Cadastrar);
            Controls.Add(lbl_Educador_Fisico);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroBioimpedância";
            Text = "FormCadastroBioimpedância";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblTitulo;
        private Label lbl_Altura;
        private MaskedTextBox maskedTextBox1;
        private Button btn_Cadastrar;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lbl_Educador_Fisico;
        private Label lblNome;
        private Label lbl_Peso;
        private TextBox txt_Aluno;
        private Label lbl_Gordura;
        private TextBox txt_gordura;
        private TextBox txt_Peso;
        private TextBox txt_Altura;
        private Label lbl_Massa_Magra;
        private TextBox txt_Massa_Magra;
        private Label lbl_Aluno;
        private TextBox txt_Id_Aluno;
        private TextBox txt_Id_Educador_Fisico;
        private Label lbl_Atendente;
        private TextBox txt_Id_Atendente;
        private Button btn_Editar;
        private Button btn_Deletar;
        private Button btn_Reset;
        private Button btn_Pesquisar;
        private ListView lst_Bioimpedancias;
        private ListView lst_Educador_Fisico;
        private ListView lst_Alunos;
        private ListView lst_Atendentes;
        private Label lbl_Educ_Fisico;
        private Label lbl_Alunos;
        private Label lbl_Atendentes;
        private Button btn_Cancelar;
    }
}