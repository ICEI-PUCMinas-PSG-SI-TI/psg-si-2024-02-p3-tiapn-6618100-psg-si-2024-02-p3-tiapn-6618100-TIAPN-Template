using BodyShape_TI.Entities;
using BodyShape_TI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyShape_TI
{
    public partial class FormCadastroProfissional : Form
    {

        public FormCadastroProfissional()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisaEndereco_Click(object sender, EventArgs e)
        {
            FormEndereco frmEnd = new FormEndereco();
            frmEnd.ShowDialog();
            this.txtEndereco.Text = frmEnd.RetornarEndereco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
