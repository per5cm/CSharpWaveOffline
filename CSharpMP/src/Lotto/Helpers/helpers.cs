using System;

namespace Lotto.Helpers
{
    public static class Helpers
    {
        public static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                if (min == int.MinValue && max == int.MaxValue)
                    Console.Write($"{label}: ");
                else
                    Console.Write($"{label} ({min}-{max}): ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out int n) && n >= min && n <= max)
                    return n;

                Console.WriteLine("Ungültige Eingabe.");
            }
        }

        public static double ReadDouble(string label, double min = double.NegativeInfinity, double max = double.PositiveInfinity)
        {
            while (true)
            {
                if (min == double.NegativeInfinity && max == double.PositiveInfinity)
                    Console.Write($"{label}: ");
                else
                    Console.Write($"{label} ({min}-{max}): ");

                string? input = Console.ReadLine();

                if (double.TryParse(input, out double x) && x >= min && x <= max)
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
