using BodyShape_TI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BodyShape_TI.Forms
{
    public partial class FormEndereco : Form
    {
        private Endereco endereco = new Endereco();

        public FormEndereco()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string RetornarEndereco()
        {
            try
            {
                return endereco.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PreencherCampos(Endereco endereco)
        {
            this.txtLogradouro.Text = endereco.Logradouro;
            this.txtBairro.Text = endereco.Bairro;
            this.txtLocalidade.Text = endereco.Localidade;
            this.txtUF.Text = endereco.UF;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                RealizarBusca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RealizarBusca()
        {
            string cepSemMascara = maskedCEP.Text.Replace("-", "");
            endereco = CEP.BuscarCEP(cepSemMascara);
            PreencherCampos(endereco);
        }

        private void maskedCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                RealizarBusca();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
