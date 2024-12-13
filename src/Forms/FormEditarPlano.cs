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
    public partial class FormEditarPlano : Form
    {
        ConexaoBD connection;
        public FormEditarPlano()
        {
            InitializeComponent();
        }

        private void CarregarListViewPlano()
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

        private void FormEditarPlano_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
            CarregarListViewPlano();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlanoID.Text))
            {
                MessageBox.Show("Por favor, insira o ID do plano para editar.");
                return;
            }

            string query = @"UPDATE tbl_plano
                     SET valor = @valor,
                         tipo_plano = @tipo_plano
                     WHERE id = @id;";

            try
            {
                // Verifica se a conexão está configurada
                if (connection == null)
                {
                    connection = new ConexaoBD();
                }

                using (MySqlCommand update = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {
                    // Define os parâmetros para a query
                    update.Parameters.AddWithValue("@valor", txtValorPlano.Text);
                    update.Parameters.AddWithValue("@tipo_plano", txtTipoPlano.Text);
                    update.Parameters.AddWithValue("@id", txtPlanoID.Text);

                    connection.conexao.Open();
                    int rowsAffected = update.ExecuteNonQuery();
                    connection.conexao.Close();

                    // Verifica se a atualização foi bem-sucedida
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Plano atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum plano foi encontrado com o ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o plano:\n{ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewPlanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há algum item selecionado
            if (listViewPlanos.SelectedItems.Count > 0)
            {
                // Obtém o primeiro item selecionado
                ListViewItem selectedItem = listViewPlanos.SelectedItems[0];

                // Preenche os campos de texto com os dados do plano selecionado
                txtPlanoID.Text = selectedItem.SubItems[0].Text;
                txtValorPlano.Text = selectedItem.SubItems[1].Text;
                txtTipoPlano.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void txtValorPlano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}