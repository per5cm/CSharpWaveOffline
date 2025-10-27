using System;
using System.Globalization;

class Program
{
    // German culture (for comma decimal etc.)
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Programmstart ===\n");

        // Example usage (delete or replace with your logic)
        int age = ReadInt("Alter eingeben", 0, 120);
        double price = ReadDouble("Preis eingeben", 0);
        string name = ReadText("Name eingeben");

        Console.WriteLine($"\nName: {name}, Alter: {age}, Preis: {price.ToString("N2", De)}");
    }

    // === Helper methods ===

    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        int value;
        while (true)
        {
            Console.Write($"{label}: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, NumberStyles.Integer, De, out value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Bitte eine ganze Zahl zwischen {min} und {max} eingeben.\n");
        }
    }

    static double ReadDouble(string label, double min = double.NegativeInfinity, double max = double.PositiveInfinity)
    {
        double value;
        while (true)
        {
            Console.Write($"{label}: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, NumberStyles.Float, De, out value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Bitte eine Zahl zwischen {min} und {max} eingeben (Komma erlaubt).\n");
        }
    }

    static string ReadText(string label)
    {
        Console.Write($"{label}: ");
        string? input = Console.ReadLine();
        return string.IsNullOrWhiteSpace(input) ? "(leer)" : input.Trim();
    }
}
