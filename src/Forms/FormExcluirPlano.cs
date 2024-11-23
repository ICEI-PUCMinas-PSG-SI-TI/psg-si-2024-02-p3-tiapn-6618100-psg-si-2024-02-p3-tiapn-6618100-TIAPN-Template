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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
