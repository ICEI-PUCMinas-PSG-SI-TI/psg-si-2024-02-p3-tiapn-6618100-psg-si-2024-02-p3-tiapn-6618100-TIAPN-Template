using BodyShape_TI.Entities;
using BodyShape_TI.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BS_Projeto
{
    public partial class FormCadastroAluno : Form
    {
        ConexaoBD connection;

        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //INSERT
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO tbl_aluno
             (nome, data_nascimento, sexo, logradouro, numero, complemento, bairro, cidade, estado, telefone, tbl_Atendente_tbl_Funcionario_id)
             VALUES 
             (@nome, @data_nascimento, @sexo, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @telefone, @tbl_Atendente_tbl_Funcionario_id);";


            try
            {

                if (!DateTime.TryParse(txtDataNasc.Text, out DateTime dataNascimento))
                {
                    MessageBox.Show("Data de nascimento inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                if (txtGenero.Text != "M" && txtGenero.Text != "F")
                {
                    MessageBox.Show("O campo Sexo deve ser 'M' ou 'F'.");
                    return;
                }

                if (!long.TryParse(txtTelefone.Text, out long telefone) || txtTelefone.Text.Length < 10 || txtTelefone.Text.Length > 10)
                {
                    MessageBox.Show("O número de telefone é inválido. Deve conter 10 dígitos.");
                    return;
                }

                // Inicialização do comando
                using (MySqlCommand insert = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {

                    insert.Parameters.AddWithValue("@nome", txtNome.Text);
                    insert.Parameters.AddWithValue("@data_nascimento", dataNascimento.ToString("yyyy-MM-dd"));
                    insert.Parameters.AddWithValue("@sexo", txtGenero.Text);
                    insert.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                    insert.Parameters.AddWithValue("@numero", int.TryParse(txtNumero.Text, out int numero) ? numero : 0);
                    insert.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    insert.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    insert.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    insert.Parameters.AddWithValue("@estado", txtEstado.Text);
                    insert.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    insert.Parameters.AddWithValue("@tbl_Atendente_tbl_Funcionario_id", txtIDAtendente.Text);

                    connection.conexao.Open();
                    insert.ExecuteNonQuery();
                    connection.conexao.Close();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir os dados: {ex.Message}");
            }
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BodyShape_TI.Forms.FormCadastroAlunoPlano().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExcluirAluno formExcluirAluno = new FormExcluirAluno();

            formExcluirAluno.ShowDialog();
        }

        //UPDATE
        private void btnEditarPlano_Click(object sender, EventArgs e)
        {
            FormEditarAluno formEditarAluno = new FormEditarAluno();

            formEditarAluno.ShowDialog();
        }
    }
}
