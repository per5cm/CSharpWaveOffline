using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Tier
{
    internal class Tier
    {
        internal string Art { get; set; }
        internal string Name { get; set; }
        internal string Laut { get; set; }

        internal Tier(string art, string name, string laut)
        {
            Art = art;
            Name = name;
            Laut = laut;
        }

        internal void MachLaut()
        {
            Console.WriteLine($"{Art} {Name} macht: {Laut}");
        }
    }
}
