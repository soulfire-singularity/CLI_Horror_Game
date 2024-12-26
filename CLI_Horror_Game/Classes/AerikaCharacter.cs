using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CLI_Horror_Game
{
    public class AerikaCharacter
    {

        
        public string Name { get; set; }

        public string Bio {  get; set; }

        public string Description { get; set; }

        
        public int Health { get; set; }

        
        public bool IsAlive => Health > 0;

        
        public int Sanity { get; set; }

        
        public bool IsSane => Sanity > 0;

        public AerikaCharacter(string name, int initialHealth = 100, int initialSanity = 100)
        {
            Name = name;
            Health = initialHealth;
            Sanity = initialSanity;
            Bio = "Your virtual girlfriend.";
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
            Sanity -= sanity;

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

        // Restore Sanity Method
        public void RestoreSanity(int amount)
        {
            if (amount < 0) throw new ArgumentException("Restore sanity amount cannot be negative.");
            Health += amount;
            Console.WriteLine($"{Name} Sanity restored by {amount}. Current sanity: {Sanity}");
        }

        public void DisplayAerikaStatus()
        {
            Console.WriteLine($"Character: {Name}\nBio: {Bio}\nHealth: {Health}\nSanity: {Sanity}\nAlive: {IsAlive}");
        }

    }
}
