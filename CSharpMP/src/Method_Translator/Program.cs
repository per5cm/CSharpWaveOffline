using System;

namespace Method_Translator
{
    internal static class Program
    {
        static string[,] SavedWords = new string[100, 2];
        static int NumberOfWords = 0;
        static readonly Random Rng = new();

        static void Main()
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            string menu =
                    @"
                    --- Programmstart Menu ---

                    1: Erfassen Wörter
                    2: Abfrage Wörter
                    3: Alle Wörter ausgeben
                    4: Vokabeltrainer
                    0: Programmende
                    ";

            while (true)
            {
                Console.WriteLine(menu);
                int choice = ReadInt("Auswahl", 0, 5);
                
                switch (choice)
                {
                    case 0: Console.WriteLine("Auf Wiedersehn!"); return;
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

            while (true)
            {
                string wordDE = ReadText("Deutsches Wort");
                string wordEN = ReadText("Englisches Wort");
                Console.WriteLine();


                SavedWords[NumberOfWords, 0] = wordDE;
                SavedWords[NumberOfWords, 1] = wordEN;
                NumberOfWords++;

                Console.WriteLine("Wortpaar gespeichert.\n");


                string confirm = ReadText("Weiteres Wort erfassen? j/n ");
                if (confirm.Equals("j", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("ok! Weiteres Wort erfassen!\n");
                }
                else
                {
                    break;
                }

            }
        }

        static void QueryWords()
        {
            if (NumberOfWords == 0)
            {
                Console.WriteLine("Keine Wörter gespeichert.\n");
                return;
            }

            DisplayAllWords();

            Console.WriteLine("Listen Abfrage - Richtung");
            Console.WriteLine("1. Deutsch -> Englisch");
            Console.WriteLine("2. Englisch -> Deutsch");
            int direction = ReadInt("Auswahl: 1 für Deutsch, 2 für Englisch", 1, 2);

            bool again;

            do
            {
                bool found = false;

                switch (direction)
                {
                    case 1:
                    {
                        string searchDe = ReadText("Deutsches Suchwort");
                        for (int index = 0; index < NumberOfWords; index++)
                        {
                            if (string.Equals(SavedWords[index, 0], searchDe, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Gefunden: {SavedWords[index, 0]} -> {SavedWords[index, 1]}");
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine("Kein Eintrag gefunden.");
                        Console.WriteLine();
                        break;
                    }

                    case 2:
                    {
                        string searchEn = ReadText("Englisches Suchwort");
                        for (int index = 0; index < NumberOfWords; index++)
                        {
                            if (string.Equals(SavedWords[index, 1], searchEn, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Gefunden: {SavedWords[index, 1]} -> {SavedWords[index, 0]}");
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine("Kein Eintrag gefunden.");
                        Console.WriteLine();
                        break;
                    }
                }

                string againInput = ReadText("Noch ein Wort suchen? j/n ");
                again = againInput.Equals("j", StringComparison.OrdinalIgnoreCase);

            } while (again);

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
            if (NumberOfWords == 0)
            {
                Console.WriteLine("Keine Wörter gespeichert.\n");
                return;
            }

            Console.WriteLine("Abfrage - Richtung");
            Console.WriteLine("1. Deutsch -> Englisch");
            Console.WriteLine("2. Englisch -> Deutsch");
            int direction = ReadInt("Auswahl", 1, 2);
            int quizzNumberOfWords = ReadInt("Wie viele Vokabeln wollen Sie abgefragt werden?");

            if (quizzNumberOfWords > NumberOfWords)
            {
                Console.WriteLine("Fehler: Es gibt nicht so viele gespeicherte Vokabeln!");
                return;
            }

            int correct = 0;

            for (int i = 0; i < quizzNumberOfWords; i++)
            {
                int index = Rng.Next(0, NumberOfWords);

                switch (direction)
                {
                    case 1:
                    {
                        Console.Write($"{SavedWords[index, 0]} --> ");
                        string translateDe = ReadText("");
                        if (string.Equals(translateDe, SavedWords[index, 1], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("ok!");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine($"Falsch! Richtig war: {SavedWords[index, 1]}");
                        }
                        break;
                    }

                    case 2:
                    {
                        Console.Write($"{SavedWords[index, 1]} --> ");
                        string translateEn = ReadText("");
                        if (string.Equals(translateEn, SavedWords[index, 0], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("ok!");
                            correct++;
                        }
                        else
                        {
                            Console.WriteLine($"Falsch! Richtig war: {SavedWords[index, 0]}");
                        }
                        break;
                    }
                }
            }

            double percent = (double)correct / quizzNumberOfWords * 100;
            Console.WriteLine($"Treffer: {correct} von {quizzNumberOfWords}, das sind {percent:F0}% insgesamt.\n");
        }

        #region Helpers

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
    #endregion 
}
