using System;

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
            
            int choice = ReadInt("Auswahl: ", 0, 9);

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Tschüssie!!!"); return;

                case 1: Calculator();break;
                case 2: Bensin(); break;
            }
        }
    }

    public static void Calculator()
    {
        Console.WriteLine("Bitte nur Ganzzahlen eingeben wie 10 oder 3 u.s.w.!");
        Console.WriteLine();

        var calculatorOption = new List<string>
        {
            "0: Exit",
            "1: +, Addieren",
            "2: -, Subtranhieren",
            "3: *, Multiplizieren",
            "4: /, Dividieren",
            "5: %, Modulo"
        };

        while (true)
        {
            foreach (var item in calculatorOption) 
                Console.WriteLine(item);

            int choice = ReadInt("Auswahl: ", 0, 5);

            int inputOne = ReadInt("Erste Ganzzahlen eingeben: ");
            int inputTwo = ReadInt("Zweite Ganzzahlen eingeben: ");

            switch (choice)
            {
                case 1:
                    {
                        int sumAdd = inputOne + inputTwo;
                        Console.WriteLine($"Ergebnis: {sumAdd}");
                    } break;

                case 2:
                    {
                        int sumSubstract = inputOne - inputTwo;
                        Console.WriteLine($"Ergebnis: {sumSubstract}");
                    } break;

                case 3:
                    {
                        int sumMultiply = inputOne * inputTwo;
                        Console.WriteLine($"Ergebnis: {sumMultiply}");
                    } break;

                case 4:
                    {
                        int sumSubstract = inputOne / inputTwo;
                        Console.WriteLine($"Ergebnis: {sumSubstract}");
                    } break;
            }
        }
        
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