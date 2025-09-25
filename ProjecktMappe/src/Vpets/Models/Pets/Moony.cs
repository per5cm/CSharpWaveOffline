using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpets.Models.Pets
{
    public class Moony : Vpets.Pet
    {
        public Moony(string name) : base(name) { }

        // Small animal = plays a lot
        public override void Play()
        {
            // Moony play harder
            Energy -= Energy - 15;
            if (Energy < 0) Energy = 0; // Energy = Clamp(Energy - 15);
            Mood += 10;
            if (Mood > 100) Mood = 100; // Mood = Clamp(Mood + 10);
            Hunger += 20;
            if (Hunger < 0) Hunger = 0; // Hunger = Clamp(Hunger + 20);
            Console.WriteLine($"{Name} hat gespielt. Energie = {Energy}, Hunger = {Hunger}, Laune = {Mood}");
        }
    }
}