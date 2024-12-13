using System.Windows.Forms;
using System;

namespace BS_Projeto
{
    public partial class FormBase : Form
    {
        protected int _menuSelecionado;

        public FormBase()
        {
            InitializeComponent();
            _menuSelecionado = 1;
            MostrarPanelSelecionado();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            _menuSelecionado = 1;
            MostrarPanelSelecionado();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            _menuSelecionado = 2;
            MostrarPanelSelecionado();
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            _menuSelecionado = 3;
            MostrarPanelSelecionado();
        }

        private void btnFichasAluno_Click(object sender, EventArgs e)
        {
            _menuSelecionado = 4;
            MostrarPanelSelecionado();
        }

        protected virtual void MostrarPanelSelecionado()
        {
            pnlBtnAlunos.Visible = false;
            pnlBtnProf.Visible = false;
            pnlBtnPlanos.Visible = false;
            pnlBtnAulas.Visible = false;

            //Form formToOpen = new FormBase();

            switch (this._menuSelecionado)
            {
                case 1:
                    pnlBtnAlunos.Visible = true;
                    //formToOpen = new FormsPerfil();
                    break;
                case 2:
                    pnlBtnProf.Visible = true;
                    //formToOpen = new FormAlunos();
                    break;
                case 3:
                    pnlBtnPlanos.Visible = true;
                    //formToOpen = new FormProfissionais();
                    break;
                case 4:
                    pnlBtnAulas.Visible = true;
                    //formToOpen = new FormPlanos();
                    break;
            }

            //if (formToOpen != null)
            //{
            //    this.Hide();  
            //    formToOpen.ShowDialog();
            //    this.Close();          
            //}
        }


        private void pnlSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
