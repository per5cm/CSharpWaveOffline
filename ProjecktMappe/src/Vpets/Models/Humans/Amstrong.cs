using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vpets.Models.Base; // inheritance line.

namespace Vpets.Models.Humans
{
    public class Amstrong : Human // class tauschen
    {
        public Amstrong(string name) : base(name) { }

        // Amstrong gets hungry faster.
        public override void Work()
        {
            Energy -= Energy - 5;
            if (Energy < 0) Energy = 0; // Energy = Clamp(Energy - 5);
            Mood += 5;
            if (Mood > 100) Mood = 100; // Mood = Clamp(Mood +5);
            Hunger += 10;
            if (Hunger < 0) Hunger = 0; // Hunger = Clamp(Hunger + 10);
            Console.WriteLine($"{Name} hat gespielt. Energie = {Energy}, Hunger = {Hunger}, Laune = {Mood}");
        }
    }
}