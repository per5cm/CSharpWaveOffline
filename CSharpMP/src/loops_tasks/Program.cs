using System;
using System.Globalization;

class Program
{
    // Deutsch: 1,5 statt 1.5
    static readonly CultureInfo De = new("de-DE");
    static readonly Random Rng = new();

    static void Main()
    {
        Console.WriteLine("Loops – Übungssammlung\n");

        while (true)
        {
            Console.WriteLine("1) Teiler finden (while)");
            Console.WriteLine("2) Notendurchschnitt (do…while)");
            Console.WriteLine("3) Zinsen (for-Schleife)");
            Console.WriteLine("4) Zahlenratespiel (while)");
            Console.WriteLine("5) Blackjack Light (while + Dealer)");
            Console.WriteLine("0) Ende");
            int choice = ReadInt("Auswahl", 0, 5);
            Console.WriteLine();

            if (choice == 0) break;
            if (choice == 1) DivisorsWhile();
            else if (choice == 2) GradesDoWhile();
            else if (choice == 3) InterestFor();
            else if (choice == 4) GuessNumberWhile();
            else if (choice == 5) BlackjackLight();

            Console.WriteLine();
        }
    }

    // ----------- Helpers (nur Eingabe) -----------
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

    static int ReadIntOpen(string label, int minExclusive = int.MinValue)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (int.TryParse(Console.ReadLine(), NumberStyles.Integer, De, out int n) && n > minExclusive)
                return n;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    static double ReadDouble(string label, double minExclusive = double.NegativeInfinity)
    {
        while (true)
        {
            Console.Write($"{label}: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, De, out double x) && x > minExclusive)
                return x;
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    #region Teiler (while) 
    static void DivisorsWhile()
    {
        Console.WriteLine("Teiler mit while");
        int n = ReadIntOpen("Ganze Zahl (>0)", 0);

        int d = 1;
        while (d <= n)
        {
            if (n % d == 0) Console.WriteLine($"{n} ist teilbar durch {d}");
            d++;
        }
    }
    #endregion

    #region Noten (do…while) 
    static void GradesDoWhile()
    {
        Console.WriteLine("Notendurchschnitt (1–6, 0 = Ende)");
        double sum = 0;
        int count = 0;
        double grade;

        do
        {
            grade = ReadDouble("Note (1–6, 0 zum Beenden)");
            if (grade == 0) break;

            if (grade < 1 || grade > 6)
            {
                Console.WriteLine("Ungültige Note.");
            }
            else
            {
                sum += grade;
                count++;
            }
        } while (true);

        if (count == 0) Console.WriteLine("Keine Noten eingegeben.");
        else
        {
            double avg = sum / count;
            Console.WriteLine($"Anzahl: {count}, Summe: {sum.ToString("F2", De)}, Durchschnitt: {avg.ToString("F2", De)}");
        }
    }
    #endregion

    #region Zinsen (for) 
    static void InterestFor()
    {
        Console.WriteLine("Zinseszins (for-Schleife)");
        double kapital = ReadDouble("Anfangsbetrag in € (>0)", 0);
        double zinssatz = ReadDouble("Zinssatz in % (>=0)", -1);
        int jahre = ReadInt("Laufzeit in Jahren", 1, 100);

        for (int jahr = 1; jahr <= jahre; jahr++)
        {
            kapital = kapital * (1 + zinssatz / 100.0);
            Console.WriteLine($"Wert nach Jahr {jahr}: {kapital.ToString("F2", De)} €");
        }
    }
    #endregion

    #region Zahlenraten (while) 
    static void GuessNumberWhile()
    {
        Console.WriteLine("Zahlenratespiel (1–100)");
        int geheim = Rng.Next(1, 101);
        int versuche = 0;

        while (true)
        {
            Console.Write("Tipp: ");
            string? s = Console.ReadLine();
            int tipp;
            if (!int.TryParse(s, NumberStyles.Integer, De, out tipp))
            {
                Console.WriteLine("Bitte ganze Zahl eingeben.");
                continue;
            }

            versuche++;

            if (tipp > geheim) Console.WriteLine("Zu groß.");
            else if (tipp < geheim) Console.WriteLine("Zu klein.");
            else
            {
                Console.WriteLine($"Treffer! Zahl war {geheim}. Versuche: {versuche}");
                break;
            }
        }
    }
    #endregion

    #region Blackjack Light (while) 
    static void BlackjackLight()
    {
        Console.WriteLine("Blackjack Light – Spieler vs. Dealer");
        int player = 0, dealer = 0;

        // Startkarten
        player += Rng.Next(1, 12);
        dealer += Rng.Next(1, 12);

        // Spielerzug (while)
        while (true)
        {
            Console.Write($"Spieler: {player} Punkte. Karte ziehen? (j/n): ");
            string? a = Console.ReadLine()?.Trim().ToLowerInvariant();

            if (a == "j")
            {
                player += Rng.Next(1, 12);
                if (player > 21)
                {
                    Console.WriteLine($"Überkauft! Spieler: {player}. Dealer gewinnt.");
                    return;
                }
            }
            else if (a == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Bitte 'j' oder 'n'.");
            }
        }

        // Dealerzug (while): zieht bis >= 17 und mindestens so hoch wie Spieler
        Console.WriteLine($"Dealer beginnt bei {dealer}.");
        while (dealer < 17 || (dealer < player && dealer <= 21))
        {
            dealer += Rng.Next(1, 12);
            Console.WriteLine($"Dealer zieht… jetzt {dealer}");
        }

        // Ergebnis
        if (dealer > 21) Console.WriteLine("Dealer überkauft – Spieler gewinnt!");
        else if (dealer == player) Console.WriteLine($"Unentschieden ({player} : {dealer}).");
        else if (dealer > player) Console.WriteLine($"Dealer gewinnt ({dealer} vs. {player}).");
        else Console.WriteLine($"Spieler gewinnt ({player} vs. {dealer}).");
    }
    #endregion
}
