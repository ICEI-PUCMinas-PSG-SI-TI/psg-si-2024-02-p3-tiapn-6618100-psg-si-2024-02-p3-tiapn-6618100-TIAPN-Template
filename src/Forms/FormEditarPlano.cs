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
        private void FormEditarPlano_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
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
    }
}
