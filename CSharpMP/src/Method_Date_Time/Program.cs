using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main()
    {
        Console.WriteLine("Mehrfachauswahl");

        while (true)
        {
            Console.WriteLine("1 = Aktuelles Datum und Uhrzeit");
            Console.WriteLine("2 = Alter Berechenen (Geburtsjahr)");
            Console.WriteLine("0 = Programm beenden");
            Console.WriteLine();
            int choice = ReadInt("Auswahl", 0, 2);

            switch (choice)
            {
                case 0: return;
                case 1: CurrentDate(); break;
                case 2: AgeFormat(); break;
            }
            Console.WriteLine();
        }
    }

    static void CurrentDate()
    {
        DateTime now = DateTime.Now;
        string date = now.ToString("dd.MM.yyyy");
        string time = now.ToString("HH:mm:ss");

        Console.WriteLine($"Datum: {date}");
        Console.WriteLine($"Uhrzeit: {time}");
        Console.WriteLine($"Datum + Uhrzeit: {date} {time}");
        Console.WriteLine($"Heute ist der {now.Day}. des aktuelles Monats");
    }

    static void AgeFormat()
    {
        string currentYearStr = DateTime.Now.ToString("yyyy");
        int currentYear = int.Parse(currentYearStr);

        int geburtsjahr = ReadInt("Bitte gib dein Geburtsjahr ein", 1900, currentYear);
        int alter = currentYear - geburtsjahr;

        Console.WriteLine($"Du bist {alter} Jahre alt.");
    }

    #region Helpers
    // ----------- Helpers (nur Eingabe) -----------

    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= min && n <= max)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDouble(string label, double min = double.NegativeInfinity, double max = double.PositiveInfinity)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
            if (double.TryParse(Console.ReadLine(), out double x) && x >= min && x <= max)
                return x;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static string ReadText(string label)
    {
        Console.Write($"{label}: ");
        string? input = Console.ReadLine();
        return string.IsNullOrWhiteSpace(input) ? "" : input.Trim();
    }
    #endregion
}

