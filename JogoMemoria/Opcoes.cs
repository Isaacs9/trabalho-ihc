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
                btnPronto.Visible = true;
                labelNumTentativas.Focus();
            }
            else
            {
                labelNumTentativas.Visible = false;
                textNumTentativas.Visible = false;
                btnPronto.Visible = false;
                Program.numTentativas = 0;

            }
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            Program.numTentativas = int.Parse(textNumTentativas.Text);
            MessageBox.Show("Quantidade definida com sucesso!", "Número de Tentativas");
            this.Visible = false;
        }
    }
}
