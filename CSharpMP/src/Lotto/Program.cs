Console.WriteLine("Wilkommen zur GEWINNER LOTTO!!!");

Console.WriteLine("\nBitte wählen Sie:");
Console.WriteLine("1 = Tippschein ausfüllen");
Console.WriteLine("2 = Lottozahlen ziehen");
Console.WriteLine("3 = Tippschein speichern");
Console.WriteLine("0 = Programm beenden\n");

Console.Write("Menu Auswahl: ");
string? inputEingabe = Console.ReadLine();
int menu_button_one = Convert.ToInt32(inputEingabe);
Console.Write($"Es wurde Programm: {inputEingabe} gewählt!\n");

int[] arrayNumbers = new int[6];
Random rng = new Random();

for (int x = 0; x < arrayNumbers.Length; x++)
{
    arrayNumbers[x] = rng.Next(0, 51);
}

if (menu_button_one == 1)
{
    Console.WriteLine("\nTippschein ausfüllen");
}
else
{
    Console.WriteLine("\nUngültige Menu Auswahl!:");
    return;
}

Console.WriteLine("\nBitte füllen Sie Ihren Tippschein aus mit nummern von 1 bis 49. Bitte kein doppel Zahlen Auswählen!.\n");

Console.Write("Zahl 1: ");
string? input_tippschein_1 = Console.ReadLine();
int zahl_1 = Convert.ToInt32(input_tippschein_1);

if (zahl_1 < 1 || zahl_1 > 49)
{
    Console.WriteLine("\nUngültige Zahl N.r 1!");
    return;
}

Console.Write("Zahl 2: ");
string? input_tippschein_2 = Console.ReadLine();
int zahl_2 = Convert.ToInt32(input_tippschein_2);

if (zahl_2 < 1 || zahl_2 > 49 || zahl_2 == zahl_1)
{
    Console.WriteLine("\nUngültige Zahl Nr. 2!");
    return;
}

Console.Write("Zahl 3: ");
string? input_tippschein_3 = Console.ReadLine();
int zahl_3 = Convert.ToInt32(input_tippschein_3);

if (zahl_3 < 1 || zahl_3 > 49 || zahl_3 == zahl_2 || zahl_3 == zahl_1)
{
    Console.WriteLine("\nUngültige Zahl Nr. 3!");
    return;
}

Console.Write("Zahl 4: ");
string? input_tippschein_4 = Console.ReadLine();
int zahl_4 = Convert.ToInt32(input_tippschein_4);

if (zahl_4 < 1 || zahl_4 > 49 || zahl_4 == zahl_3 || zahl_4 == zahl_2 || zahl_4 == zahl_1)
{
    Console.WriteLine("\nUngültige Zahl Nr. 4!");
    return;
}

Console.Write("Zahl 5: ");
string? input_tippschein_5 = Console.ReadLine();
int zahl_5 = Convert.ToInt32(input_tippschein_5);

if (zahl_5 < 1 || zahl_5 > 49 || zahl_5 == zahl_4 || zahl_5 == zahl_3 || zahl_5 == zahl_2 || zahl_5 == zahl_1)
{
    Console.WriteLine("\nUngültige Zahl Nr. 5!");
    return;
}

Console.Write("Zahl 6: ");
string? input_tippschein_6 = Console.ReadLine();
int zahl_6 = Convert.ToInt32(input_tippschein_6);

if (zahl_6 < 1 || zahl_6 > 49 || zahl_6 == zahl_5 || zahl_6 == zahl_4 || zahl_6 == zahl_3 || zahl_6 == zahl_2 || zahl_6 == zahl_1)
{
    Console.WriteLine("\nUngültige Zahl Nr. 6!");
    return;
}

Console.WriteLine($"\nGlückwunsch, Ihre Zahlen: {zahl_1} {zahl_2} {zahl_3} {zahl_4} {zahl_5} {zahl_6}");

int[,] pickedNumbers = new int[5, 6];
int[] userNumbers = { zahl_1, zahl_2, zahl_3, zahl_4, zahl_5, zahl_6 };

int ticketCount = 0;

while (true)
{
    Console.WriteLine($"\nTippschein Nr. {ticketCount + 1} ausfüllen, oder 'n' zu beenden");
    Console.Write("Neuer Tippschein?: j/n ");
    string? choice = Console.ReadLine();
    if (choice == "n") break;

    for (int count = 0; count < arrayNumbers.Length; count++)
    {
        Console.Write($"Zahl {count + 1}: ");
        pickedNumbers[ticketCount, count] = int.Parse(Console.ReadLine());
    }

    ticketCount++;

    if(ticketCount >= pickedNumbers.GetLength(0))
    {
        Console.WriteLine("Maximale Anzahl an Tippscheinen erreicht!"); break;
    }
}


