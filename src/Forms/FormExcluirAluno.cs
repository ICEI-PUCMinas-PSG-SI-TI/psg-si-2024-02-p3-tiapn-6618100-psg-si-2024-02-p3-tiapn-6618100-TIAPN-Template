﻿using BodyShape_TI.Entities;
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
    public partial class FormExcluirAluno : Form
    {
        ConexaoBD connection;
        public FormExcluirAluno()
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
                        listViewAluno.Columns.Add("Atendente", 100, HorizontalAlignment.Center);

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

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do aluno foi inserido corretamente
            if (!int.TryParse(txtAlunoID.Text, out int idAluno))
            {
                MessageBox.Show("Por favor, insira um ID válido para excluir o aluno.");
                return;
            }

            // Confirmação de exclusão
            if (MessageBox.Show($"Tem certeza de que deseja excluir o aluno com ID {idAluno}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Query para excluir os exercícios relacionados à ficha
            string deleteExercicioQuery = "DELETE FROM tbl_exercicio WHERE tbl_Ficha_id IN (SELECT id FROM tbl_ficha WHERE tbl_Aluno_id = @idAluno);";

            // Query para excluir a relação de ficha com o aluno
            string deleteFichaQuery = "DELETE FROM tbl_ficha WHERE tbl_Aluno_id = @idAluno;";

            // Query para excluir a relação entre o aluno e o plano na tabela tbl_aluno_plano
            string deleteRelationQuery = "DELETE FROM tbl_aluno_plano WHERE tbl_Aluno_id = @idAluno;";

            // Query para excluir a relação de bioimpedância com o aluno
            string deleteBioimpedanciaQuery = "DELETE FROM tbl_bioimpedancia WHERE tbl_Aluno_id = @idAluno;";

            // Query para excluir o aluno da tabela de alunos (tbl_aluno)
            string deleteStudentQuery = "DELETE FROM tbl_aluno WHERE id = @idAluno;";

            try
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    // Inicia a conexão
                    var conexao = connection.IniciaConexaoBD();
                    command.Connection = conexao;
                    connection.conexao.Open();

                    // Excluindo os exercícios relacionados à ficha
                    command.CommandText = deleteExercicioQuery;
                    command.Parameters.AddWithValue("@idAluno", idAluno);
                    command.ExecuteNonQuery();

                    // Excluindo a relação de ficha com o aluno
                    command.CommandText = deleteFichaQuery;
                    command.ExecuteNonQuery();

                    // Excluindo a relação entre o aluno e o plano na tabela tbl_aluno_plano
                    command.CommandText = deleteRelationQuery;
                    command.ExecuteNonQuery();

                    // Excluindo a relação de bioimpedância com o aluno
                    command.CommandText = deleteBioimpedanciaQuery;
                    command.ExecuteNonQuery();

                    // Excluindo o aluno da tabela de alunos
                    command.CommandText = deleteStudentQuery;
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Aluno com ID {idAluno} excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum aluno encontrado com o ID fornecido.");
                    }

                    connection.conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o aluno: {ex.Message}");
            }
        }

        private void FormExcluirAluno_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
            CarregarListViewAluno();
        }

        private void txtPlanoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listViewAluno.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtAlunoID.Text = item.SubItems[0].Text;
            }
        }
    }
}
