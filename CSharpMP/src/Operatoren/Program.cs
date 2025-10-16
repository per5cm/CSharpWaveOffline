using System;
using System.Globalization;

class Program
{
    // Deutsch: 1,5 statt 1.5
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("Operatoren – Übungssammlung\n");

        Rechner();           // + - * / % (mit Guards)
        Verbrauch();         // l/100 km
        DreiecksFlaeche();   // A = (g*h)/2
        Waehrungsrechner();  // EUR -> USD (Demo-Kurs)
        Schreinerei();       // Stückzahl + Verschnitt
    }

    // ---------- Helpers ----------
    static int ReadInt(string label, int minInclusive = int.MinValue, int maxInclusive = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) &&
                n >= minInclusive && n <= maxInclusive)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDouble(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x) && x > minExclusive)
                return x;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    // ---------- 1) Rechner ----------
    static void Rechner()
    {
        Console.WriteLine("Rechner\nBitte geben Sie zwei ganze Zahlen ein.");
        int a = ReadInt("Zahl 1");
        int b = ReadInt("Zahl 2");

        Console.WriteLine($"Summe:      {a + b}");
        Console.WriteLine($"Differenz:  {a - b}");
        Console.WriteLine($"Produkt:    {a * b}");

        if (b != 0)
        {
            Console.WriteLine($"Quotient:   {(a / (double)b).ToString("F2", De)}"); // Division
            Console.WriteLine($"Rest (mod): {a % b}");                               // Modulo
        }
        else
        {
            Console.WriteLine("Quotient:   Division durch 0 nicht möglich");
            Console.WriteLine("Rest (mod): nicht definiert");
        }

        Console.WriteLine();
    }

    // ---------- 2) Durchschnittsverbrauch ----------
    static void Verbrauch()
    {
        Console.WriteLine("Durchschnittsverbrauch (l/100 km)");
        double km = ReadDouble("Gefahrene Kilometer (>0)", 0);
        double liter = ReadDouble("Verbrauchte Benzinmenge in Litern (>=0)", -1);

        double verbrauch = (liter / km) * 100.0;
        Console.WriteLine($"Der Durchschnittsverbrauch ist: {verbrauch.ToString("F2", De)} l/100 km\n");
    }

    // ---------- 3) Dreiecksfläche ----------
    static void DreiecksFlaeche()
    {
        Console.WriteLine("Dreiecksberechnung – Fläche");
        double grundlinie = ReadDouble("Grundlinie in cm (>0)", 0);
        double hoehe      = ReadDouble("Höhe in cm (>0)", 0);

        double flaeche = (grundlinie * hoehe) / 2.0;
        Console.WriteLine($"Die Fläche beträgt: {flaeche.ToString("F2", De)} cm²\n");
    }

    // ---------- 4) Währungsrechner ----------
    static void Waehrungsrechner()
    {
        Console.WriteLine("Währungsrechner (EUR → USD, Demo-Kurs)");
        double euro = ReadDouble("Betrag in Euro (>=0)", -1);

        const double EurToUsd = 1.30; // DEMO: fester Kurs wie in deinem Code
        double usd = euro * EurToUsd;

        Console.WriteLine($"Dollarbetrag: {usd.ToString("F2", De)} $\n");
    }

    // ---------- 5) Schreinereihelfer ----------
    static void Schreinerei()
    {
        Console.WriteLine("Schreinereihelfer – Bretter zuschneiden");
        int brettLaenge    = ReadInt("Brettlänge in cm (>0)", 1);
        int stueckLaenge   = ReadInt("Holzstück-Länge in cm (>0)", 1);

        if (stueckLaenge > brettLaenge)
        {
            Console.WriteLine("Kein Zuschnitt möglich (Stück länger als Brett).\n");
            return;
        }

        int anzahl = brettLaenge / stueckLaenge;
        int verschnitt = brettLaenge - (anzahl * stueckLaenge);

        Console.WriteLine($"Holzstücke: {anzahl}");
        Console.WriteLine($"Verschnitt in cm: {verschnitt}\n");
    }
}
