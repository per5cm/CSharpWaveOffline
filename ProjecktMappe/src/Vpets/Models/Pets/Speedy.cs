using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vpets.Models.Pets
{
    public class Speedy : Vpets.Pet
    {
        public Speedy(string name) : base(name) { }

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
