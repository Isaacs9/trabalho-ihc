using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemoria
{
    class Niveis : Imagens
    {
        public Image[] difFacil()
        {
            Image[] vetorImagens = { Imagem0, Imagem0, Imagem1, Imagem1, Imagem2, Imagem2, Imagem3, Imagem3,
                                   Imagem4, Imagem4, Imagem5, Imagem5, Imagem6, Imagem6, Imagem7, Imagem7};              //A imagem pode ser usada somente 2 vezes (2 unidades de cada)

            return vetorImagens;
        }

        public Image[] difMedio()
        {
            Image[] vetorImagens = { Imagem0, Imagem0, Imagem1, Imagem1, Imagem2, Imagem2, Imagem3, Imagem3,
                                   Imagem4, Imagem4, Imagem5, Imagem5, Imagem6, Imagem6, Imagem7, Imagem7, Imagem8,
                                   Imagem8, Imagem9, Imagem9, Imagem10, Imagem10, Imagem11, Imagem11,
                                   Imagem12, Imagem12, Imagem13, Imagem13, Imagem14, Imagem14, Imagem15, Imagem15, Imagem16, Imagem16, Imagem17, Imagem17};      //A imagem pode ser usada somente 2 vezes (2 unidades de cada)

            return vetorImagens;
        }

        public Image[] difDificil()
        {
            Image[] vetorImagens = { Imagem0, Imagem0, Imagem1, Imagem1, Imagem2, Imagem2, Imagem3, Imagem3,
                                   Imagem4, Imagem4, Imagem5, Imagem5, Imagem6, Imagem6, Imagem7, Imagem7, Imagem8,
                                   Imagem8, Imagem9, Imagem9, Imagem10, Imagem10, Imagem11, Imagem11,
                                   Imagem12, Imagem12, Imagem13, Imagem13, Imagem14, Imagem14, Imagem15, Imagem15, Imagem16, Imagem16, Imagem17, Imagem17,
                                   Imagem18, Imagem18, Imagem19, Imagem19, Imagem20, Imagem20, Imagem21, Imagem21,
                                   Imagem22, Imagem22, Imagem23, Imagem23, Imagem24, Imagem24, Imagem25, Imagem25, Imagem26,
                                   Imagem26, Imagem27, Imagem27, Imagem28, Imagem28, Imagem29, Imagem29,
                                   Imagem30, Imagem30, Imagem31, Imagem31};                                                                                     //A imagem pode ser usada somente 2 vezes (2 unidades de cada)

            return vetorImagens;
        }
    }
}
