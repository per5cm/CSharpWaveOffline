using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2.Auto
{
    internal class Auto
    {
        internal string Marke { get; set; }
        internal int Geschwindigkeit {  get; set; }
        internal static int AnzahlAutos = 0;

        internal Auto(string marke, int geschwindigkeit)
        {
            Marke = marke;
            Geschwindigkeit = geschwindigkeit;
            AnzahlAutos++;
        }

        internal void Fahren()
        {
            Console.WriteLine($"{Marke} Fährt mit {Geschwindigkeit + 40} km/h los!");
        }
        internal void Stoppen()
        {
            Console.WriteLine($"{Marke} hält an.");
        }
    }
}
