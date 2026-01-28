using System;
using System.Globalization;

class Program
{
    // Deutsch: 1,5 statt 1.5
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("If/Else - Übungen - Menü\n");

        while (true)
        {
            Console.WriteLine("1) Durchschnittsverbrauch (l /100 km).");
            Console.WriteLine("2) Kindergeld (Demo - Tabelle).");
            Console.WriteLine("3) Bußgeld, Geschwindigkeits - Überschreitung.)");
            Console.WriteLine("4) Temperaturzustand Wasser und in Fahrenheit.");
            Console.WriteLine("5) BMI & Broca, Normal - Idealgewicht.");
            Console.WriteLine("0) Ende");

            int choice = ReadInt("Auswahl: ", 0, 5);
            Console.WriteLine();

            if (choice == 0)
            {
                break;
            }
            else if (choice == 1)
            {
                Verbrauch();
            }
            else if (choice == 2)
            {
                KindergeldDemo();
            }
            else if (choice == 3)
            {
                BussgeldDemo();
            }
            else if (choice == 4)
            {
                WasserPhase();
            }
            else if (choice == 5)
            {
                BmiUndBroca();
            }

            Console.WriteLine();
        }
    }

    // ========= Helpers (nur für Eingaben) =========
    static int ReadInt(string label, int min, int max)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
            string? s = Console.ReadLine();
            int n;
            if (int.TryParse(s, NumberStyles.Integer, De, out n))
            {
                if (n >= min && n <= max) return n;
            }
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDouble(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            string? s = Console.ReadLine();
            double x;
            if (double.TryParse(s, NumberStyles.Float, De, out x))
            {
                if (x > minExclusive) return x;
            }
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    #region Durchschnittsverbrauch 
    static void Verbrauch()
    {
        Console.WriteLine("Durchschnittsverbrauch (l/100 km)");
        double km = ReadDouble("Gefahrene Kilometer (>0)", 0);
        double liter = ReadDouble("Verbrauchte Benzinmenge in Litern (>=0)", -1);

        double v = (liter / km) * 100.0;
        Console.WriteLine($"Verbrauch: {v.ToString("F2", De)} l/100 km");
    }
    #endregion

    #region Kindergeld - DEMO (vereinfachte Werte) 
    static void KindergeldDemo()
    {
        Console.WriteLine("Kindergeld (vereinfachte Demo-Werte)");
        double einkommen = ReadDouble("Jahreseinkommen in € (>=0)", -1);
        int kinder = ReadInt("Anzahl Kinder (0-10)", 0, 10);

        double betrag = 0;

        if (einkommen < 45000)
        {
            if (kinder == 0) betrag = 0;
            else if (kinder == 1) betrag = 70;
            else if (kinder == 2) betrag = 130;
            else if (kinder == 3) betrag = 220;
            else betrag = 240; // 4 oder mehr
        }
        else // einkommen >= 45000
        {
            if (kinder == 0) betrag = 0;
            else if (kinder == 1) betrag = 70;
            else if (kinder == 2) betrag = 70;
            else if (kinder == 3) betrag = 140;
            else betrag = 140; // 4 oder mehr
        }

        Console.WriteLine($"Kindergeld (Demo): {betrag.ToString("F2", De)} €");
    }
    #endregion

    #region Bußgeld - DEMO 
    static void BussgeldDemo()
    {
        Console.WriteLine("Bußgeld (vereinfachte Demo)");
        double v = ReadDouble("Überschreitung in km/h (>=0)", -1);

        int euro = 0;
        if (v < 10) euro = 0;
        else if (v < 20) euro = 30;
        else if (v < 30) euro = 60;
        else euro = 200;

        Console.WriteLine($"Bußgeld: {euro} €");
    }
    #endregion

    #region Wasserzustand + Fahrenheit 
    static void WasserPhase()
    {
        Console.WriteLine("Temperaturrechner (Wasserzustand)");
        double c = ReadDouble("Temperatur in °C");

        if (c < 0)
            Console.WriteLine("Zustand: Eis");
        else if (c <= 100)
            Console.WriteLine("Zustand: Wasser");
        else
            Console.WriteLine("Zustand: Dampf");

        double f = c * 1.8 + 32;
        Console.WriteLine($"{c.ToString("F1", De)} °C = {f.ToString("F1", De)} °F");
    }
    #endregion

    #region BMI & Broca 
    static void BmiUndBroca()
    {
        Console.WriteLine("Gewichtsrechner - BMI & Broca");
        double cm = ReadDouble("Größe in cm (>0)", 0);
        double kg = ReadDouble("Gewicht in kg (>0)", 0);

        // BMI
        double m = cm / 100.0;
        double bmi = kg / (m * m);
        string kategorie;

        if (bmi < 18.5) kategorie = "Untergewicht";
        else if (bmi < 25.0) kategorie = "Normalgewicht";
        else if (bmi < 30.0) kategorie = "Übergewicht";
        else kategorie = "Adipositas";

        Console.WriteLine($"BMI: {bmi.ToString("F1", De)} – {kategorie}");

        // Broca (historische Faustformeln – NICHT medizinisch)
        double brocaNormal = cm - 100;
        double brocaIdealM = (cm - 100) * 0.9;   // Männer
        double brocaIdealF = (cm - 100) * 0.85;  // Frauen

        Console.WriteLine($"Broca Normalgewicht: {brocaNormal.ToString("F1", De)} kg");
        Console.WriteLine($"Broca Idealgewicht (M): {brocaIdealM.ToString("F1", De)} kg");
        Console.WriteLine($"Broca Idealgewicht (F): {brocaIdealF.ToString("F1", De)} kg");

        // Abweichung ggü. Broca-Ideal (M) – nur als Beispiel
        double diffM = (kg - brocaIdealM) / brocaIdealM * 100.0;
        Console.WriteLine($"Abweichung zu Broca-Ideal (M): {diffM.ToString("F1", De)} %");
    }
    #endregion
}
