using System;
using System.Globalization;

class Program
{
    // Deutsche Zahlformatierung (Komma als Dezimaltrennzeichen)
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("Mehrfachauswahl – Demos\n");

        while (true)
        {
            Console.WriteLine("1) Briefporto");
            Console.WriteLine("2) Taschenrechner (+, -, *, /)");
            Console.WriteLine("3) Geometrie (Zylinder/Würfel/Quader/Kugel)");
            Console.WriteLine("0) Ende");
            int choice = ReadInt("Auswahl", 0, 3);

            switch (choice)
            {
                case 0: return;
                case 1: Briefporto(); break;
                case 2: Taschenrechner(); break;
                case 3: GeometrieMenue(); break;
            }

            Console.WriteLine();
        }
    }

    // ========= Helpers =========
    static int ReadInt(string label, int min, int max)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
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

    // ========= 1) Briefporto =========
    static void Briefporto()
    {
        Console.WriteLine("\nBriefe – Porto nach Gewicht (Demo-Tabelle)");
        int g = ReadInt("Gewicht in Gramm (1-1000)", 1, 1000);

        // Beispielwerte (nicht die echten Deutsche-Post-Tarife)
        double preis = g switch
        {
            <= 20   => 1.00,
            <= 50   => 1.70,
            <= 100  => 2.40,
            <= 250  => 3.20,
            <= 500  => 4.00,
            <= 1000 => 4.80,
            _       => 0
        };

        if (preis == 0) Console.WriteLine("Kein Tarif gefunden.");
        else Console.WriteLine($"Porto: {preis.ToString("F2", De)} €");
    }

    // ========= 2) Taschenrechner =========
    static void Taschenrechner()
    {
        Console.WriteLine("\nTaschenrechner");
        double a = ReadDouble("Zahl 1");
        double b = ReadDouble("Zahl 2");
        Console.Write("Operator (+, -, *, /): ");
        string op = Console.ReadLine()?.Trim() ?? "";

        double result;
        switch (op)
        {
            case "+": result = a + b; break;
            case "-": result = a - b; break;
            case "*": result = a * b; break;
            case "/":
                if (b == 0) { Console.WriteLine("Division durch 0 nicht möglich."); return; }
                result = a / b; break;
            default:
                Console.WriteLine("Ungültiger Operator."); return;
        }
        Console.WriteLine($"Ergebnis: {result.ToString("G", De)}");
    }

    // ========= 3) Geometrie =========
    static void GeometrieMenue()
    {
        Console.WriteLine("\nGeometrie – Form wählen");
        Console.WriteLine("1) Zylinder");
        Console.WriteLine("2) Würfel");
        Console.WriteLine("3) Quader");
        Console.WriteLine("4) Kugel");
        int m = ReadInt("Auswahl", 1, 4);

        switch (m)
        {
            case 1: Zylinder(); break;
            case 2: Wuerfel(); break;
            case 3: Quader(); break;
            case 4: Kugel(); break;
        }
    }

    static void Zylinder()
    {
        Console.WriteLine("\nZylinder");
        double r = ReadDouble("Radius r in cm (>0)", 0);
        double h = ReadDouble("Höhe h in cm (>0)", 0);

        double o = 2 * Math.PI * r * (r + h);      // Oberfläche
        double v = Math.PI * r * r * h;            // Volumen

        Console.WriteLine($"Oberfläche: {o.ToString("F2", De)} cm²");
        Console.WriteLine($"Volumen:    {v.ToString("F2", De)} cm³");
    }

    static void Wuerfel()
    {
        Console.WriteLine("\nWürfel");
        double a = ReadDouble("Kantenlänge a in cm (>0)", 0);

        double o = 6 * a * a;      // Oberfläche
        double v = a * a * a;      // Volumen

        Console.WriteLine($"Oberfläche: {o.ToString("F2", De)} cm²");
        Console.WriteLine($"Volumen:    {v.ToString("F2", De)} cm³");
    }

    static void Quader()
    {
        Console.WriteLine("\nQuader");
        double a = ReadDouble("Höhe a in cm (>0)", 0);
        double b = ReadDouble("Länge b in cm (>0)", 0);
        double c = ReadDouble("Breite c in cm (>0)", 0);

        double o = 2 * (a * b + a * c + b * c);    // Oberfläche
        double v = a * b * c;                      // Volumen

        Console.WriteLine($"Oberfläche: {o.ToString("F2", De)} cm²");
        Console.WriteLine($"Volumen:    {v.ToString("F2", De)} cm³");
    }

    static void Kugel()
    {
        Console.WriteLine("\nKugel");
        double r = ReadDouble("Radius r in cm (>0)", 0);

        double o = 4 * Math.PI * r * r;                    // Oberfläche
        double v = (4.0 / 3.0) * Math.PI * r * r * r;      // Volumen  **Achtung: 4.0/3.0**

        Console.WriteLine($"Oberfläche: {o.ToString("F2", De)} cm²");
        Console.WriteLine($"Volumen:    {v.ToString("F2", De)} cm³");
    }
}
