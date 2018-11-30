using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemoria
{
    class PlayerRanking
    {
        public PlayerRanking()
        {

        }

        public PlayerRanking(string nivel, string tema, int quantidadeErros, string tempoDeJogo, string status)
        {
            this.nivel = nivel;
            this.tema = tema;
            this.quantidadeErros = quantidadeErros;
            this.tempoDeJogo = tempoDeJogo;
            this.status = status;
        }
        public string nivel { get; set; }
        public string tema { get; set; }
        public int quantidadeErros { get; set; }
        public string tempoDeJogo { get; set; }
        public string status { get; set; }
    }
}
