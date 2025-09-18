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
        public string NamePet { get; set; }
        // public int Oxygen { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public int Mood { get; set; }

        public void Feed()
        {
            Hunger -= 20;
            Mood += 5;
            Console.WriteLine($"{Name} wurde gefüttert. {Hunger}, {Mood} ausgegeben.");
        }
        public void Sleep()
        {
            Energy += 60;
            Console.WriteLine($"{Name} hat geschlafen. {Energy} ausgegeben.");
        }
        public void Play()
        {
            Energy = -10;
            Hunger = +5;
            Mood = +15;
            Console.WriteLine($"{Name} hat gespielt. {Energy}, {Hunger}, {Mood} ausgegeben.");
        }
        public void ShowStats()
        {
            Console.WriteLine($"Status von: {Name}: Oxygen = {Oxygen}, Hunger = {Hunger}, Laune = {Mood}, Energie = {Energy}");
        }
    }
}
