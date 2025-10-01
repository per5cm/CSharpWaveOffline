using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vpets.Models.Base; // inheritance line.

namespace Vpets.Models.Pets
{
    public class Speedy : Pet
    {
        public Speedy(string name) : base(name) { }

        // Small animal = plays a lot
        public override void Sleep()
        {
            // Speedy sleeps less but recovers faster.
            Energy -= Energy + 40;
            if (Energy < 0) Energy = 0;
            Console.WriteLine($"{Name} geschlaffen. Energie = {Energy}.");
            GainXp(5, "Hat gespielt!");
        }
    }
}
