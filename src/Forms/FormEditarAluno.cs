using BodyShape_TI.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyShape_TI.Forms
{
    public partial class FormEditarAluno : Form
    {
        ConexaoBD connection;
        public FormEditarAluno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormEditarAluno_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlunoID.Text))
            {
                MessageBox.Show("Por favor, insira o ID do aluno para editar.");
                return;
            }

            string query = @"UPDATE tbl_aluno
                 SET nome = @nome,
                     data_nascimento = @data_nascimento,
                     sexo = @sexo,
                     logradouro = @logradouro,
                     numero = @numero,
                     complemento = @complemento,
                     bairro = @bairro,
                     cidade = @cidade,
                     estado = @estado,
                     telefone = @telefone,
                     tbl_Atendente_tbl_Funcionario_id = @tbl_Atendente_tbl_Funcionario_id
                 WHERE id = @id;";

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

                if (!long.TryParse(txtTelefone.Text, out long telefone) || txtTelefone.Text.Length != 10)
                {
                    MessageBox.Show("O número de telefone é inválido. Deve conter exatamente 10 dígitos.");
                    return;
                }

                using (MySqlCommand update = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    // Define os parâmetros para a query
                    update.Parameters.AddWithValue("@nome", txtNome.Text);
                    update.Parameters.AddWithValue("@data_nascimento", dataNascimento.ToString("yyyy-MM-dd"));
                    update.Parameters.AddWithValue("@sexo", txtGenero.Text);
                    update.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                    update.Parameters.AddWithValue("@numero", int.TryParse(txtNumero.Text, out int numero) ? numero : 0);
                    update.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    update.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    update.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    update.Parameters.AddWithValue("@estado", txtEstado.Text);
                    update.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    update.Parameters.AddWithValue("@tbl_Atendente_tbl_Funcionario_id", txtIDAtendente.Text);
                    update.Parameters.AddWithValue("@id", txtAlunoID.Text);

                    connection.conexao.Open();
                    int rowsAffected = update.ExecuteNonQuery();
                    connection.conexao.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Aluno atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum aluno foi encontrado com o ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados do aluno: {ex.Message}");
            }
        }
    }
}
