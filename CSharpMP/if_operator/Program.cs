using System;
using System.Globalization;

class Program
{
    // Culture for decimal numbers (1,5 etc.)
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("IF-Operator Übungen\n");

        BestellwertMitVersand();
        GleichungX();
        BankBegruessung();
    }

    // ---------- Helper ----------
    static double ReadDouble(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Float, De, out double value) && value > minExclusive)
                return value;

            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }

    static int ReadInt(string label)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int x))
                return x;
            Console.WriteLine("Ungültige Eingabe. Bitte ganze Zahl verwenden.");
        }
    }

    #region Bestellwert 
    static void BestellwertMitVersand()
    {
        Console.WriteLine("=== Berechnung Bestellwert ===");
        double bestellwert = ReadDouble("Bestellwert in Euro (>=0)", -1);

        double gesamt = bestellwert;
        if (bestellwert < 200)
        {
            gesamt += 5.50;  // Versandkosten
        }

        Console.WriteLine($"Rechnungsbetrag: {gesamt.ToString("F2", De)} €\n");
    }
    #endregion

    #region Gleichung X lösen 
    static void GleichungX()
    {
        Console.WriteLine("=== Gleichung lösen (ax + b = 0) ===");
        int a = ReadInt("Wert für a (≠ 0)");
        int b = ReadInt("Wert für b");

        if (a == 0)
        {
            Console.WriteLine("Fehler: a darf nicht 0 sein.\n");
        }
        else
        {
            double x = -b / (double)a;
            Console.WriteLine($"Lösung: x = {x.ToString("F2", De)}\n");
        }
    }
    #endregion

    #region Bank Begrüßungs-Rabatt 
    static void BankBegruessung()
    {
        Console.WriteLine("=== Bank Begrüßung ===");
        Console.Write("Begrüßung eingeben: ");
        string? gruss = Console.ReadLine();

        if (gruss.Equals("Hello", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Preis: 0€\n");
        }
        else if (gruss.Equals("H", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Preis: 20€\n");
        }
        else
        {
            Console.WriteLine("Preis: 100€\n");
        }
    }
    #endregion
}
