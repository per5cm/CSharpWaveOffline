// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Hallo Welt.
    // static void SagHallo()
    // {
    //     Console.WriteLine("Hallo Welt! Ich Liebe Pizza!");
    // }

    // static void Main(string[] args)
    // {
    //     SagHallo();
    // }

    // Hallo Zu.
    // static void SagHalloZu(string name)
    // {
    //     Console.WriteLine("Hallo, " + name);
    // }

    // static void Main(string[] args)
    // {
    //     SagHalloZu("Maria!");
    //     SagHalloZu("Alibaba!");
    //     SagHalloZu("Max!");
    // }

    // Rückgabe von Methoden
    // static int VerdoppleZahl(int x)
    // {
    //     return 2 * x;
    // }

    // static void Main(string[] args)
    // {
    //     Console.WriteLine("5 verdoppelt ist: " + VerdoppleZahl(5));
    //     Console.WriteLine("12 verdoppelt ist: " + VerdoppleZahl(12));
    // }

    // Mehrere Methode gemeinsam verwenden.
    // static int Addiere(int x, int y)
    // {
    //     return x + y;
    // }
    // static void SchreibeErgebnis(int wert)
    // {
    //     Console.WriteLine($"Das Ergebnis ist: {wert}");
    // }
    // static void Main(string[] args)
    // {
    //     int summe = Addiere(10, 5);
    //     SchreibeErgebnis(summe);
    // }

    // Ausgangscode "all in one".
    static void Main()
    {
        Console.WriteLine("Bitte gib die Temperatur in Celsius ein:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine(celsius + "°C sind " + fahrenheit + "°F");

        if (celsius < 0)
        {
            Console.WriteLine("Es ist sehr kalt!");
        }
        else if (celsius > 30)
        {
            Console.WriteLine("Es ist heiß!");
        }
        else
        {
            Console.WriteLine("Die Temperatur ist angenehm.");
        }
    }
}