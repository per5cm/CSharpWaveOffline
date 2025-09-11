using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new()
            {
                Name = "Amstrong",
                Hunger = 50,
                Energy = 80,
                Mood = 90
            };
            // Gibt den Namen des neuen Haustiers auf der Konsole aus
            Console.WriteLine($"Neues Haustier Namens {myPet.Name} wurde erstellt!");
        }
    }
}
