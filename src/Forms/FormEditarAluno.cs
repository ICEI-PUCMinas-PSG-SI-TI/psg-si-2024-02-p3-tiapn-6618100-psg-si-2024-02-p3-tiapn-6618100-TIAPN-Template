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
            CarregarListViewAluno();
        }

        private void CarregarListViewAluno()
        {
            listViewAluno.View = View.Details;
            listViewAluno.LabelEdit = true;
            listViewAluno.AllowColumnReorder = true;
            listViewAluno.FullRowSelect = true;
            listViewAluno.GridLines = true;

            try
            {
                string query = "SELECT id, nome, data_nascimento, sexo, logradouro, numero, complemento, bairro, cidade, estado, telefone, tbl_Atendente_tbl_Funcionario_id FROM tbl_Aluno";
                using (MySqlCommand command = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    connection.conexao.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        listViewAluno.Items.Clear(); // Limpa o ListView
                        listViewAluno.Columns.Clear();

                        // Adiciona colunas ao ListView para todos os campos da consulta
                        listViewAluno.Columns.Add("ID", 50, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Nome", 150, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Data Nascimento", 100, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Sexo", 50, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Logradouro", 150, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Número", 70, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Complemento", 150, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Bairro", 100, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Cidade", 100, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Estado", 50, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Telefone", 100, HorizontalAlignment.Center);
                        listViewAluno.Columns.Add("Atendente", 100,HorizontalAlignment.Center);

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["id"].ToString());
                            item.SubItems.Add(reader["nome"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["data_nascimento"]).ToString("dd/MM/yyyy"));
                            item.SubItems.Add(reader["sexo"].ToString());
                            item.SubItems.Add(reader["logradouro"].ToString());
                            item.SubItems.Add(reader["numero"].ToString());
                            item.SubItems.Add(reader["complemento"].ToString());
                            item.SubItems.Add(reader["bairro"].ToString());
                            item.SubItems.Add(reader["cidade"].ToString());
                            item.SubItems.Add(reader["estado"].ToString());
                            item.SubItems.Add(reader["telefone"].ToString());
                            item.SubItems.Add(reader["tbl_Atendente_tbl_Funcionario_id"].ToString());
                            listViewAluno.Items.Add(item);
                        }
                    }
                    connection.conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os alunos: {ex.Message}");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlunoID.Text))
            {
                MessageBox.Show("Por favor, insira o ID do aluno para editar.");
                return;
            }

            string query = @"UPDATE tbl_aluno
                     SET nome = IFNULL(NULLIF(@nome, ''), nome),
                         data_nascimento = IFNULL(NULLIF(@data_nascimento, ''), data_nascimento),
                         sexo = IFNULL(NULLIF(@sexo, ''), sexo),
                         logradouro = IFNULL(NULLIF(@logradouro, ''), logradouro),
                         numero = IFNULL(NULLIF(@numero, ''), numero),
                         complemento = IFNULL(NULLIF(@complemento, ''), complemento),
                         bairro = IFNULL(NULLIF(@bairro, ''), bairro),
                         cidade = IFNULL(NULLIF(@cidade, ''), cidade),
                         estado = IFNULL(NULLIF(@estado, ''), estado),
                         telefone = IFNULL(NULLIF(@telefone, ''), telefone),
                         tbl_Atendente_tbl_Funcionario_id = IFNULL(NULLIF(@tbl_Atendente_tbl_Funcionario_id, ''), tbl_Atendente_tbl_Funcionario_id)
                     WHERE id = @id;";

            try
            {
                // Validações para os campos
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

                string funcionarioID = txtFuncionarioID.Text; // Supondo que você tenha um campo txtFuncionarioID
                if (string.IsNullOrWhiteSpace(funcionarioID))
                {
                    funcionarioID = "1"; 
                }

                using (MySqlCommand update = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    // Define os parâmetros para a query
                    update.Parameters.AddWithValue("@nome", txtNome.Text);
                    update.Parameters.AddWithValue("@data_nascimento", string.IsNullOrWhiteSpace(txtDataNasc.Text) ? DBNull.Value : (object)dataNascimento.ToString("yyyy-MM-dd"));
                    update.Parameters.AddWithValue("@sexo", txtGenero.Text);
                    update.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                    update.Parameters.AddWithValue("@numero", string.IsNullOrWhiteSpace(txtNumero.Text) ? DBNull.Value : (object)(int.TryParse(txtNumero.Text, out int numero) ? numero : 0));
                    update.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    update.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    update.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    update.Parameters.AddWithValue("@estado", txtEstado.Text);
                    update.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    update.Parameters.AddWithValue("@id", txtAlunoID.Text);
                    update.Parameters.AddWithValue("@tbl_Atendente_tbl_Funcionario_id", funcionarioID); // Atribuindo o valor do atendente

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há algum item selecionado
            if (listViewAluno.SelectedItems.Count > 0)
            {
                // Obtém o primeiro item selecionado (caso tenha mais de um selecionado)
                ListViewItem selectedItem = listViewAluno.SelectedItems[0];

                // Preenche os campos de texto com os dados do aluno selecionado
                txtAlunoID.Text = selectedItem.SubItems[0].Text;
                txtNome.Text = selectedItem.SubItems[1].Text; // Preenche o campo "Nome"
                txtDataNasc.Text = selectedItem.SubItems[2].Text;
                txtGenero.Text = selectedItem.SubItems[3].Text;
                txtLogradouro.Text = selectedItem.SubItems[4].Text;
                txtNumero.Text = selectedItem.SubItems[5].Text;
                txtComplemento.Text = selectedItem.SubItems[6].Text;
                txtBairro.Text = selectedItem.SubItems[7].Text;
                txtCidade.Text = selectedItem.SubItems[8].Text;
                txtEstado.Text = selectedItem.SubItems[9].Text;
                txtTelefone.Text = selectedItem.SubItems[10].Text; // Atualiza o telefone
                txtFuncionarioID.Text = selectedItem.SubItems[11].Text;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
