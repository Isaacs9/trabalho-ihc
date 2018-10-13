using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace JogoMemoria
{
    public partial class Dificuldade : MaterialForm
    {
        public Dificuldade()
        {
            InitializeComponent();
        }

        private void voltarDificuldade_Click(object sender, EventArgs e)
        {
            fecharTela(this);
        }


        // CONTROLES DE PAGINA
        public void abrirTela(Form tela)
        {
            tela.TopLevel = false;
            tela.Visible = true;
            Controls.Add(tela);
            tela.BringToFront();
            tela.WindowState = FormWindowState.Maximized;
            
        }

        private void fecharTela(Form tela)
        {
            tela.Visible = false;
        }

        private void btnRedesSociais_Click(object sender, EventArgs e)
        {
            JogarNivelFacil jogarNivelFacil = new JogarNivelFacil();
            abrirTela(jogarNivelFacil);
        }
    }
}
