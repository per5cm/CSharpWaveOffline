using System;
using System.Globalization;

namespace Lotto.Helpers
{
    public static class Helpers
    {
        static readonly CultureInfo De = new("de-DE");
        // Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Console.WriteLine("=== Programmstart ===\n");

        // Beispielaufrufe:
        // int alter = ReadInt("Alter", 0, 120);
        // double preis = ReadDouble("Preis", 0, 10000);
        // string name = ReadText("Name");

        // Console.WriteLine($"\nName: {name}, Alter: {alter}, Preis: {preis.ToString("N2", De)}");
        // }

        public static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write($"{label} ({min}-{max}): ");
                if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) && n >= min && n <= max)
                    return n;
                Console.WriteLine("Ungültige Eingabe.");
            }
        }

        public static double ReadDouble(string label, double min = double.NegativeInfinity, double max = double.PositiveInfinity)
        {
            while (true)
            {
                Console.Write($"{label} ({min}-{max}): ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x) && x >= min && x <= max)
                    return x;
                Console.WriteLine("Ungültige Eingabe.");
            }
        }

        public static string ReadText(string label)
        {
            Console.Write($"{label}: ");
            string? input = Console.ReadLine();
            return string.IsNullOrWhiteSpace(input) ? "" : input.Trim();
        }
    }
}