using BS_Projeto;
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
    public partial class TelaSprint4 : Form
    {
        public TelaSprint4()
        {
            InitializeComponent();
        }

        private void pnlSair_Paint(object sender, PaintEventArgs e)
        {
        }

        //private void OP1_Click(object sender, EventArgs e)
        //{
            //FormCadastroAluno formCadastroAluno = new FormCadastroAluno();
            //formCadastroAluno.ShowDialog();
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formCadastroAluno = new FormCadastroAluno();
            formCadastroAluno.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        this.Close();
        //    }
        //}

        //private void OP2_Click(object sender, EventArgs e)
        //{
        //    FormCadastroPlano formCadastroPlano = new FormCadastroPlano();
        //    formCadastroPlano.ShowDialog();
        //}

        //private void OP3_Click_1(object sender, EventArgs e)
        //{
        //    FormCadastroAlunoPlano formCadastroAlunoPlano = new FormCadastroAlunoPlano();
        //    formCadastroAlunoPlano.ShowDialog();
        //}

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formCadastroAluno = new FormCadastroAluno();
            formCadastroAluno.ShowDialog();
        }

        private void btnCadPlano_Click(object sender, EventArgs e)
        {
            FormCadastroPlano formCadastroPlano = new FormCadastroPlano();
            formCadastroPlano.ShowDialog();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            FormCadastroAlunoPlano formCadastroAlunoPlano = new FormCadastroAlunoPlano();
            formCadastroAlunoPlano.ShowDialog();
        }
    }
}
