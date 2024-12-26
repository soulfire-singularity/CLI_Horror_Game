using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Horror_Game
{
    public class PlayMenuMusic
    {
        public static void MenuMusic(string filepath) {
            SoundPlayer menuMusic = new SoundPlayer();
            menuMusic.SoundLocation = filepath;
            menuMusic.PlayLooping();



        }
        public static void StopMusic() {
            SoundPlayer stopMusic = new SoundPlayer();
            if (Console.ReadKey().Key != ConsoleKey.S)
            {
                stopMusic.Stop();
            }

        }
        
}
}
