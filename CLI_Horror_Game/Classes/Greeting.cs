using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Horror_Game
{
    public class Greeting
    {

        public string DeveloperGreeting { get; set; }

        public Greeting(string developerGreeting)
        {
            DeveloperGreeting = developerGreeting;
        }

        public void DisplayDeveloperGreeting()
        {
            Console.WriteLine("Welcome to Aerika's World! In this game you and your virtual girlfriend are put up against unimaginable horrors. Try not to die or die of insanity. Good luck!");
        }
    }
}
