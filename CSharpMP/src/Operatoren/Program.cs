using System;
using System.Globalization;

class Program
{
    // German parsing/formatting (comma decimals)
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("Operatoren-Demos\n");

        Rechner();              // + - * /
        Verbrauch();            // l/100km
        DreiecksFlaeche();      // A = (g*h)/2
        Waehrungsrechner();     // EUR -> USD (Demo-Kurs)
        SchreinereiHelfer();    // Stückzahl + Verschnitt
    }

    // ---------- Helpers ----------
    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) && n >= min && n <= max)
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

    // ---------- Tasks ----------
    static void Rechner()
    {
        Console.WriteLine("Rechner (Grundrechenarten)");
        int a = ReadInt("Zahl 1");
        int b = ReadInt("Zahl 2");

        Console.WriteLine($"Summe:      {a + b}");
        Console.WriteLine($"Differenz:  {a - b}");
        Console.WriteLine($"Produkt:    {a * b}");
        if (b != 0)
        {
            Console.WriteLine($"Quotient:   {(a / (double)b).ToString("F2", De)}"); // / not %
            Console.WriteLine($"Rest (mod): {a % b}");
        }
        else
        {
            Console.WriteLine("Quotient:   Division durch 0 nicht möglich");
        }
        Console.WriteLine();
    }

    static void Verbrauch()
    {
        Console.WriteLine("Durchschnittsverbrauch (l/100 km)");
        double km = ReadDouble("Gefahrene Kilometer (>0)", 0);
        double liter = ReadDouble("Verbrauchte Benzinmenge in Litern (>=0)", -1);

        double v = (liter / km) * 100.0;
        Console.WriteLine($"Verbrauch:  {v.ToString("F2", De)} l/100 km\n");
    }

    static void DreiecksFlaeche()
    {
        Console.WriteLine("Dreiecksfläche");
        double grundlinie = ReadDouble("Grundlinie in cm (>0)", 0);
        double hoehe      = ReadDouble("Höhe in cm (>0)", 0);

        double flaeche = (grundlinie * hoehe) / 2.0;
        Console.WriteLine($"Fläche: {flaeche.ToString("F2", De)} cm²\n");
    }

    static void Waehrungsrechner()
    {
        Console.WriteLine("Währungsrechner (EUR → USD, Demo-Kurs)");
        double eur = ReadDouble("Betrag in Euro (>=0)", -1);
        const double eurToUsd = 1.10; // Demo-Wert, kein Livekurs
        double usd = eur * eurToUsd;
        Console.WriteLine($"Dollarbetrag: {usd.ToString("F2", De)} $\n");
    }

    static void SchreinereiHelfer()
    {
        Console.WriteLine("Schreinereihelfer – Bretter zuschneiden");
        int brett = ReadInt("Brettlänge in cm (>0)", 1);
        int stueck = ReadInt("Holzstück-Länge in cm (>0)", 1);

        if (stueck > brett)
        {
            Console.WriteLine("Kein Zuschnitt möglich (Stück länger als Brett).\n");
            return;
        }

        int anzahl = brett / stueck;
        int verschnitt = brett - (anzahl * stueck);

        Console.WriteLine($"Holzstücke: {anzahl}");
        Console.WriteLine($"Verschnitt: {verschnitt} cm\n");
    }
}
