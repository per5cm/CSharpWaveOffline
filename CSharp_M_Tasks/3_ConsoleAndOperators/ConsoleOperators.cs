using System;

namespace ConsoleOperators;

class ConsoleAndOperators
{
    public static void Main(string[] args)
    {
        var menuOption = new List<string>
        {
            "0: Exit",
            "1: Rechner",
            "2: Benzin Rechner"
        };

        while (true)
        {
            foreach (var item in menuOption)
                 Console.WriteLine(item);
            
            int choice = ReadInt("Auswahl: ", 0, 9);

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Thchussie!!!"); return;

                case 1: Calculator();break;
                case 2: Bensin(); break;
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
    #endregion
}