using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemoria
{
    class Imagens
    {
        public Image Imagem0 { get; set; }
        public Image Imagem1 { get; set; }
        public Image Imagem2 { get; set; }
        public Image Imagem3 { get; set; }
        public Image Imagem4 { get; set; }
        public Image Imagem5 { get; set; }
        public Image Imagem6 { get; set; }
        public Image Imagem7 { get; set; }
        public Image Imagem8 { get; set; }
        public Image Imagem9 { get; set; }
        public Image Imagem10 { get; set; }
        public Image Imagem11 { get; set; }
        public Image Imagem12 { get; set; }
        public Image Imagem13 { get; set; }
        public Image Imagem14 { get; set; }
        public Image Imagem15 { get; set; }
        public Image Imagem16 { get; set; }
        public Image Imagem17 { get; set; }
        public Image Imagem18 { get; set; }
        public Image Imagem19 { get; set; }
        public Image Imagem20 { get; set; }
        public Image Imagem21 { get; set; }
        public Image Imagem22 { get; set; }
        public Image Imagem23 { get; set; }
        public Image Imagem24 { get; set; }
        public Image Imagem25 { get; set; }
        public Image Imagem26 { get; set; }
        public Image Imagem27 { get; set; }
        public Image Imagem28 { get; set; }
        public Image Imagem29 { get; set; }
        public Image Imagem30 { get; set; }
        public Image Imagem31 { get; set; }
        public Image Imagem32 { get; set; }
        public Image Imagem33 { get; set; }
        public Image Imagem34 { get; set; }
        public Image Imagem35 { get; set; }
        public Image Imagem36 { get; set; }
        public Image Imagem37 { get; set; }
        public Image Imagem38 { get; set; }
        public Image Imagem39 { get; set; }
        public Image Imagem40 { get; set; }
        public Image Imagem41 { get; set; }
        public Image Imagem42 { get; set; }
        public Image Imagem43 { get; set; }
        public Image Imagem44 { get; set; }
        public Image Imagem45 { get; set; }
        public Image Imagem46 { get; set; }
        public Image Imagem47 { get; set; }
        public Image Imagem48 { get; set; }
        public Image Imagem49 { get; set; }
        public Image Imagem50 { get; set; }

        public Imagens(string tema = "")
        {
            tema = Program.tema;
            if (tema == "web")
            {
                Imagem0 = Properties.Resources.Amazon_256;
                Imagem1 = Properties.Resources.Apple_256;
                Imagem2 = Properties.Resources.Ask_256;
                Imagem3 = Properties.Resources.Ebay_256;
                Imagem4 = Properties.Resources.MSN_exporer_256;
                Imagem5 = Properties.Resources.Pretty_Linkedin_256;
                Imagem6 = Properties.Resources.Safety_Box_hot_128;
                Imagem7 = Properties.Resources.Skype_256;
                Imagem8 = Properties.Resources.Twitter_256;
                Imagem9 = Properties.Resources.Wikipedia_128;
                Imagem10 = Properties.Resources.Yahoo_256;
                Imagem11 = Properties.Resources.Youtube_256;
                Imagem12 = Properties.Resources.facebook;
                Imagem13 = Properties.Resources.google;
                Imagem14 = Properties.Resources.Mozilla_Firefox;
                Imagem15 = Properties.Resources.Internet_Explorer;
                Imagem16 = Properties.Resources.safari;
                Imagem17 = Properties.Resources.Opera;
                Imagem18 = Properties.Resources.google_chrome;
                Imagem19 = Properties.Resources.my_space;
                Imagem20 = Properties.Resources.Blogger;
                Imagem21 = Properties.Resources.bing;
                Imagem22 = Properties.Resources.dropbox;
                Imagem23 = Properties.Resources.security;
                Imagem24 = Properties.Resources.orkut;
                Imagem25 = Properties.Resources.java;
                Imagem26 = Properties.Resources.outlook;
                Imagem27 = Properties.Resources.utorrent;
                Imagem28 = Properties.Resources.netvibes;
                Imagem29 = Properties.Resources.wi_fi;
                Imagem30 = Properties.Resources.Índice_Buscape;
                Imagem31 = Properties.Resources.Netflix_Metro_256;
            }

            if (tema == "league")
            {
                Imagem0 = Properties.Resources.Ahri_Square_0;
                Imagem1 = Properties.Resources.Akali_Square_0;
                Imagem2 = Properties.Resources.Annie_Square_0;
                Imagem3 = Properties.Resources.Ashe_Square_0;
                Imagem4 = Properties.Resources.Blitzcrank_Square_0;
                Imagem5 = Properties.Resources.Caitlyn_Square_0;
                Imagem6 = Properties.Resources.Chogath_Square_0;
                Imagem7 = Properties.Resources.Darius_Square_0;
                Imagem8 = Properties.Resources.DrMundo_Square_0;
                Imagem9 = Properties.Resources.Draven_Square_0;
                Imagem10 = Properties.Resources.Evelynn_Square_0;
                Imagem11 = Properties.Resources.Ezreal_Square_0;
                Imagem12 = Properties.Resources.Fiddlesticks_Square_0;
                Imagem13 = Properties.Resources.Fizz_square_0;
                Imagem14 = Properties.Resources.Gangplank_Square_0;
                Imagem15 = Properties.Resources.Garen_Square_0;
                Imagem16 = Properties.Resources.Heimerdinger_Square_0;
                Imagem17 = Properties.Resources.Irelia_Square_0;
                Imagem18 = Properties.Resources.Jax_Square_0;
                Imagem19 = Properties.Resources.Jinx_Square_0;
                Imagem20 = Properties.Resources.Karthus_Square_0;
                Imagem21 = Properties.Resources.Kassadin_Square_0;
                Imagem22 = Properties.Resources.Katarina_Square_0;
                Imagem23 = Properties.Resources.Kayle_Square_0;
                Imagem24 = Properties.Resources.Leblanc_Square_0;
                Imagem25 = Properties.Resources.LeeSin_Square_0;
                Imagem26 = Properties.Resources.Lux_Square_0;
                Imagem27 = Properties.Resources.Malphite_Square_0;
                Imagem28 = Properties.Resources.MasterYi_Square_0;
                Imagem29 = Properties.Resources.Morgana_Square_0;
                Imagem30 = Properties.Resources.Nasus_Square_0;
                Imagem31 = Properties.Resources.Nunu_Square_0;
                Imagem32 = Properties.Resources.Renekton_Square_0;
                Imagem33 = Properties.Resources.Ryze_Square_0;
                Imagem34 = Properties.Resources.Soraka_Square_0;
                Imagem35 = Properties.Resources.Taric_Square_0;
                Imagem36 = Properties.Resources.Teemo_Square_0;
                Imagem37 = Properties.Resources.Tristana_Square_0;
                Imagem38 = Properties.Resources.Tryndamere_Square_0;
                Imagem39 = Properties.Resources.TwistedFate_Square_0;
                Imagem40 = Properties.Resources.Udyr_Square_0;
                Imagem41 = Properties.Resources.Vayne_Square_0;
                Imagem42 = Properties.Resources.Veigar_Square_0;
                Imagem43 = Properties.Resources.VelKoz_Square_0;
                Imagem44 = Properties.Resources.Vi_Square_0;
                Imagem45 = Properties.Resources.Vladimir_Square_0;
                Imagem46 = Properties.Resources.Volibear_Square_0;
                Imagem47 = Properties.Resources.Warwick_Square_0;
                Imagem48 = Properties.Resources.Yasuo_Square_0;
                Imagem49 = Properties.Resources.Ziggs_Square_0;
                Imagem50 = Properties.Resources.Zilean_Square_0;

                Imagem0.Tag = "Ahri";
                Imagem1.Tag = "Akali";
                Imagem2.Tag = "Annie";
                Imagem3.Tag = "Ashe";
                Imagem4.Tag = "Blitzcrank";
                Imagem5.Tag = "Caitlyn";
                Imagem6.Tag = "Chogath";
                Imagem7.Tag = "Darius";
                Imagem8.Tag = "DrMundo";
                Imagem9.Tag = "Draven";
                Imagem10.Tag = "Evelynn";
                Imagem11.Tag = "Ezreal";
                Imagem12.Tag = "Fiddlesticks";
                Imagem13.Tag = "Fizz";
                Imagem14.Tag = "Gangplank";
                Imagem15.Tag = "Garen";
                Imagem16.Tag = "Heimerdinger";
                Imagem17.Tag = "Irelia";
                Imagem18.Tag = "Jax";
                Imagem19.Tag = "Jinx";
                Imagem20.Tag = "Karthus";
                Imagem21.Tag = "Kassadin";
                Imagem22.Tag = "Katarina";
                Imagem23.Tag = "Kayle";
                Imagem24.Tag = "Leblanc";
                Imagem25.Tag = "LeeSin";
                Imagem26.Tag = "Lux";
                Imagem27.Tag = "Malphite";
                Imagem28.Tag = "MasterYi";
                Imagem29.Tag = "Morgana";
                Imagem30.Tag = "Nasus";
                Imagem31.Tag = "Nunu";
                Imagem32.Tag = "Renekton";
                Imagem33.Tag = "Ryze";
                Imagem34.Tag = "Soraka";
                Imagem35.Tag = "Taric";
                Imagem36.Tag = "Teemo";
                Imagem37.Tag = "Tristana";
                Imagem38.Tag = "Tryndamere";
                Imagem39.Tag = "TwistedFate";
                Imagem40.Tag = "Udyr";
                Imagem41.Tag = "Vayne";
                Imagem42.Tag = "Veigar";
                Imagem43.Tag = "VelKoz";
                Imagem44.Tag = "Vi";
                Imagem45.Tag = "Vladimir";
                Imagem46.Tag = "Volibear";
                Imagem47.Tag = "Warwick";
                Imagem48.Tag = "Yasuo";
                Imagem49.Tag = "Ziggs";
                Imagem50.Tag = "Zilean";
            }
        }
    }
}
