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
    public partial class FormPrincipal : MaterialForm
    {
        public static string tema = "";

        public FormPrincipal()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.Green900,
                Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE
            );
           
           
         }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        
        private void btnJogar_Click(object sender, EventArgs e)
        {
            Tema tema = new Tema();
            abrirTela(tema);
            
        }
      

        private void voltarTema_Click(object sender, EventArgs e)
        {
      
        }

        private void btnOpcao_Click(object sender, EventArgs e)
        {
            abrirTela(new Opcoes());
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
