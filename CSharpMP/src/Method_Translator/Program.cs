using System;


namespace Method_Translator
{
    internal static class Program
    {
        static string[,] SavedWords = new string[100, 2];
        static int NumberOfWords = 0;
        static void Main()
        {
            Console.WriteLine("=== Programmstart ===\n");
            ShowMenu();
        }

        static void ShowMenu()
        {
            while(true)
            {
                Console.WriteLine("1 = Erfassen Wörter");
                Console.WriteLine("2 = Abfrage Wörter");
                Console.WriteLine("3 = Alle Wörter ausgeben");
                Console.WriteLine("4 = Vokabeltrainer");
                Console.WriteLine("0 = Programmende");
                int choice = ReadInt("Auswahl: ", 0, 5);

                switch (choice)
                {
                    case 0: return;
                    case 1: CaptureWords(); break;
                    case 2: QueryWords(); break;
                    case 3: DisplayAllWords(); break;
                    case 4: VocabularyTrainer(); break;
                }
            }
        }

        static void CaptureWords()
        {
            string wordDE = ReadText("Deutsche Worte: ");
            string wordEN = ReadText("Englishe Worte: ");

            SavedWords[NumberOfWords, 0] = wordDE;
            SavedWords[NumberOfWords, 1] = wordEN;
            NumberOfWords++;

            Console.WriteLine("Wortpaar gespeichert.");
            Console.WriteLine();
        }

        static void QueryWords()
        {

        }

        static void DisplayAllWords()
        {
            Console.WriteLine("\nGespeicherte Wörter");
            for (int i = 0; i < NumberOfWords; i++)
            {
                Console.WriteLine($"{i + 1}. DE: {SavedWords[i, 0]} | EN: {SavedWords[i, 1]}");
            }
            Console.WriteLine();
        }

        static void VocabularyTrainer()
        {
            
        }

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
    }
}