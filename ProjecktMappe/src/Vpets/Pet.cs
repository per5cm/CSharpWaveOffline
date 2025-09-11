using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets

{
    internal class Pet
    {
        // Felder des Haustiers (zur Speicherung von Daten)
        public string Name = "Amstrong";
        public int Hunger;
        public int Energy;
        public int Mood;

        public void Feed()
        {
            Hunger -= 20;
            Mood += 5;
            Console.WriteLine($"Amstrong wurde gefüttert. {Hunger}, {Mood} ausgegeben.");
        }
        public void Sleep()
        {
            Energy += 100;
        }
        public void Play()
        {

        }
        public void ShowStats()
        {

        }
    }
}
