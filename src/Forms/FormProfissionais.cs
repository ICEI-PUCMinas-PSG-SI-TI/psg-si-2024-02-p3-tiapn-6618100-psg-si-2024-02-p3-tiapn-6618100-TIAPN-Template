using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BS_Projeto
{
    public partial class FormProfissionais : FormBase
    {
        public FormProfissionais()
        {
            InitializeComponent();
            _menuSelecionado = 3;
            MostrarPanelSelecionado();
        }
    }
}
