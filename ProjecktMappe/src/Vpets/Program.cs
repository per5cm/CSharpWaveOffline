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
                Name = "Silke",
                Oxygen = 200,
                Hunger = 50,
                Energy = 80,
                Mood = 100
            };
            // Gibt den Namen des neuen Haustiers auf der Konsole aus
            Console.WriteLine($"Neues Haustier Namens {myPet.Name} wurde erstellt!");
            Console.WriteLine($"Hunger = {myPet.Hunger}, Energie = {myPet.Energy}, Laune = {myPet.Mood}");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1 = Füttern");
                Console.WriteLine("2 = Schlafen");
                Console.WriteLine("3 = Spielen");
                Console.WriteLine("4 = Status anzeigen");
                Console.WriteLine("0 = Beenden");
                Console.Write("Eingabe: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        myPet.Feed();
                        break;
                    case "2":
                        myPet.Sleep();
                        break;
                    case "3":
                        myPet.Play();
                        break;
                    case "4":
                        myPet.ShowStats();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Spiel beendet.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte 0 - 4 wählen.");
                        break;
                }
            }
        }
    }
}
