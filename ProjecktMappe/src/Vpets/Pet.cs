using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets

{
    internal class Pet // auch kann public sein
    {
        // Felder des Haustiers (zur Speicherung von Daten)
        public string Name { get; set; } = "Unnamed";
        public int Oxygen { get; set; } = 100;
        public int Hunger { get; set; } = 50;
        public int Energy { get; set; } = 80;
        public int Mood { get; set; } = 100;

        protected static int Clamp(int v) => v < 0 ? 0 : (v > 100 ? 100 : v);

        public void RefillOxygen(int amount = 100)
        {
            Oxygen = Clamp(Oxygen + amount);
            Console.WriteLine($"{Name} bekam Sauerstoff. O2 = {Oxygen}");
        }
        public void Feed()
        {
            Hunger = Clamp(Hunger - 20);
            Mood = Clamp(Mood + 5);
            Console.WriteLine($"{Name} wurde gefüttert. {Hunger}, {Mood} ausgegeben.");
        }
        public void Sleep()
        {
            Energy = Clamp(Energy + 60);
            Console.WriteLine($"{Name} hat geschlafen. {Energy} ausgegeben.");
        }
        public void Play()
        {
            Energy = Clamp(Energy - 10);
            Hunger = Clamp(Hunger + 5);
            Mood = Clamp(Mood +15);
            Console.WriteLine($"{Name} hat gespielt. {Energy}, {Hunger}, {Mood} ausgegeben.");
        }
        public void ShowStats()
        {
            Console.WriteLine($"Status von: {Name}: Oxygen = {Oxygen}, Hunger = {Hunger}, Laune = {Mood}, Energie = {Energy}");
        }
    }
}
