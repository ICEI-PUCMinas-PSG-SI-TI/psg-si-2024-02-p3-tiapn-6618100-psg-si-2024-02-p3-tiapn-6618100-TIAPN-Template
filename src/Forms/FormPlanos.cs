using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BS_Projeto
{
    public partial class FormPlanos : FormBase
    {
        public FormPlanos()
        {
            InitializeComponent();
            _menuSelecionado = 4;
            MostrarPanelSelecionado();
        }

        private void pnlInformacoesPBasico_Paint(object sender, PaintEventArgs e)
        {
            PintarPanel(e, pnlInformacoesPBasico);
        }

        private void pnlInformacoesPPlus_Paint(object sender, PaintEventArgs e)
        {
            PintarPanel(e, pnlInformacoesPPlus);
        }

        private void pnlInformacoesPMaster_Paint(object sender, PaintEventArgs e)
        {
            PintarPanel(e, pnlInformacoesPMaster);
        }

        private void PintarPanel(PaintEventArgs e, Control ControlColorir)
        {
            base.OnPaint(e);

            Color startColor = Color.FromArgb(255, 33, 29, 29);
            Color endColor = Color.FromArgb(255, 39, 68, 67);

            using (LinearGradientBrush brush = new LinearGradientBrush(ControlColorir.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
