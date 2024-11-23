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
    public partial class FormCadastroAlunoPlano : Form
    {
        ConexaoBD connection;
        public FormCadastroAlunoPlano()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO tbl_aluno_plano
         (tbl_Plano_id, tbl_Aluno_id, data_inicio, data_fim)
         VALUES 
         (@tbl_Plano_id, @tbl_Aluno_id, @data_inicio, @data_fim);";

            try
            {
                // Validação e conversão das datas
                if (!DateTime.TryParse(txtDataInicioPlano.Text, out DateTime dataInicio))
                {
                    MessageBox.Show("Data de início inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                if (!DateTime.TryParse(txtDataFimPlano.Text, out DateTime dataFim))
                {
                    MessageBox.Show("Data de fim inválida. Use o formato DD/MM/YYYY.");
                    return;
                }

                // Inicialização do comando
                using (MySqlCommand insert = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    insert.Parameters.AddWithValue("@tbl_Plano_id", txtPlanoID.Text);
                    insert.Parameters.AddWithValue("@tbl_Aluno_id", txtAlunoID.Text);
                    insert.Parameters.AddWithValue("@data_inicio", dataInicio.ToString("yyyy-MM-dd"));
                    insert.Parameters.AddWithValue("@data_fim", dataFim.ToString("yyyy-MM-dd"));

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

        private void FormCadastroAlunoPlano_Load(object sender, EventArgs e)
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
