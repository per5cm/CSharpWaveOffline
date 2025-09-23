// Console.WriteLine("Ganze Zahlen");

// Console.Write("Geben Sie eine ganze Zahl ein: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);

// int whole_number = 1;

// while (whole_number <= number)
// {
//     if (number % whole_number == 0)
//     Console.WriteLine($"{number} teilbar durch: {whole_number}."); // Write geht auch.
//     whole_number++;
// }

// Console.WriteLine("Schulnoten\n");

// double sum = 0;
// int count = 0;
// double grade;

// do
// {
//     Console.Write("Geben Sie Shulnoten ein: ");
//     grade = double.Parse(Console.ReadLine());
//     if (grade == 0)
//     {
//         break;
//     }
//     else if (grade < 1 || grade > 6)
//     {
//         Console.WriteLine("Ungültige Note!");
//         continue;
//     }
//     else
//     {
//         sum += grade;
//         count++;
//     }
// } while (true);

// double average_grade = sum / count;
// Console.WriteLine($"Anzahl Noten : {count}. Anzahl Summe: {sum}. Notendurchnitt: {average_grade:F2}.");

// Console.WriteLine("Zinsenberechnung");

// Console.Write("Anzulegende Betrag in Euro: ");
// string input = Console.ReadLine();
// double intrest_value = double.Parse(input);

// Console.Write("Zinssatz in Prozent: ");
// bool successful = double.TryParse(Console.ReadLine(), out double intrest_rate); //bool to check input.


// Console.Write("Laufzeit in Jahren: ");
// int duration = int.Parse(Console.ReadLine());


// for (double year = 1; year <= duration; year++)
// {
//     intrest_value = intrest_value * (1 + intrest_rate / 100);
//     Console.WriteLine($"Wert nach dem {year}. Jahr: {intrest_value:F2}");
// }

// Console.WriteLine("Zahlenratspiel");


// Random geheimZahl = new Random();
// int geheimWert = geheimZahl.Next(1, 101);
// int versuch = 0;

// Console.WriteLine("Ich merke mir eine Zahl zwischen 1 und 100.");
// Console.WriteLine("Versuche, sie zu erraten!!\n");


// while (true)
// {
//     Console.Write("Bitte gib eine Zahl ein: ");
//     string eingabe = Console.ReadLine();

//     int tipp;
//     if (!int.TryParse(eingabe, out tipp))
//     {
//         Console.WriteLine("Das ist kein zahl bitte noch mal versuchen.\n");
//         continue;
//     }

//     versuch++;

//     if (tipp > geheimWert)
//     {
//         Console.WriteLine("Nein, Zahl ist zu groẞ, versuch es nochmal.\n");
//     }
//     else if (tipp < geheimWert)
//     {
//         Console.WriteLine("Nein, Zahl ist zu klein, versuch es nochmal.\n");
//     }
//     else
//     {
//         Console.WriteLine($"\nGlückwunsch! du hast die Zahl {geheimWert} erraten.");
//         Console.WriteLine($"Du hast {versuch} Versuche gebraucht!");
//         break;
//     }
// }

Console.WriteLine("Black Jack");

int playerCard = 0;
//int dealerCard = 0;

Random rng = new Random();

playerCard += rng.Next(1, 12);  // Random from 1 to 11? exclusive upperbound
//dealerCard += rng.Next(1, 12);

// player 1
while (true)
{
    if (playerCard == 21)
    {
        Console.WriteLine($"Sie haben: {playerCard}.");
        break;
    }
    Console.Write($"Dein Karte wert ist: {playerCard}, Weiter? j für Ja, n für Nein: ");

    string answer = Console.ReadLine();

    if (answer == "j")
    {
        playerCard += rng.Next(1, 12);

        if (playerCard > 21)
        {
            Console.WriteLine("Bite nach Hause gehen!");
            break;
        }

        else
        {
            continue;
        }
    }

    else if (answer == "n")
    {
        Console.WriteLine($"Sie haben: {playerCard} punkte.");
        break;
    }

    else
    {
        Console.WriteLine("Falsche antwort, probieren Sie nochmal");
        continue;
    }
}