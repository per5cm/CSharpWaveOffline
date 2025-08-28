using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Aktiviere genau das, was du testen willst:
        // PrimzahlMenu();
        // While_1();
        // While_2();
        // For_1();
        // DoWhile_1();
        // DoWhile_2();
        //DoWhile_3();
        //foreach_1();
        //foreach_2();
        //foreach_3();
    }

    #region Primary number

    static void PrimzahlMenu()
    {
        while (true)
        {
            Console.Write("Gib eine Zahl zum Testen ein (b = Beenden): ");
            string? input = Console.ReadLine();

            if (input == "b")
                break;

            if (BigInteger.TryParse(input, out BigInteger n))
            {
                Console.WriteLine(IsPrime(n)
                    ? $"{n} ist eine Primzahl."
                    : $"{n} ist keine Primzahl.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }
        }
    }

    // einfache und zügige Primzahlprüfung
    static bool IsPrime(BigInteger n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        // 6k ± 1 Schrittweite
        for (BigInteger i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        return true;
    }

    #endregion

    #region while loops

    // Wiederhole Passwort-Eingabe bis korrekt
    static void While_1()
    {
        const string correctPassword = "secret";

        while (true)
        {
            Console.Write("Bitte Passwort eingeben: ");
            string? input = Console.ReadLine();

            if (input == correctPassword)
            {
                Console.WriteLine("Passwort ist korrekt!");
                break;
            }

            Console.WriteLine("Falsch, nochmal.");
        }
    }

    // Summiert Zahlen bis 0 eingegeben wird
    static void While_2()
    {
        int summe = 0;

        while (true)
        {
            Console.Write("Zahl eingeben (0 = Ende): ");
            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                if (zahl == 0)
                    break;

                summe += zahl;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }
        }

        Console.WriteLine($"Ergebnis: {summe}");
    }

    #endregion

    #region for loop

    static void For_1()
    {
        Console.Write("Wie oft soll ich grüßen? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Ungültige Eingabe.");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Hallo #{i}");
        }
    }

    #endregion

    #region Do While

    static void DoWhile_1()
    {
        string? input;
        do
        {
            Console.WriteLine("== Menu ==");
            Console.WriteLine("1) for-loop Beispiel");
            Console.WriteLine("2) Passwort-Check");
            Console.WriteLine("3) Primzahl-Menü");
            Console.Write("Option wählen (1-3, 0 = Ende): ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": For_1(); break;
                case "2": While_1(); break;
                case "3": PrimzahlMenu(); break;
                case "0": break;
                default: Console.WriteLine("Unbekannte Option."); break;
            }
        } while (input != "0");
    }

    static void DoWhile_2()
    {
        Random rng = new();
        int secret = rng.Next(1, 11); // 1..10 inkl.
        int guess;

        Console.WriteLine("=== Guess the number between 1 and 10 ===");

        do
        {
            Console.Write("Enter a positive number (0 to quit): ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Not a number.");
                continue;
            }

            if (guess == 0)
            {
                Console.WriteLine("Quit. The number was " + secret);
                return;
            }

            if (guess < secret) Console.WriteLine("Too low.");
            else if (guess > secret) Console.WriteLine("Too high.");
            else Console.WriteLine($"Correct! The number was {secret}.");

        } while (guess != secret);
    }

    static void DoWhile_3()
    {
        string? user_name;
        do
        {
            Console.Write("What is your name?: ");
            user_name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user_name))
                Console.WriteLine("Hello Unknown User!");
            else
                Console.WriteLine($"Hello {user_name}!");

        } while (false);
    }

    #endregion


    #region For Each

    static void foreach_1()
    {
        string[] names = ["Anna", "Ben", "Clara", "David"];

        foreach (string surnames in names)
        {
            Console.WriteLine($"Lenght of surname: {surnames} is {surnames.Lenght} Letters!");
        }
    }

    static void foreach_2()
    {
        List<string> words = ["Apple", "Bannana", "Kiwi"];

        foreach (string fruits in words)
        {
            Console.WriteLine($"Letters in word: {fruits} are {fruits.Lenght} Letters");
        }
    }


    static void foreach_3()
    {
        int[] numbers = [2, 4, 6];

        foreach (int x in numbers)
        {
            Console.WriteLine($"Results are: {x * x}");
        }
    }

    #endregion
}
