using System;
using System.Collections.Generic;
using System.Text;
using OOP2.Auto;

class Program
{
    static void Main()
    {
        Auto bmw = new Auto("BMW", 0);
        Auto audi = new Auto("Audi", 0);

        bmw.Fahren();
        bmw.Stoppen();

        audi.Fahren();
        audi.Stoppen();

        Console.WriteLine($"Anzahl der Autos: {Auto.AnzahlAutos}");
    }
}