using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemoria
{
    class Som
    {
        public void executaSomHeroi(Image img)
        {
            if (Program.tema == "league")
            {
                var player1 = new WMPLib.WindowsMediaPlayer();
                player1.URL = Directory.GetCurrentDirectory().ToString() + @"\som\" + img.Tag.ToString() + ".mp3";
            }
        }

        public void somAmbiente()
        {
            if (Program.tema == "league")
            {
                SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory().ToString() + @"\som\Ambiente.wav");
                simpleSound.Play();
            }
        }

        public void vitoria()
        {
            if (Program.tema == "league")
            {
                SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory().ToString() + @"\som\Vitoria.wav");
                simpleSound.Play();
            }
        }

        public void stop()
        {
            if (Program.tema == "league")
            {
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();
            }
        }
    }
}
