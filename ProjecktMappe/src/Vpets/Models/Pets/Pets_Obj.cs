using System;

namespace Vpets.Models.Pets
{
    public class Moony : Vpets.PetObjects
    {
        //public Moony(string name) { Name = name; }

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


    public class Speedy : Vpets.PetObjects
    {
        //public Speedy(string name) { Name = name; }

        // Small animal = plays a lot
        public override void Sleep()
        {
            // Speedy sleeps less but recovers faster.
            Energy -= Energy + 40;
            if (Energy < 0) Energy = 0;
            Console.WriteLine($"{Name} geschlaffen. Energie = {Energy}.");
        }
    }
}