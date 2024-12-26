using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Horror_Game
{
    public class Loading
    {
        public Loading()
        {
            Console.WriteLine("Loading, please wait...\n");

            // Length of the loading bar
            int total = 50;

            // Simulate loading
            for (int i = 0; i <= total; i++)
            {
                // Progress percentage
                int percent = (i * 100) / total;

                // Create the loading bar
                string bar = new string('#', i) + new string('-', total - i);

                // Display the loading bar and percentage
                Console.Write($"\r[{bar}] {percent}%");

                // Simulate some work
                Thread.Sleep(55);
            }
            Console.WriteLine("\n\nLoading complete!");
            Thread.Sleep(1000);
            Console.Clear();
        }

    }
}
