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
        int nCliques = 0;
        int primeiroBotao;
        int segundoBotao;
        Button[] botoesClicados = new Button[2];
        int pares = 8;
        int tentativas;

        public PictureBox[] pecas()
        {
            PictureBox[] pecas = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,
                                 pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16};

            return pecas;
        }

        public Button[] botoes()
        {
            Button[] botoes = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12,
                              button13, button14, button15, button16};
            return botoes;
        }

        public JogarNivelFacil()
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

        private void JogarNivelFacil_Load(object sender, EventArgs e)
        {
            iniciaJogo();
        }

        public void iniciaJogo()
        {
            revelaIcones.Start();
            if (Program.soundLol)
            {
                Som som = new Som();
                som.somAmbiente();
            }
            Image[] bancoImagens = new Image[8];                                                  //Classe imagens em um vetor com 4 imagens
            Niveis niv = new Niveis();

            bancoImagens = niv.difFacil();

            int i = 0;
            int[] posicaoOcupada = new int[16];
            int sorteio;

            for (i = 0; i < 16; i++)
            {
                do
                {
                    Random escolhaCaixa = new Random();
                    sorteio = escolhaCaixa.Next(0, 16);                                          //Sorteia uma caixa a ser preenchida

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
                if (MessageBox.Show("Parabéns, você ganhou!!\n\nDeseja jogar novamente?", "Parabéns!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
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

            if(excedeuLimiteTentativas())
            {
                if(MessageBox.Show("Você excedeu a quantidade de tentativas. Deseja Jogar Novamente?", "Ah não" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    exibePecas(botoes());
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

        public void exibePecas(Button[] pecas)
        {
            pecas.ToList().ForEach(botoes => botoes.Visible = false);
        }

        private void sairJogo_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Deseja sair do jogo atual ? ", "Confirmação ", MessageBoxButtons.YesNo);
            if(confirmacao == DialogResult.Yes){
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

        private void button1_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button1, 0);                                     //Identificação do botão clicado e sua posição
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button5, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button6, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button7, 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button8, 7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button9, 8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button10, 9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button11, 10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button12, 11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button13, 12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button14, 13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button15, 14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            gerenciaBotoes(button16, 15);
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

        private void JogarNivelFacil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }

        private Boolean excedeuLimiteTentativas()
        {
            if (Program.numTentativas != 0 && Program.numTentativas == tentativas)
            {
                return true;
            }
            return false;
        }
    }
}
