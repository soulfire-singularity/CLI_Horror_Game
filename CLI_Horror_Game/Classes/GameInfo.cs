using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Horror_Game
{
    public class GameInfo
    {
        // GameInfo Properties
        public string GameTitle { get; set; }
        public string GameDescription { get; set; }
        public string GameVersion { get; set; }
        public string VersionState { get; set; }
        public string GameDeveloper {  get; set; }

        // GameInfo Constructor
        public GameInfo(string gameTitle = "Aerika's World", string currentVersion = "1.0.0", string versionState = "Alpha", string gameDescription = "CLI style horror/dating simulation game.", string gameDeveloper = "Ethan Norman")
        {
            GameTitle = gameTitle;
            GameDescription = gameDescription;
            GameVersion = currentVersion;
            VersionState = versionState;
            GameDeveloper = gameDeveloper;
        }

        //GameInfo Methods

        public void DisplayGameInfo()
        {
            Console.WriteLine($"Game Title: {GameTitle}\nGame Description: {GameDescription}\nGame Version: {GameVersion + " " + VersionState}\nGame Developer: {GameDeveloper}");
            
        }
    }
}
