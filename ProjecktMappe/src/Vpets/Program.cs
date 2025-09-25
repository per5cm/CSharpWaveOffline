using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vpets.Models.Base;
using Vpets.Models.Pets;
using Vpets.Models.Humans;


namespace Vpets
{
    internal class Program
    {
        private static readonly System.Timers.Timer worldTimer = new(3000) {AutoReset = true};
        static void Main(string[] args)
        {
            var zoo = new List<Creature>
            {
                new Moony("Moony"),
                new Speedy("Speedy"),
                new Amstrong("Amstrong"),
                new Gagarin("Gagarin")
            };

            Console.WriteLine("List initialisierung");
            foreach (var time in zoo) time.ShowStats();

            worldTimer.Elapsed += (s, e) => TickAll(zoo);
            worldTimer.Start();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n ----- Wähle ein Objekt -----");
                for (int i = 0; i < zoo.Count; i++)
                    Console.WriteLine($"{i} = {zoo[i].Name}");

                Console.Write("Index (oder 'q' zum Beenden): ");
                string? sel = Console.ReadLine();
                if (string.Equals(sel, "q", StringComparison.OrdinalIgnoreCase))
                {
                    running = false;
                    break;
                }
                if (!int.TryParse(sel, out int idx) || idx < 0 || idx >= zoo.Count)
                {
                    Console.WriteLine("Ungültiger Index."); continue;
                }

                var target = zoo[idx];
                Console.WriteLine($"\nAktion für [{target.Name}] wählen: ");
                Console.WriteLine("1 = Sauerstoffnachschub");
                Console.WriteLine("2 = Füttern");
                Console.WriteLine("3 = Schlafen");
                Console.WriteLine("4 = Spielen");
                Console.WriteLine("5 = Arbeiten");
                Console.WriteLine("6 = Status anzeigen");
                Console.WriteLine("0 = Beenden");

                Console.Write("Eingabe: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                switch (input)
                {

                    case "1": target.RefillOxygen(); break;
                    case "2": target.Feed(); break;
                    case "3": target.Sleep(); break;
                    case "4":
                        if (target is Pet p) p.Play();
                        else Console.WriteLine($"{target.Name} ist kein Pet"); break;
                    case "5":
                        if (target is Human h) h.Work();
                        else Console.WriteLine($"{target.Name} ist kein Mensch"); break;
                    case "6": target.ShowStats(); break;
                    case "0": break;
                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte 0 - 6 wählen."); break;
                }
            }
            // Stop timer. when case 0 pressed.
            worldTimer.Stop();
            worldTimer.Dispose();
            Console.WriteLine("Spiel beendet.");
        }
        private static void TickAll(List<Creature> zoo)
        {
            foreach (var time in zoo) time.PassTime();
            // Optional to show name.
            Console.WriteLine("Die Zeit vergeht für alle...");
            foreach (var time in zoo) time.ShowStats();
        }
    }
}
