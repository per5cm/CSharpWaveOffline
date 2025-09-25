using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets

{
    public abstract class PetObjects // auch kann public sein
    {
        // Felder des Haustiers (zur Speicherung von Daten)
        public string Name { get; set; }
        public int Oxygen { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public int Mood { get; set; }

        protected const int MaxValue = 100;
        protected static int Clamp(int v) => v < 0 ? 0 : (v > MaxValue ? MaxValue : v);
        protected PetObjects(string name)
        {
            Name = name;
            Oxygen = 100;
            Hunger = 50;
            Energy = 80;
            Mood = 100;
        }

        public virtual void RefillOxygen()
        {
            Oxygen = Clamp(Oxygen + 50);
            Console.WriteLine($"{Name} wurde Sauerstoff erhöht. Sauerstoff ={Oxygen} ausgegeben.");
        }
        public virtual void Feed()
        {
            Hunger = Clamp(Hunger - 20);
            Mood = Clamp(Mood + 5);
            Console.WriteLine($"{Name} wurde gefüttert. Hunger ={Hunger}, Laune ={Mood} ausgegeben.");
        }
        public virtual void Sleep()
        {
            Energy = Clamp(Energy + 60);
            Hunger = Clamp(Hunger + 5);
            Console.WriteLine($"{Name} hat geschlafen. Energie ={Energy}, Hunger ={Hunger} ausgegeben.");
        }
        public virtual void Play()
        {
            Energy = Clamp(Energy - 10);
            Hunger = Clamp(Hunger + 5);
            Mood = Clamp(Mood + 15);
            Console.WriteLine($"{Name} hat gespielt. Energy ={Energy}, Hunger ={Hunger}, Mood ={Mood} ausgegeben.");
        }
        public virtual void PassTime()
        {
            Oxygen = Clamp(Oxygen - 5);
            Hunger = Clamp(Hunger + 5);
            Energy = Clamp(Energy - 5);
            Mood = Clamp(Mood - 3);
        }
        public virtual void ShowStats()
        {
            Console.WriteLine($"Status von: {Name}: Oxygen = {Oxygen}, Hunger={Hunger}, Laune={Mood}, Energie={Energy}");
        }
    }

    // Class Branches 
    public class Pet : PetObjects
    {
        public Pet(string name) : base(name) { }
    }

    public class Human : PetObjects
    {
        public Human(string name) : base(name) { }
    }

    // Specifics or "Players" with different rules(maybe)

    public class Moony : Pet
    {
        public Moony(string name) : base(name) { }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{Name} spielt extra hart!");
        }
    }

    public class Speedy : Pet
    {
        public Speedy(string name) : base(name) { }
        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine($"{Name} power Schäfchen");
        }
    }

    public class Amstrong : Human
    {
        public Amstrong(string name) : base(name) { }
    }

    public class Gagarin : Human
    {
        public Gagarin(string name) : base(name) { }
    }
}