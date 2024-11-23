using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BS_Projeto
{
    public partial class FormAlunos : FormBase
    {
        public FormAlunos()
        {
            InitializeComponent();
            _menuSelecionado = 2;
            MostrarPanelSelecionado();
        }
    }
}
