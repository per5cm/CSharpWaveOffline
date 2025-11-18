using System;
using Lotto.UI.bannerAscii;
using static Lotto.Helpers.Helpers;




namespace Lotto
{
    internal static class Program
    {
        static void Main()
        {
            Banner.ShowBanner();
            ShowMenu();
        }

        internal static void ShowMenu()
        {
            // menu with switch case. using helper as input
            while (true)
            {
                Console.WriteLine("1 = Tippschein ausfüllen");
                Console.WriteLine("2 = Lottozahlen ziehen");
                Console.WriteLine("3 = Tippschein speichern");
                Console.WriteLine("0 = Programm beenden\n");
                int choice = ReadInt("Auswahl", 0, 3);

                switch (choice)
                {
                    case 0: return;
                    case 1: FillTicket(); break;
                    case 2: DrawNumber(); break;
                    case 3: SaveTicket(); break;
                }
            }
        }

        private static void FillTicket()
        {

        }

        private static void DrawNumber()
        {

        }
        
        private static void SaveTicket()
        {
            
        }
    
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
}
}
