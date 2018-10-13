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
    public partial class JogarNivelFacil : MaterialForm
    {
        public JogarNivelFacil()
        {
            InitializeComponent();
        }

        private void sairJogo_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Deseja sair do jogo atual ? ", "Confirmação ", MessageBoxButtons.YesNo);
            if(confirmacao == DialogResult.Yes){
                fecharTela(this);
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
            }
           
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
    }
}
