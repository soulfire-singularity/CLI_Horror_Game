using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Horror_Game
{
    public class MainMenu
    {
        public MainMenu()
        {
            Proceed startGame = new Proceed();
            Console.Clear();
            Loading loading = new Loading();
            GameInfo info = new GameInfo();
            Thread.Sleep(1000);
            info.DisplayGameInfo();
            Thread.Sleep(1000);
            Proceed playerIntro = new Proceed();
            Console.Clear();
        }
    }
}
