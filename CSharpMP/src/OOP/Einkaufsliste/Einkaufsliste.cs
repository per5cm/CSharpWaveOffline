using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Einkaufsliste
{
    internal class Produkt
    {
        internal string Name { get; set; }
        internal double Preis { get; set; }
        internal int Anzahl { get; set; }

        internal Produkt (string name, double preis, int anzahl)
        {
            Name = name;
            Preis = preis;
            Anzahl = anzahl;
        }

        internal double Gesamtpreis()
        {           
            Console.WriteLine($"{Name} - {Preis} EUR pro Stück. Gesamtpreis: {Preis * Anzahl} EUR.");
            return Preis * Anzahl;
        }
    }
}
