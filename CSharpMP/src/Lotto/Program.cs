Console.WriteLine("Wilkommen zur GEWINNER LOTTO!!!");

Console.WriteLine("\nBitte wählen Sie:");
Console.WriteLine("1 = Tippschein ausfüllen");
Console.WriteLine("2 = Lottozahlen ziehen");
Console.WriteLine("3 = Tippschein speichern");
Console.WriteLine("0 = Programm beenden\n");

Console.Write("Menu Auswahl: ");
string inputEingabe = Console.ReadLine();
int menu_button_one = Convert.ToInt32(inputEingabe);
Console.Write($"Es wurde Programm: {inputEingabe} gewählt!\n");

if (menu_button_one == 1)
{
    Console.WriteLine("\nTippschein ausfüllen");
}
else
{
    Console.WriteLine("\nFalsche Eingabe!:");
    return;
}

Console.WriteLine("\nBitte füllen Sie Ihren Tippschein aus mit nummern von 1 bis 49.\n");



Console.Write("Zahl 1: ");
string inputTippschein_1 = Console.ReadLine();
int zahl1 = Convert.ToInt32(inputTippschein_1);

if (zahl1 < 1 || zahl1 > 49)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.Write("Zahl 2: ");
string inputTippschein_2 = Console.ReadLine();
int zahl2 = Convert.ToInt32(inputTippschein_2);

if (zahl2 < 1 || zahl2 > 49 || zahl1 == zahl2)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.Write("Zahl 3: ");
string inputTippschein_3 = Console.ReadLine();
int zahl3 = Convert.ToInt32(inputTippschein_3);

if (zahl3 < 1 || zahl3 > 49 || zahl3 == zahl1 || zahl3 == zahl2)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.Write("Zahl 4: ");
string inputTippschein_4 = Console.ReadLine();
int zahl4 = Convert.ToInt32(inputTippschein_4);

if (zahl4 < 1 || zahl4 > 49 || zahl4 == zahl3 || zahl4 == zahl2 || zahl4 == zahl1)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.Write("Zahl 5: ");
string inputTippschein_5 = Console.ReadLine();
int zahl5 = Convert.ToInt32(inputTippschein_5);

if (zahl5 < 1 || zahl5 > 49 || zahl5 == zahl4 || zahl5 == zahl3 || zahl5 == zahl2 || zahl5 == zahl1)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.Write("Zahl 6: ");
string inputTippschein_6 = Console.ReadLine();
int zahl6 = Convert.ToInt32(inputTippschein_6);

if (zahl6 < 1 || zahl6 > 49 || zahl6 == zahl5 || zahl6 == zahl4 || zahl6 == zahl3 || zahl6 == zahl2 || zahl6 == zahl1)
{
    Console.WriteLine("\nUngültige Eingabe!");
    return;
}

Console.WriteLine($"\nGlückwunsch, Ihre Zahlen: {zahl1} {zahl2} {zahl3} {zahl4} {zahl5} {zahl6}");
