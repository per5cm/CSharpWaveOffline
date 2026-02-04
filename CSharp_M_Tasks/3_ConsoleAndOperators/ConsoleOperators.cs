using System;
using System.Linq.Expressions;

namespace ConsoleOperators;

class ConsoleAndOperators
{
    public static void Main(string[] args)
    {
        var menuOption = new List<string>
        {
            "0: Exit",
            "1: Taschenrechner",
            "2: Benzinrechner"
        };

        while (true)
        {
            foreach (var item in menuOption)
                 Console.WriteLine(item);
            
            //int choice = ReadInt("Auswahl: ", 0, 9);
            Console.WriteLine();
            Console.WriteLine("Auswahl: ");

            if (!int.TryParse(Console.ReadLine(), out int choice)) // you can also add range: && choice >= 0 <= 9)
            {
                Console.WriteLine("Kein gültige eingabe!");
                    Console.ReadKey(true);
                continue;
            }

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Tschüssie!!!"); return;

                case 1: Calculator();break;
                case 2: Bensin(); break;
                default: Console.WriteLine($"Nur 0 bis 2 erlaubt, nicht {choice}"); break;
            }
        }
    }

    public static void Calculator()
    {
        
    }

    public static void Bensin()
    {

    }

    #region Helpers
    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            if (min == int.MinValue && max == int.MaxValue)
                Console.Write($"{label}: ");
            else
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
            if (min == double.NegativeInfinity && max == double.PositiveInfinity)
                Console.Write($"{label}: ");
            else
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