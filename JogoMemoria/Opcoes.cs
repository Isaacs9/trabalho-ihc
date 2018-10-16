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
    public partial class Opcoes : MaterialForm
    {
        public Opcoes()
        {
            InitializeComponent();
            //CheckBox
            checkLolSom.SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            // inicialização de cores
            switch (FormPrincipal.cor)
            {
                case "verde":
                    this.radioVerde.Checked = true;
                    break;
                case "preto":
                    this.radioPreto.Checked = true;
                    break;
                case "azul":
                    this.radioAzul.Checked = true;
                    break;
            }
            if(Program.soundLol)
            {
                checkLolSom.CheckState = CheckState.Checked;
            } else
            {
                checkLolSom.CheckState = CheckState.Unchecked;
            }
            // inicialização numero de tentativas
            if (Program.numTentativas > 0)
            {
                labelNumTentativas.Visible = true;
                textNumTentativas.Visible = true;
                btnPronto.Visible = true;
                comboNumTentavias.Text = "Sim";
                textNumTentativas.Text = Program.numTentativas.ToString();
                labelNumTentativas.Focus();
            }
            var point = new Point();
            if (comboNumTentavias.Text == "Sim")
            {
                point = new Point(402, 463);
            } else
            {
                point = new Point(402, 417);
            }
            btnPronto.Location = point;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Opcoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioPreto_CheckedChanged(object sender, EventArgs e)
        {
            FormPrincipal.cor = "preto";
            FormPrincipal.buscarCor();
        }

        private void radioAzul_CheckedChanged(object sender, EventArgs e)
        {
            FormPrincipal.cor = "azul";
            FormPrincipal.buscarCor();
        }

        private void radioVerde_CheckedChanged(object sender, EventArgs e)
        {
            FormPrincipal.cor = "verde";
            FormPrincipal.buscarCor();
        }

        private void comboNumTentavias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNumTentavias.Text == "Sim")
            {
                labelNumTentativas.Visible = true;
                textNumTentativas.Visible = true;
                var point = new Point(402, 463);
                btnPronto.Location = point;
                labelNumTentativas.Focus();
            }
            else
            {
                labelNumTentativas.Visible = false;
                textNumTentativas.Visible = false;
                var point = new Point(402, 417);
                btnPronto.Location = point;
                Program.numTentativas = 0;

            }
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            if(checkLolSom.Checked) {
                Program.soundLol = true;
            }
            else
            {
                Program.soundLol = false;
                checkLolSom.Text = "Unchecked";
            }
            if (comboNumTentavias.Text == "Sim")
            {
                int numTentativas = int.Parse(textNumTentativas.Text);
                if(numTentativas == 0)
                {
                    MessageBox.Show("O Limite de tentativas deve ser superior a 0.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.numTentativas = numTentativas;
            }
            else
            {
                Program.numTentativas = 0;
            }
            MessageBox.Show("As opções foram definidas com sucesso.", "Definições");
            this.Visible = false;
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {

        }
    }
}
