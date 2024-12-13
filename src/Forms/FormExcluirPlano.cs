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
    public partial class FormExcluirPlano : Form
    {
        ConexaoBD connection;
        public FormExcluirPlano()
        {
            InitializeComponent();
        }

        private void CarregarListViewPlanos()
        {
            listViewPlanos.View = View.Details;
            listViewPlanos.LabelEdit = true;
            listViewPlanos.AllowColumnReorder = true;
            listViewPlanos.FullRowSelect = true;
            listViewPlanos.GridLines = true;

            try
            {
                string query = "SELECT id, valor, tipo_plano FROM tbl_Plano";
                using (MySqlCommand command = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    connection.conexao.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        listViewPlanos.Items.Clear(); // Limpa o ListView
                        listViewPlanos.Columns.Clear();

                        // Adiciona colunas ao ListView
                        listViewPlanos.Columns.Add("ID", 50, HorizontalAlignment.Center);
                        listViewPlanos.Columns.Add("Valor", 100, HorizontalAlignment.Center);
                        listViewPlanos.Columns.Add("Tipo", 150, HorizontalAlignment.Center);

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["id"].ToString());
                            item.SubItems.Add(reader["valor"].ToString());
                            item.SubItems.Add(reader["tipo_plano"].ToString());
                            listViewPlanos.Items.Add(item);
                        }
                    }
                    connection.conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os planos: {ex.Message}");
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do plano foi inserido corretamente
            if (!int.TryParse(txtPlanoID.Text, out int idPlano))
            {
                MessageBox.Show("Por favor, insira um ID válido para excluir o plano.");
                return;
            }

            // Confirmação de exclusão
            if (MessageBox.Show($"Tem certeza de que deseja excluir o plano com ID {idPlano}?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Query para excluir o plano da tabela de alunos-plano (tbl_aluno_plano)
            string deleteRelationQuery = "DELETE FROM tbl_aluno_plano WHERE tbl_Plano_id = @idPlano;";

            // Query para excluir o plano da tabela de planos (tbl_plano)
            string deletePlanQuery = "DELETE FROM tbl_plano WHERE id = @idPlano;";

            try
            {
                // Excluindo a relação entre plano e aluno
                using (MySqlCommand deleteRelation = new MySqlCommand(deleteRelationQuery, connection.IniciaConexaoBD()))
                {
                    deleteRelation.Parameters.AddWithValue("@idPlano", idPlano);
                    connection.conexao.Open();
                    deleteRelation.ExecuteNonQuery();
                    connection.conexao.Close();
                }

                // Excluindo o plano da tabela de planos
                using (MySqlCommand deletePlan = new MySqlCommand(deletePlanQuery, connection.IniciaConexaoBD()))
                {
                    deletePlan.Parameters.AddWithValue("@idPlano", idPlano);
                    connection.conexao.Open();
                    int rowsAffected = deletePlan.ExecuteNonQuery();
                    connection.conexao.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Plano com ID {idPlano} excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum plano encontrado com o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o plano: {ex.Message}");
            }
        }

        private void FormExcluirPlano_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
            CarregarListViewPlanos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listViewPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listViewPlanos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtPlanoID.Text = item.SubItems[0].Text;
            }
        }

        private void txtPlanoID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
