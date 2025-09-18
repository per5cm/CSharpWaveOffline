using System;

namespace Vpets.Models.Pets
{
    internal class Moony : Pet
    {
        public Moony(string name) : base(name) { }

        // Small animal = plays a lot
        public override void Play()
        {
            Energy -= Energy - 5;
            if (Energy < 0) Energy = 0;
            Mood += 5;
            if (Mood > 100) Mood = 100;
            Hunger += 5;
            if (Hunger < 0) Hunger = 0;
            Console.WriteLine($"{Name} hat gespielt. Energie = {Energy}, Hunger = {Hunger}, Laune = {Mood}");
        }
    }
}