using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    static class Program
    {
        public static string tema = "";
        public static string cor = "";
        public static int numTentativas = 0;
        public static Boolean soundLol = false;
        public static string nomeJogador = "Jogador 1";
        public static decimal quantidadeRanking = 7;
        public static List<PlayerRanking> playerRankings;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            playerRankings = new List<PlayerRanking>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
