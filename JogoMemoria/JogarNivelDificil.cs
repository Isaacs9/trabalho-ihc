using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class JogarNivelDificil : MaterialForm
    {

        int nCliques = 0;
        int primeiroBotao;
        int segundoBotao;
        Button[] botoesClicados = new Button[2];
        int pares = 24;
        int tentativas;

        public PictureBox[] pecas()
        {
            PictureBox[] pecas = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                                 pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16,
                                 pictureBox17, pictureBox18, pictureBox19,pictureBox20,pictureBox21, pictureBox22, pictureBox23, pictureBox24,
                                 pictureBox25, pictureBox26,pictureBox27,pictureBox28,pictureBox29,pictureBox30,pictureBox31,pictureBox32,pictureBox33,pictureBox34,
                                 pictureBox35,pictureBox36,pictureBox37,pictureBox38,pictureBox39,pictureBox40,pictureBox41,pictureBox42,pictureBox43,pictureBox44,
                                 pictureBox45,pictureBox46,pictureBox47,pictureBox48};

            return pecas;
        }

        public Button[] botoes()
        {
            Button[] botoes = { materialRaisedButton1,  materialRaisedButton2,  materialRaisedButton3,  materialRaisedButton4,  materialRaisedButton5,  materialRaisedButton6,  materialRaisedButton7,  materialRaisedButton8,
                                  materialRaisedButton9,  materialRaisedButton10,  materialRaisedButton11,  materialRaisedButton12,  materialRaisedButton13,  materialRaisedButton14,  materialRaisedButton15,  materialRaisedButton16,
                                  materialRaisedButton17,  materialRaisedButton18,  materialRaisedButton19, materialRaisedButton20, materialRaisedButton21,  materialRaisedButton22,  materialRaisedButton23,  materialRaisedButton24,
                                  materialRaisedButton25,  materialRaisedButton26, materialRaisedButton27, materialRaisedButton28, materialRaisedButton29, materialRaisedButton30, materialRaisedButton31, materialRaisedButton32, materialRaisedButton33, materialRaisedButton34,
                                  materialRaisedButton35, materialRaisedButton36, materialRaisedButton37, materialRaisedButton38, materialRaisedButton39, materialRaisedButton40, materialRaisedButton41, materialRaisedButton42, materialRaisedButton43, materialRaisedButton44,
                                  materialRaisedButton45, materialRaisedButton46, materialRaisedButton47, materialRaisedButton48};
            return botoes;
        }

        public JogarNivelDificil()
        {
            InitializeComponent();
            FormPrincipal.buscarCor();
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

        public void iniciaJogo()
        {
            revelaIcones.Start();
            if (Program.soundLol)
            {
                Som som = new Som();
                som.somAmbiente();
            }

            Image[] bancoImagens = new Image[24];                                               
            Niveis niv = new Niveis();

            bancoImagens = niv.difDificil();

            int i = 0;
            int[] posicaoOcupada = new int[48];
            int sorteio;

            for (i = 0; i < 48; i++)
            {
                do
                {
                    Random escolhaCaixa = new Random();
                    sorteio = escolhaCaixa.Next(0, 48);                                          //Sorteia uma caixa a ser preenchida

                } while (posicaoOcupada[sorteio] == 1);                                         //Se a caixa já foi preenchida, sorteia-se novamente

                pecas()[sorteio].Image = bancoImagens[i];                                         //Preenche a caixa
                posicaoOcupada[sorteio]++;                                                      //Recorda a caixa já preenchida
            }

        }

        public void gerenciaBotoes(Button botaoClicado, int posicao)
        {
            if (escondePar.Enabled == true)
                return;

            if (nCliques == 1)
            {
                botaoClicado.Visible = false;
                nCliques++;
                segundoBotao = posicao;                                                //Recorda a posicao do segundo botao clicado
                botoesClicados[1] = botaoClicado;
                comparaImagens();

            }
            else if (nCliques == 0)
            {
                botaoClicado.Visible = false;
                nCliques++;                                                            //Aumenta o número de botões clicados
                primeiroBotao = posicao;                                               //Recorda a posicao do primeiro botao clicado
                botoesClicados[0] = botaoClicado;
            }
        }

        public void comparaImagens()
        {
            Som som = new Som();
            if (pecas()[primeiroBotao].Image != pecas()[segundoBotao].Image)
            {
                tentativas++;
                lblTentativas.Text = tentativas.ToString();
                escondePar.Start();
            }
            else
            {
                pares--;
                if (Program.soundLol)
                {
                    som.executaSomHeroi(pecas()[segundoBotao].Image);
                }
            }

            if (pares == 0)
            {
                tempoJogo.Stop();
                if (Program.soundLol)
                {
                    som.vitoria();
                }
                if (MessageBox.Show("Parabéns, você ganhou!!\n\nDeseja jogar novamente?", "Parabéns!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    tentativas = 0;
                    lblTentativas.Text = "0";
                    lblTempo.Text = "0";
                    iniciaJogo();
                }
                else
                {
                    fecharTela(this);
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                }
            }
            nCliques = 0;

            if (excedeuLimiteTentativas())
            {
                if (MessageBox.Show("Você excedeu a quantidade de tentativas. Deseja Jogar Novamente?", "Ah não", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    tentativas = 0;
                    lblTentativas.Text = "0";
                    lblTempo.Text = "0";
                    iniciaJogo();
                }
                else
                {
                    fecharTela(this);
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                }
            }

        }

        public void escondePecas(Button[] pecas)
        {
            pecas.ToList().ForEach(botoes => botoes.Visible = true);
        }

        private void sairJogo_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Deseja sair do jogo atual ? ", "Confirmação ", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                Som som = new Som();
                som.stop();
                fecharTela(this);
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
            }

        }

        private void fecharTela(Form tela)
        {
            tela.Visible = false;
        }

        private void JogarNivelDificil_Load(object sender, EventArgs e)
        {
            iniciaJogo();
        }

        private void tempoJogo_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = (int.Parse(lblTempo.Text) + 1).ToString();
        }

        private void escondePar_Tick(object sender, EventArgs e)
        {
            escondePar.Stop();
            botoesClicados[0].Visible = true;
            botoesClicados[1].Visible = true;
        }

        private void revelaIcones_Tick(object sender, EventArgs e)
        {
            revelaIcones.Stop();
            escondePecas(botoes());
            tempoJogo.Enabled = true;
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }

        private Boolean excedeuLimiteTentativas()
        {
            if (Program.numTentativas == tentativas)
            {
                return true;
            }
            return false;
        }

        private void JogarNivelDificil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton1, 0);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton2, 1);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton4, 3);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton3, 2);
        }

        private void materialRaisedButton30_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton30, 29);
        }

        private void materialRaisedButton36_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton36, 35);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton5, 4);
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton6, 5);
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton7, 6);
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton8, 7);
        }

        private void materialRaisedButton29_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton29, 28);
        }

        private void materialRaisedButton35_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton35, 34);
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton9, 8);
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton10, 9);
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton11, 10);
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton12, 11);
        }

        private void materialRaisedButton28_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton28, 27);
        }

        private void materialRaisedButton34_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton34, 33);
        }

        private void materialRaisedButton13_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton13, 12);
        }

        private void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton14, 13);
        }

        private void materialRaisedButton15_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton15, 14);
        }

        private void materialRaisedButton16_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton16, 15);
        }

        private void materialRaisedButton27_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton27, 26);
        }

        private void materialRaisedButton33_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton33, 32);
        }

        private void materialRaisedButton20_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton20, 19);
        }

        private void materialRaisedButton19_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton19, 18);
        }

        private void materialRaisedButton18_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton18, 17);
        }

        private void materialRaisedButton17_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton17, 16);
        }

        private void materialRaisedButton26_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton26, 25);
        }

        private void materialRaisedButton32_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton32, 31);
        }

        private void materialRaisedButton24_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton24, 23);
        }

        private void materialRaisedButton23_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton23, 22);
        }

        private void materialRaisedButton22_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton22, 21);
        }

        private void materialRaisedButton21_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton21, 20);
        }

        private void materialRaisedButton25_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton25, 24);
        }

        private void materialRaisedButton31_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton31, 30);
        }

        private void materialRaisedButton48_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton48, 47);
        }

        private void materialRaisedButton47_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton47, 46);
        }

        private void materialRaisedButton46_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton46, 45);
        }

        private void materialRaisedButton45_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton45, 44);
        }

        private void materialRaisedButton40_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton40, 39);
        }

        private void materialRaisedButton38_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton38, 37);
        }

        private void materialRaisedButton44_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton44, 43);
        }

        private void materialRaisedButton43_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton43, 42);
        }

        private void materialRaisedButton42_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton42, 41);
        }

        private void materialRaisedButton41_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton41, 40);
        }

        private void materialRaisedButton39_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton39, 38);
        }

        private void materialRaisedButton37_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(materialRaisedButton37, 36);
        }
    }
}
