using System;
using System.ComponentModel.Design;
using System.Net;


namespace Method_Translator
{
    internal static class Program
    {
        static string[,] SavedWords = new string[100, 2];
        static int NumberOfWords = 0;
        static readonly Random Rng = new();
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
            if (NumberOfWords >= SavedWords.GetLength(0))
            {
                Console.WriteLine("Speicher ist voll - max. 100 Wörter.");
                return;
            }

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
            DisplayAllWords();
            Console.WriteLine("Listen Abfrage - Richtung");
            Console.WriteLine("1. Deutsch -> Englisch");
            Console.WriteLine("2. Englisch -> Deutsch");
            int direction = ReadInt("Auswahl: 1 für Deutsch, 2 für English", 1, 2);

            bool found = false;

            for (int index = 0; index < NumberOfWords; index++)
            {
                switch (direction)
                {
                    case 1:
                        string searchDe = ReadText("Deutsches Suchwort");
                        {
                            if (string.Equals(SavedWords[index, 0], searchDe, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Gefunden: {SavedWords[index, 0]} -> {SavedWords[index, 1]}"); found = true; break;
                            }
                        }
                        break;

                    case 2:
                        string searchEn = ReadText("Englisches Suchwort");
                        {
                            if (string.Equals(SavedWords[index, 1], searchEn, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Gefunden: {SavedWords[index, 1]} -> {SavedWords[index, 0]}"); found = true; break;
                            }
                        }
                        break;
                }
            }
            if (!found) Console.WriteLine("Keine Eintrag gefunden.");
            Console.WriteLine();
        }

        static void DisplayAllWords()
        {
            Console.WriteLine("\nGespeicherte Wörter:");
            for (int display = 0; display < NumberOfWords; display++)
            {
                Console.WriteLine($"{display + 1}. DE: {SavedWords[display, 0]} | EN: {SavedWords[display, 1]}");
            }
            Console.WriteLine();
        }

        static void VocabularyTrainer()
        {
            Console.WriteLine("Abfrage - Richtung");
            Console.WriteLine("1. Deutsch -> Englisch");
            Console.WriteLine("2. Englisch -> Deutsch");
            int direction = ReadInt("Auswahl", 1, 2);
            int quizzNumberOfWords = ReadInt("Wie viele Vokabeln wollen Sie abgefragt werden?");

            int correct = 0;

            if (quizzNumberOfWords > NumberOfWords)
            {
                Console.WriteLine("Fehler: Es gibt nicht so viele geschpeicherte Vokabeln!");
                return;
            }

            for (int i = 0; i < quizzNumberOfWords; i++)
            {
                int index = Rng.Next(0, NumberOfWords);

                switch (direction)
                {
                    case 1:
                        Console.Write($"{SavedWords[index, 0]} -->");
                        string translateDe = ReadText("");
                        if (string.Equals(translateDe, SavedWords[index, 1], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("ok!");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine($"Falsch! richtig war: {SavedWords[index, 1]}");
                        }
                        break;

                    case 2:
                        Console.Write($"{SavedWords[index, 1]} -->");
                        string translateEn = ReadText("");
                        if (string.Equals(translateEn, SavedWords[index, 0], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("ok!");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine($"Falsch! richtig war: {SavedWords[index, 0]}");
                        }
                        break;
                }
            }
            double percent = (double)correct / quizzNumberOfWords * 100;
            Console.WriteLine($"Treffer: {correct} von {quizzNumberOfWords}, das sind {percent:F0}% insgesamt.");
            Console.WriteLine();
        }

        // ----------- Helpers (nur Eingabe) -----------

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