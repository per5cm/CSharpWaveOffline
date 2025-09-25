using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpets.Models.Humans
{
    public class Amstrong : Vpets.Human // class tauschen
    {
        public Amstrong(string name) : base(name) { }

        // Amstrong gets hungry faster.
        public override void Work()
        {
            Energy -= Energy - 5;
            if (Energy < 0) Energy = 0;
            Mood += 5;
            if (Mood > 100) Mood = 100;
            Hunger += 10;
            if (Hunger < 0) Hunger = 0;
            Console.WriteLine($"{Name} hat gespielt. Energie = {Energy}, Hunger = {Hunger}, Laune = {Mood}");
        }
    }
}