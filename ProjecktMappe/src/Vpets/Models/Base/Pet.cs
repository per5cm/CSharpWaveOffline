using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets.Models.Base
{
    public class Pet : Creatures
    {
        public Pet(string name) : base(name) { }
        public virtual void Play()
        {
            Energy = Clamp(Energy - 10);
            Hunger = Clamp(Hunger + 5);
            Mood = Clamp(Mood + 15);
            Console.WriteLine($"{Name} hat gespielt. Energy ={Energy}, Hunger ={Hunger}, Mood ={Mood} ausgegeben.");
        }
    }
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
            Console.WriteLine($"{Name} Power Schläfchen");
        }
    }
}