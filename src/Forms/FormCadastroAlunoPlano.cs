using BodyShape_TI.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            CarregarListViewPlanos();
            CarregarListViewAlunos();
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

        private void CarregarListViewAlunos()
        {
            listViewAlunos.View = View.Details;
            listViewAlunos.LabelEdit = true;
            listViewAlunos.AllowColumnReorder = true;
            listViewAlunos.FullRowSelect = true;
            listViewAlunos.GridLines = true;

            try
            {
                string query = "SELECT id, nome, data_nascimento, sexo, logradouro, numero, complemento, bairro, cidade, estado, telefone FROM tbl_Aluno";
                using (MySqlCommand command = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    connection.conexao.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        listViewAlunos.Items.Clear(); // Limpa o ListView
                        listViewAlunos.Columns.Clear();

                        // Adiciona colunas ao ListView
                        listViewAlunos.Columns.Add("ID", 50);
                        listViewAlunos.Columns.Add("Nome", 150);
                        listViewAlunos.Columns.Add("Data Nascimento", 100);
                        listViewAlunos.Columns.Add("Sexo", 50);
                        listViewAlunos.Columns.Add("Logradouro", 150);
                        listViewAlunos.Columns.Add("Número", 70);
                        listViewAlunos.Columns.Add("Complemento", 150);
                        listViewAlunos.Columns.Add("Bairro", 100);
                        listViewAlunos.Columns.Add("Cidade", 100);
                        listViewAlunos.Columns.Add("Estado", 50);
                        listViewAlunos.Columns.Add("Telefone", 100);

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
                            listViewAlunos.Items.Add(item);
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

        private void listViewPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listViewPlanos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtPlanoID.Text = item.SubItems[0].Text;
            }
        }

        private void listViewAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listViewAlunos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                txtAlunoID.Text = item.SubItems[0].Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}