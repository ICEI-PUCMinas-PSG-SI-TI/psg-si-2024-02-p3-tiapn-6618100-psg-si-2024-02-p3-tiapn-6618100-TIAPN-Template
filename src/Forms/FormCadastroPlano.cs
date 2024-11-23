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
    public partial class FormCadastroPlano : Form
    {
        ConexaoBD connection;
        public FormCadastroPlano()
        {
            InitializeComponent();
        }

        private void FormCadastroPlano_Load(object sender, EventArgs e)
        {
            connection = new ConexaoBD();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        //INSERT
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO tbl_plano
             (valor, tipo_plano)
             VALUES 
             (@valor, @tipo_plano);";

            try
            {

                using (MySqlCommand insert = new MySqlCommand(query, connection.IniciaConexaoBD()))
                {

                    insert.Parameters.AddWithValue("@valor", txtValorPlano.Text);
                    insert.Parameters.AddWithValue("@tipo_plano", txtTipoPlano.Text);


                    connection.conexao.Open();
                    insert.ExecuteNonQuery();
                    connection.conexao.Close();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao inserir seus dados:\n" + ex + "ex.ToString");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // UPDATE
        private void btnEditarPlano_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de edição
            FormEditarPlano formEditarPlano = new FormEditarPlano();

            // Exibe o formulário como uma janela modal
            formEditarPlano.ShowDialog();

        }

        //DELETE
        private void button1_Click(object sender, EventArgs e)
        {
            FormExcluirPlano formExcluirPlano = new FormExcluirPlano();

            formExcluirPlano.ShowDialog();
        }
    }
}
