using System;


class Program
{
    static readonly Random Rng = new();
    static void Main()
    {
        Console.WriteLine("Mehrfachauswahl\n");
        
        while (true)
        {
            Console.WriteLine("1 = Sag Hallo!");
            Console.WriteLine("2 = Math Methode");
            Console.WriteLine("3 = Zufallzahlen");
            Console.WriteLine("4 = Arbeit mit Strings");
            Console.WriteLine("5 = Text zu Zahl Spiel");
            Console.WriteLine("0 = Programm beenden\n");
            int choice = ReadInt("Auswahl", 0, 5);

            switch (choice)
            {
                case 0: return;
                //case 1: SagHallo(); break;
                //case 2: MathMethode(); break;
                case 3: ZufallZahlen(); break;
                //case 4: ArbeitString(); break;
                //case 5: TextZahl(); break;
            }
            Console.WriteLine();
    }
    
    static void ZufallZahlen ()
        {
            int diceOne = Rng.Next(1, 7);
            int diceTwo = Rng.Next(1, 7);
            int diceThree = Rng.Next(1, 7);

            Console.WriteLine($"Wurf Eins: {diceOne}");
            Console.WriteLine($"Wurf Zwei: {diceTwo}");
            Console.WriteLine($"Wurf Drei: {diceThree}");
        }
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
