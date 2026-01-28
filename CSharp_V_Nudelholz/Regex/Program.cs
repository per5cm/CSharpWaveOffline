using System;
using System.Text;
using System.Text.RegularExpressions; // <--- main player for using Regex


class Program
{
    static void Main(string[] args)
    {
        // Core methods for regex:
        // Regex.IsMatch(input, pattern) -> bool match
        // Regex.Match(input, pattern) -> match object or .Success false
        // Regex Matches(input, pattern) -> MatchCollection -> all hits
        // Regex.Replace(input, pattern, replacment) -> string with swaps

        // Options:
        // RegexOptions.IgnoreCase // "Hello" matches "hello"
        // RegexOptions.Compiled // Faster for reused patterns 
        // RegexOptions.Multiline // ^/$ match line starts/ends too
        // RegexOptions.IgnorePatternWhitespace // allow spaces + comments in pattern

        Console.WriteLine("Wery iconic Mongolian grass!");

        var menuOption = new List<string>
        {
            "0: Exit",
            "1: Is Valid"
        };

        while (true)
        {
            Console.WriteLine("!=== Regex options ===!");
            foreach (var option in menuOption)
                Console.WriteLine(option);

            int choice = ReadInt("Auswahl: ", 0, 9);

            switch (choice)
            {
                case 0: 
                    Console.WriteLine("Tchussie!");
                    return;

                case 1:
                    string input = ReadText("SV Nummer eingeben: ");
                    bool valid = IsValid(input);
                    if (valid)
                    {
                        Console.WriteLine("das passt!");
                    }
                    else
                    {
                        Console.WriteLine("Nope... ungültig.");
                    }
                    break;
            }
        }
    }

    public static bool IsValid(string value)
    {
        if (string.IsNullOrEmpty(value)) return false;

        value = Regex.Replace(value.Trim(), @"\s+", " "); // collapse multiple spaces
        value = value.ToUpperInvariant(); // M/m -> M

        return Regex.IsMatch(value, @"^\d{2}\s\d{6}\s[A-Z]\s\d{3}$");
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
    static string ReadText(string label)
    {
        Console.Write($"{label}: ");
        return Console.ReadLine() ?? string.Empty;
        
    }
    #endregion
}