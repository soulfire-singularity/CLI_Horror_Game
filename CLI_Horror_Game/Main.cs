using CLI_Horror_Game;
using System.Threading;
using System.Media;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        // Change path depending on where you have the repository saved in your directory
        // PlayMenuMusic.MenuMusic(@"\CLI_Horror_Game\CLI_Horror_Game\GameMusic\Menu.wav");
        Console.Title = "Aerika's World";
        MainMenu mainMenu = new MainMenu();
        Player player = new Player();
        player.InputBio();  // Prompt the user to enter a bio
        player.DisplayPlayerStatus();  // Display player stats
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Press 'S' to start...");
        PlayMenuMusic.StopMusic();
        Console.Clear();
        Greeting greeting = new Greeting("");
        greeting.DisplayDeveloperGreeting();


    }
}
