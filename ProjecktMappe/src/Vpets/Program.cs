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
            Pet myPet = new Moony("Moony");
            
            // Gibt den Namen des neuen Haustiers auf der Konsole aus
            Console.WriteLine($"Neues Haustier Namens {myPet.Name} wurde erstellt!");
            myPet.ShowStats();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("1 = Sauerstoffnachschub");
                Console.WriteLine("2 = Füttern");
                Console.WriteLine("3 = Schlafen");
                Console.WriteLine("4 = Spielen");
                Console.WriteLine("5 = Status anzeigen");
                Console.WriteLine("0 = Beenden");
                Console.Write("Eingabe: ");

                string input = Console.ReadLine();

                switch (input)
                {

                    case "1":
                        myPet.Feed(); break;
                    case "2":
                        myPet.Sleep(); break;
                    case "3":
                        myPet.Play(); break;
                    case "4":
                        myPet.ShowStats(); break;
                    case "0":
                        running = false;
                        Console.WriteLine("Spiel beendet."); break;
                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte 0 - 4 wählen."); break;
                }
            }
        }
    }
}
