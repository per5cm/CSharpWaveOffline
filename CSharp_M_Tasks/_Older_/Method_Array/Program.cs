using System;


namespace Method_Array
{
    internal static class Program
    {
        const int QuartalDevices = 4;
        const int MaxPhotoDevices = 5;

        static int[,] PvData = new int[QuartalDevices, MaxPhotoDevices]
        {
            { 10000, 20000, 30000, 40000, 50000 },
            { 11000, 21000, 31000, 41000, 51000 },
            { 12000, 22000, 32000, 42000, 52000 },
            { 13000, 23000, 33000, 43000, 53000 },
        };


        static void Main()
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            var menuOptions = new string[]
            {
                "1: Alle Geräte Ausgeben",
                "2: Alle Geräte Berechnen",
                "3: Quartal Berechnen",
                "4: Berechnen PV-Anlage",
                "0: Programmende",
            };

            while (true)
            {
                Console.WriteLine("=== Foto Geräte Programm ===");
                foreach (var option in menuOptions)
                    Console.WriteLine(option);

                int choice = ReadInt("Auswahl: ", 0, 5);

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Auf Wiedersehn!");
                        return;

                    case 1: ShowAll(); break;
                    case 2: CalculateAll(); break;
                    case 3: CalculateQuartal(); break;
                    case 4: CalculatePVSystem(); break;
                }
            }
        }

        static void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("PV-Anlage: PV1 | PV2 | PV3 | PV4 | PV5");
            Console.WriteLine("Quartal");

            for (int quartal = 0; quartal < QuartalDevices; quartal++)
            {
                Console.Write($"    {quartal + 1}   ");

                for (int pv = 0; pv < MaxPhotoDevices; pv++)
                {
                    Console.Write($"{PvData[quartal, pv],6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void CalculateAll()
        {
            int sum = 0;

            for (int quartal = 0; quartal < QuartalDevices; quartal++)
            {
                for (int pv = 0; pv < MaxPhotoDevices; pv++)
                {
                    sum += PvData[quartal, pv];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"aller PV-Anlagen in KW: {sum}");
            Console.WriteLine();
        }

        static void CalculateQuartal()
        {

            for (int quartal = 0; quartal < QuartalDevices; quartal++)
            {
                int sum = 0;

                for (int pv = 0; pv < QuartalDevices; pv++)
                {
                    sum += PvData[quartal, pv];
                }

                Console.WriteLine();
                Console.WriteLine($"Quartal Summe: {quartal + 1}: {sum}.");
                Console.WriteLine();
            }
        }

        static void CalculatePVSystem()
        {

            int pvIndex = ReadInt("Geben Sie die PV-Anlage ein: ", 1, MaxPhotoDevices) - 1;
            // int index = pvIndex - 1; // Alternative

            int sum = 0;

            for (int quartal = 0; quartal < QuartalDevices; quartal++)
            {
                sum += PvData[quartal, pvIndex];
            }

            Console.WriteLine();
            Console.WriteLine($"Von der Anlage: {pvIndex}, wurde insgesamt: {sum} erwirtschaften.");
            Console.WriteLine();
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