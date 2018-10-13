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
    public partial class Tema : MaterialForm
    {
        public Tema()
        {
            InitializeComponent();
            FormPrincipal.buscarCor();
            
        }

        private void Tema_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fecharTela(this);
        }

        private void btnRedesSociais_Click(object sender, EventArgs e)
        {
            Program.tema = "web";
            Dificuldade dificuldade = new Dificuldade();
            abrirTela(dificuldade);
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


        private void btnLOL_Click(object sender, EventArgs e)
        {
            Program.tema = "league";
            Dificuldade dificuldade = new Dificuldade();
            abrirTela(dificuldade);
        }

        private void Tema_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
