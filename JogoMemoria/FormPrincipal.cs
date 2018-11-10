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
        public static string cor = "verde";

        static MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public FormPrincipal()
        {
            InitializeComponent();
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            buscarCor();
            Som som = new Som();
            som.stop();
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
            tela.MinimizeBox = false;
            tela.MaximizeBox = false;
            tela.WindowState = FormWindowState.Maximized;
        }
 
        private void fecharTela(Form tela)
        {
            tela.Visible = false;   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
 
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e){
            Application.Exit();    
        }

        public static void buscarCor()
        {
            // Definindo um esquema de Cor para formulário com tom Azul
            switch (cor)
            {
                case"verde":
                    materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Green900, Primary.Green900,
                    Primary.LightBlue100, Accent.LightBlue200,
                    TextShade.WHITE
                    );
                    break;
                case "preto":
                    materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Grey900, Primary.Grey900,
                    Primary.Grey900, Accent.LightBlue200,
                    TextShade.WHITE
                    );
                    break;
                case "azul":
                    materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue900, Primary.Blue900,
                    Primary.Blue900, Accent.LightBlue200,
                    TextShade.WHITE
                    );
                    break;
            }
                
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            abrirTela(new Ranking());

        }
    }
}
