using System;
using System.Globalization;

class Program
{
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("1) Verbrauch  2) Temperatur  3) BMI  0) Ende");
        while (true)
        {
            var choice = ReadInt("Auswahl", 0, 3);
            if (choice == 0) break;

            switch (choice)
            {
                case 1: FuelConsumption(); break;
                case 2: TemperaturePhase(); break;
                case 3: BmiCalculator(); break;
            }
        }
    }

    // --- Helpers ---
    static int ReadInt(string label, int min, int max)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
            if (int.TryParse(Console.ReadLine(), out var n) && n >= min && n <= max)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDouble(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            var s = Console.ReadLine();
            if (double.TryParse(s, NumberStyles.Float, De, out var x) && x > minExclusive)
                return x;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    // --- Tasks ---
    static void FuelConsumption()
    {
        Console.WriteLine("\nDurchschnittsverbrauch (l/100km)");
        var km = ReadDouble("Gefahrene Kilometer (>0)", 0);
        var liter = ReadDouble("Verbrauchte Benzinmenge in Litern (>=0)", -1);
        var verbrauch = (liter / km) * 100.0;
        Console.WriteLine($"Verbrauch: {verbrauch.ToString("F2", De)} l/100km\n");
    }

    static void TemperaturePhase()
    {
        Console.WriteLine("\nTemperaturzustand von Wasser");
        var c = ReadDouble("Temperatur in °C");
        if (c < 0) Console.WriteLine("Zustand: Eis\n");
        else if (c <= 100) Console.WriteLine("Zustand: Wasser\n");
        else Console.WriteLine("Zustand: Dampf\n");
    }

    static void BmiCalculator()
    {
        Console.WriteLine("\nBMI-Rechner");
        var cm = ReadDouble("Größe in cm (>0)", 0);
        var kg = ReadDouble("Gewicht in kg (>0)", 0);
        var m = cm / 100.0;
        var bmi = kg / (m * m);

        string cat = bmi switch
        {
            < 18.5 => "Untergewicht",
            < 25.0 => "Normalgewicht",
            < 30.0 => "Übergewicht",
            _      => "Adipositas"
        };

        Console.WriteLine($"BMI: {bmi.ToString("F1", De)} – {cat}\n");
    }
}
