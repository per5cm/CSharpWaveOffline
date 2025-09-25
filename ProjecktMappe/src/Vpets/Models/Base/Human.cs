using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vpets.Models.Base

{
    public class Human : Creature
    {
        public Human(string name) : base(name) { }
        public virtual void Work()
        {
            Energy = Clamp(Energy - 30);
            Mood = Clamp(Mood - 5);
            Console.WriteLine($"{Name} hat gearbeitet. Energie ={Energy}, Laune ={Mood}");
        }
    }
}