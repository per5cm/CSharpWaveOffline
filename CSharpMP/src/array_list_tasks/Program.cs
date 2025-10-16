using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    // Deutsch: 1,5 statt 1.5
    static readonly CultureInfo De = new("de-DE");

    static void Main()
    {
        Console.WriteLine("Arrays & Listen - Demos\n");

        while (true)
        {
            Console.WriteLine("1) Array vorwärts/rückwärts ausgeben");
            Console.WriteLine("2) Min/Max in Array finden");
            Console.WriteLine("3) Häufigkeit einer Zahl im Array zählen");
            Console.WriteLine("4) Notenliste (List<double>) - Durchschnitt");
            Console.WriteLine("5) 2D-Notenverteilung (Fach x Note)");
            Console.WriteLine("0) Ende");
            int choice = ReadInt("Auswahl", 0, 5);
            Console.WriteLine();

            if (choice == 0) break;
            else if (choice == 1) PrintForwardReverse();
            else if (choice == 2) MinMaxDemo();
            else if (choice == 3) FrequencyDemo();
            else if (choice == 4) GradesListDemo();
            else if (choice == 5) Grades2DDistribution();

            Console.WriteLine();
        }
    }

    // ========= Helpers =========
    static int ReadInt(string label, int min, int max)
    {
        while (true)
        {
            Console.Write($"{label} ({min}-{max}): ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) && n >= min && n <= max)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static int ReadIntOpen(string label, int minInclusive = int.MinValue, int maxInclusive = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) && n >= minInclusive && n <= maxInclusive)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDoubleOpen(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x) && x > minExclusive)
                return x;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    // ========= 1) Forward/Reverse =========
    static void PrintForwardReverse()
    {
        Console.WriteLine("Array vorwärts/rückwärts");
        int len = ReadInt("Länge", 1, 100);
        var a = new int[len];

        for (int i = 0; i < a.Length; i++)
            a[i] = i + 1; // demo: 1..N

        Console.Write("Vorwärts:  ");
        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + (i + 1 < a.Length ? " " : ""));
        Console.WriteLine();

        Console.Write("Rückwärts: ");
        for (int i = a.Length - 1; i >= 0; i--)
            Console.Write(a[i] + (i > 0 ? " " : ""));
        Console.WriteLine();
    }

    // ========= 2) Min/Max =========
    static void MinMaxDemo()
    {
        Console.WriteLine("Min/Max in Array");
        int[] values = { 23, 25, 27, 50, 64, -3, 18 };

        int min = values[0];
        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min) min = values[i];
            if (values[i] > max) max = values[i];
        }

        Console.WriteLine("Array: " + string.Join(", ", values));
        Console.WriteLine($"Min: {min}, Max: {max}");
    }

    // ========= 3) Frequency =========
    static void FrequencyDemo()
    {
        Console.WriteLine("Häufigkeit einer Zahl zählen");
        int[] data = { 2, 5, 7, 2, 3, 2, 9, 7 };
        Console.WriteLine("Array: " + string.Join(", ", data));

        int target = ReadIntOpen("Gesuchte Zahl");
        int hits = 0;

        for (int i = 0; i < data.Length; i++)
            if (data[i] == target) hits++;

        Console.WriteLine($"Die Zahl {target} kommt {hits}x vor.");
    }

    // ========= 4) Grades with List<double> =========
    static void GradesListDemo()
    {
        Console.WriteLine("Schulnoten (1-6, 0 = Ende) - List<double>");
        var grades = new List<double>();
        double sum = 0;

        while (true)
        {
            double g = ReadDoubleOpen("Note (1-6, 0 = Ende)", double.NegativeInfinity);
            if (g == 0) break;

            if (g < 1 || g > 6)
            {
                Console.WriteLine("Ungültige Note.");
                continue;
            }

            grades.Add(g);
            sum += g;
        }

        if (grades.Count == 0)
        {
            Console.WriteLine("Keine Noten eingegeben.");
            return;
        }

        Console.WriteLine("Gespeicherte Liste: " + string.Join(" ", grades));
        double avg = sum / grades.Count;
        Console.WriteLine($"Anzahl: {grades.Count}, Summe: {sum.ToString("F2", De)}, Durchschnitt: {avg.ToString("F2", De)}");
    }

    // ========= 5) 2D grade distribution (subjects x grades) =========
    static void Grades2DDistribution()
    {
        Console.WriteLine("2D-Notenverteilung (Fach x Note)");
        // rows = subjects, cols = grades 1..6
        int[,] table = new int[5, 6];
        string[] subjects = { "Java", "DB", "BWL", "Web", "Mathe" };

        while (true)
        {
            Console.WriteLine("Fächer: 1=Java, 2=DB, 3=BWL, 4=Web, 5=Mathe, 0=Ende");
            int subject = ReadInt("Fachnummer", 0, 5);
            if (subject == 0) break;

            int note = ReadInt("Note (1-6)", 1, 6);
            table[subject - 1, note - 1]++;
            Console.WriteLine("Eingabe gespeichert.\n");
        }

        for (int row = 0; row < subjects.Length; row++)
        {
            Console.WriteLine($"\nFach: {subjects[row]}");
            int sum = 0;
            int count = 0;

            for (int col = 0; col < 6; col++)
            {
                int freq = table[row, col];
                Console.WriteLine($"Note {col + 1}: {freq}");
                sum += freq * (col + 1);
                count += freq;
            }

            if (count > 0)
                Console.WriteLine($"Durchschnitt: {(sum / (double)count).ToString("F2", De)}");
            else
                Console.WriteLine("Keine Noten eingetragen.");
        }
    }
}
