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
    public partial class FormCadastroBioimpedância : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=; database=mydb";

        private int? id_bioimpedancia_selecionada = null;

        public FormCadastroBioimpedância()
        {
            InitializeComponent();
            lst_Bioimpedancias.View = View.Details;
            lst_Bioimpedancias.LabelEdit = true;
            lst_Bioimpedancias.AllowColumnReorder = true;
            lst_Bioimpedancias.FullRowSelect = true;
            lst_Bioimpedancias.GridLines = true;

            lst_Bioimpedancias.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("Gordura", 60, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("Peso", 60, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("Altura", 70, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("Massa Magra", 70, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("ID Educador Fisico", 70, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("ID Aluno", 70, HorizontalAlignment.Center);
            lst_Bioimpedancias.Columns.Add("ID Atendente", 70, HorizontalAlignment.Center);


            // lista de educadores físico

            lst_Educador_Fisico.View = View.Details;
            lst_Educador_Fisico.LabelEdit = true;
            lst_Educador_Fisico.AllowColumnReorder = true;
            lst_Educador_Fisico.FullRowSelect = true;
            lst_Educador_Fisico.GridLines = true;

            lst_Educador_Fisico.Columns.Add("CREF", 80, HorizontalAlignment.Center);
            lst_Educador_Fisico.Columns.Add("Especialidade", 100, HorizontalAlignment.Center);
            lst_Educador_Fisico.Columns.Add("Nível Formação", 110, HorizontalAlignment.Center);
            lst_Educador_Fisico.Columns.Add("ID Funcionario", 80, HorizontalAlignment.Center);


            // lista de alunos
            lst_Alunos.View = View.Details;
            lst_Alunos.LabelEdit = true;
            lst_Alunos.AllowColumnReorder = true;
            lst_Alunos.FullRowSelect = true;
            lst_Alunos.GridLines = true;

            lst_Alunos.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lst_Alunos.Columns.Add("Nome", 80, HorizontalAlignment.Center);
            lst_Alunos.Columns.Add("Telefone", 80, HorizontalAlignment.Center);
            lst_Alunos.Columns.Add("ID Atendente", 80, HorizontalAlignment.Center);


            // Lista de atendentes

            lst_Atendentes.View = View.Details;
            lst_Atendentes.LabelEdit = true;
            lst_Atendentes.AllowColumnReorder = true;
            lst_Atendentes.FullRowSelect = true;
            lst_Atendentes.GridLines = true;

            lst_Atendentes.Columns.Add("ID Funcionario", 100, HorizontalAlignment.Center);
            lst_Atendentes.Columns.Add("Atividade", 80, HorizontalAlignment.Center);

            carregar_Educador_Fisico();
            carregar_Alunos();
            carregar_Atendente();

            carregar_bioimpedancias();
        }


        private void reset()
        {
            txt_gordura.Text = string.Empty;
            txt_Peso.Text = string.Empty;
            txt_Altura.Text = string.Empty;
            txt_Massa_Magra.Text = string.Empty;
            txt_Id_Educador_Fisico.Text = string.Empty;
            txt_Id_Aluno.Text = string.Empty;
            txt_Id_Atendente.Text = string.Empty;
        }


        private void carregar_Atendente()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);


                string sql = "SELECT tbl_Funcionario_id, atividade " +
                "FROM tbl_Atendente";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();



                lst_Atendentes.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),


                    };

                    var linha_listview = new ListViewItem(row);
                    lst_Atendentes.Items.Add(linha_listview);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Conexao.Close();
            }
        }


        private void carregar_Alunos()
        {
            try
            {


                Conexao = new MySqlConnection(data_source);


                string sql = "SELECT id, nome, telefone, tbl_Atendente_tbl_Funcionario_id " +
                                    "FROM tbl_Aluno ORDER BY id";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();



                lst_Alunos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString()

                    };

                    var linha_listview = new ListViewItem(row);
                    lst_Alunos.Items.Add(linha_listview);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Conexao.Close();
            }
        }


        private void carregar_Educador_Fisico()
        {
            try
            {


                Conexao = new MySqlConnection(data_source);


                string sql = "SELECT * " +
                                    "FROM tbl_Educador_Fisico ORDER BY CREF";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();



                lst_Educador_Fisico.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3).ToString()

                    };

                    var linha_listview = new ListViewItem(row);
                    lst_Educador_Fisico.Items.Add(linha_listview);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Conexao.Close();
            }
        }


        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                Conexao.Open();


                cmd.CommandText = "INSERT INTO tbl_Bioimpedancia (gordura, peso, altura, massa_magra, tbl_Educador_Fisico_tbl_Funcionario_id, tbl_Aluno_id, tbl_Aluno_tbl_Atendente_tbl_Funcionario_id)" +
               "VALUES(@gordura, @peso, @altura, @massa_magra, @tbl_Educador_Fisico_tbl_Funcionario_id, @tbl_Aluno_id, @tbl_Aluno_tbl_Atendente_tbl_Funcionario_id)";


                cmd.Parameters.AddWithValue("@gordura", Convert.ToDouble(txt_gordura.Text));
                cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txt_Peso.Text));
                cmd.Parameters.AddWithValue("@altura", Convert.ToDouble(txt_Altura.Text));
                cmd.Parameters.AddWithValue("@massa_magra", Convert.ToDouble(txt_Massa_Magra.Text));
                cmd.Parameters.AddWithValue("@tbl_Educador_Fisico_tbl_Funcionario_id", txt_Id_Educador_Fisico.Text);
                cmd.Parameters.AddWithValue("@tbl_Aluno_id", txt_Id_Aluno.Text);
                cmd.Parameters.AddWithValue("@tbl_Aluno_tbl_Atendente_tbl_Funcionario_id", txt_Id_Atendente.Text);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Dados inseridos com sucesso!");
                carregar_bioimpedancias();


                reset();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Conexao.Close();
            }

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {


                Conexao = new MySqlConnection(data_source);

                string nomeAluno = txt_Aluno.Text;
                string sql = "SELECT * " +
                                    "FROM tbl_Bioimpedancia " +
                                    "WHERE tbl_Aluno_id = (SELECT id FROM tbl_Aluno WHERE nome = @nomeAluno LIMIT 1)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@nomeAluno", txt_Aluno.Text);



                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();



                lst_Bioimpedancias.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetDouble(1).ToString("F2"),
                        reader.GetDouble(2).ToString("F2"),
                        reader.GetDouble(3).ToString("F2"),
                        reader.GetDouble(4).ToString("F2"),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString(),
                        reader.GetInt32(7).ToString(),
                    };

                    var linha_listview = new ListViewItem(row);
                    lst_Bioimpedancias.Items.Add(linha_listview);
                }




            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void carregar_bioimpedancias()
        {
            try
            {


                Conexao = new MySqlConnection(data_source);

                string nomeAluno = txt_Aluno.Text;
                string sql = "SELECT * " +
                                    "FROM tbl_Bioimpedancia ORDER BY id ASC";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();



                lst_Bioimpedancias.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetDouble(1).ToString("F2"),
                        reader.GetDouble(2).ToString("F2"),
                        reader.GetDouble(3).ToString("F2"),
                        reader.GetDouble(4).ToString("F2"),
                        reader.GetInt32(5).ToString(),
                        reader.GetInt32(6).ToString(),
                        reader.GetInt32(7).ToString(),
                    };

                    var linha_listview = new ListViewItem(row);
                    lst_Bioimpedancias.Items.Add(linha_listview);
                }




            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }


        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                Conexao.Open();
                // Atualização de Bioimpedancia

                cmd.CommandText = "UPDATE tbl_Bioimpedancia SET gordura = @gordura," +
                                   "peso = @peso, altura = @altura, massa_magra = @massa_magra " +
                                   "WHERE id=@id";


                cmd.Parameters.AddWithValue("@gordura", Convert.ToDouble(txt_gordura.Text));
                cmd.Parameters.AddWithValue("@peso", Convert.ToDouble(txt_Peso.Text));
                cmd.Parameters.AddWithValue("@altura", Convert.ToDouble(txt_Altura.Text));
                cmd.Parameters.AddWithValue("@massa_magra", Convert.ToDouble(txt_Massa_Magra.Text));
                cmd.Parameters.AddWithValue("@tbl_Educador_Fisico_tbl_Funcionario_id", txt_Id_Educador_Fisico.Text);
                cmd.Parameters.AddWithValue("@tbl_Aluno_id", txt_Id_Aluno.Text);
                cmd.Parameters.AddWithValue("@tbl_Aluno_tbl_Atendente_tbl_Funcionario_id", txt_Id_Atendente.Text);
                cmd.Parameters.AddWithValue("@id", id_bioimpedancia_selecionada);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Bioimpedância atualizada com sucesso");

                txt_gordura.Text = string.Empty;
                txt_Peso.Text = string.Empty;
                txt_Altura.Text = string.Empty;
                txt_Massa_Magra.Text = string.Empty;
                txt_Id_Educador_Fisico.Text = string.Empty;
                txt_Id_Aluno.Text = string.Empty;
                txt_Id_Atendente.Text = string.Empty;

                carregar_bioimpedancias();
                id_bioimpedancia_selecionada = null;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                Conexao.Open();

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Exclusão - Bioimpedância", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {


                    cmd.CommandText = "DELETE from tbl_Bioimpedancia WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id_bioimpedancia_selecionada);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Bioimpedância deletada com sucesso");

                    txt_gordura.Text = string.Empty;
                    txt_Peso.Text = string.Empty;
                    txt_Altura.Text = string.Empty;
                    txt_Massa_Magra.Text = string.Empty;
                    txt_Id_Educador_Fisico.Text = string.Empty;
                    txt_Id_Aluno.Text = string.Empty;
                    txt_Id_Atendente.Text = string.Empty;

                    carregar_bioimpedancias();
                    id_bioimpedancia_selecionada = null;
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }

            reset();

        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void lst_Bioimpedancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_Bioimpedancias.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_bioimpedancia_selecionada = Convert.ToInt32(item.SubItems[0].Text);
                txt_gordura.Text = item.SubItems[1].Text;
                txt_Peso.Text = item.SubItems[2].Text;
                txt_Altura.Text = item.SubItems[3].Text;
                txt_Massa_Magra.Text = item.SubItems[4].Text;
                txt_Id_Educador_Fisico.Text = item.SubItems[5].Text;
                txt_Id_Aluno.Text = item.SubItems[6].Text;
                txt_Id_Atendente.Text = item.SubItems[7].Text;
            }
        }

        private void lst_Educador_Fisico_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_Educador_Fisico.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                txt_Id_Educador_Fisico.Text = item.SubItems[3].Text;

            }
        }

        private void lst_Alunos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_Alunos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                txt_Id_Aluno.Text = item.SubItems[0].Text;

            }
        }

        private void lst_Atendentes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_Atendentes.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                txt_Id_Atendente.Text = item.SubItems[0].Text;

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            MensagemFechamento();
        }

        private void lblSair_Click_1(object sender, EventArgs e)
        {
            MensagemFechamento();
        }

        private void MensagemFechamento()
        {
            if (MessageBox.Show("Caso possua informações não salvas, ao fechar esta aba, todas as alterações serão perdidas.\n\nDeseja realmente fechar esta tela?",
                     "Confirmação",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_gordura_Leave(object sender, EventArgs e)
        {
            txt_gordura.Text = Util.ConverterParaDecimal(txt_gordura.Text);
        }

        private void txt_Peso_Leave(object sender, EventArgs e)
        {
            txt_Peso.Text = Util.ConverterParaDecimal(txt_Peso.Text);
        }

        private void txt_Altura_Leave(object sender, EventArgs e)
        {
            txt_Altura.Text = Util.ConverterParaDecimal(txt_Altura.Text);
        }

        private void txt_Massa_Magra_Leave(object sender, EventArgs e)
        {
            txt_Massa_Magra.Text = Util.ConverterParaDecimal(txt_Massa_Magra.Text);
        }

        private void txt_gordura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.PermitirSomenteNumeros(e);
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.PermitirSomenteNumeros(e);
        }

        private void txt_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.PermitirSomenteNumeros(e);
        }

        private void txt_Massa_Magra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.PermitirSomenteNumeros(e);
        }
    }
}
