using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CLI_Horror_Game
{
    public class Player
    {
        // Player Name Property
        public string Name { get; set; }
        
        // Player Bio Property
        public string Bio { get; set; }

        // Player Health Property
        public int Health { get; set; }
        
        // Player IsAlive Property
        public bool IsAlive => Health > 0;
        
        // Player Sanity Property
        public int Sanity { get; set; }
        
        // Player IsSane Property
        public bool IsSane => Sanity > 0;
        
        // Player Constructor
        public Player(int initialHealth = 100, int initialSanity = 100)
        {
            SetName();
            Bio = "No Bio Avaliable";
            Health = initialHealth;
            Sanity = initialSanity;
        }
        public void SetName()
        {
            Console.WriteLine("Enter the name of your player:");
            Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Unknown Player"; // Default name if no input is provided
            }
            Console.WriteLine($"Player name set to: {Name}");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void InputBio()
        {
            Console.WriteLine("Enter a short bio for your player:");
            Bio = Console.ReadLine();
            Console.WriteLine("Bio updated!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        // Damage Method
        public void TakeDamage(int damage)
        {
            if (damage < 0) throw new ArgumentException("Damage cannot be negative.");
            Health -= damage;

            if (Health <= 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} has died.");
            }
            else
            {
                Console.WriteLine($"{Name} took {damage} damage. Remaining health: {Health}");
            }
        }
        
        // Reduce Sanity Method
        public void ReduceSanity(int sanity)
        {
            if (sanity < 0) throw new ArgumentException("Sanity cannot be negative.");
            Health -= sanity;

            if (Sanity <= 0)
            {
                Sanity = 0;
                Console.WriteLine($"{Name} is insane.");
            }
            else
            {
                Console.WriteLine($"{Name} has {sanity} Insanity. Remaining Sanity: {Sanity}");
            }
        }

        // Heal Method
        public void Heal(int amount)
        {
            if (amount < 0) throw new ArgumentException("Heal amount cannot be negative.");
            Health += amount;
            Console.WriteLine($"{Name} healed by {amount}. Current health: {Health}");
        }

        //
        public void RestoreSanity(int amount)
        {
            if (amount < 0) throw new ArgumentException("Restore sanity amount cannot be negative.");
            Health += amount;
            Console.WriteLine($"{Name} Sanity restored by {amount}. Current sanity: {Sanity}");
        }

        public void DisplayPlayerStatus()
        {
            Console.WriteLine($"Player: {Name}\nBio: {Bio}\nHealth: {Health}\nSanity: {Sanity}\nAlive: {IsAlive}");
        }
    }
}
