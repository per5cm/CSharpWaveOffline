// =========================================
// METHODS PRACTICE FILE
// Sammlung von Aufgaben zu Methoden
// =========================================

using System;
using System.Globalization;

class Program
{
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("=== Methoden Übungen ===\n");

        // ---- Aktive Aufgabe hier aufrufen ----
        TemperaturProgramm();

        // Beispiel: weitere Aufgaben testen
        // SagHallo();
        // SagHalloZu("Maria");
        // SchreibeErgebnis(VerdoppleZahl(5));
    }


    // =========================================
    // Beispiel 1 – Methode ohne Parameter
    // =========================================
    static void SagHallo()
    {
        Console.WriteLine("Hallo Welt!");
    }


    // =========================================
    // Beispiel 2 – Methode mit Parameter
    // =========================================
    static void SagHalloZu(string name)
    {
        Console.WriteLine($"Hallo {name}!");
    }


    // =========================================
    // Beispiel 3 – Methode mit Rückgabewert
    // =========================================
    static int VerdoppleZahl(int x)
    {
        return x * 2;
    }


    // =========================================
    // Beispiel 4 – Methoden kombinieren
    // =========================================
    static int Addiere(int a, int b)
    {
        return a + b;
    }

    static void SchreibeErgebnis(int wert)
    {
        Console.WriteLine($"Das Ergebnis ist: {wert}");
    }


    // =========================================
    // AKTUELLE AUFGABE – Temperaturrechner
    // =========================================
    static double LiesTemperatur()
    {
        while (true)
        {
            Console.Write("Temperatur in °C eingeben: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x))
                return x;

            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double CelsiusZuFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }

    static void TemperaturBewertung(double c)
    {
        if (c < 0) Console.WriteLine("Es ist sehr kalt!");
        else if (c > 30) Console.WriteLine("Es ist heiß!");
        else Console.WriteLine("Das Wetter ist angenehm.");
    }

    static void TemperaturProgramm()
    {
        double c = LiesTemperatur();
        double f = CelsiusZuFahrenheit(c);

        Console.WriteLine($"{c:F1}°C sind {f:F1}°F");
        TemperaturBewertung(c);
    }
}
