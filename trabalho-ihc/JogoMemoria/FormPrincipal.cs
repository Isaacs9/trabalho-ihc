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
            this.panelTema.BringToFront();
            this.panelTema.Show();
            
        }

        private void voltarTema_Click(object sender, EventArgs e)
        {
            this.panelTema.Hide();
        }

        private void btnOpcao_Click(object sender, EventArgs e)
        {
            this.panelOpcoes.BringToFront();
            this.panelOpcoes.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.panelOpcoes.Hide();
        }
    }
}
