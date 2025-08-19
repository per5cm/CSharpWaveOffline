Console.WriteLine("Wilkommen zur GEWINNER LOTTO!!!");

Console.WriteLine("\nBitte wählen Sie:");
Console.WriteLine("1 = Tippschein ausfüllen:");
Console.WriteLine("2 = Lottozahlen ziehen");
Console.WriteLine("3 = Tippschein speichern");
Console.WriteLine("0 = Programm beenden\n");


Console.Write("Eingabe: ");
string InputEingabe = Console.ReadLine();
Console.Write($"Es wurde Programm: {InputEingabe} gewählt!\n");

Console.WriteLine("Bitte füllen Sie Ihren Tippschein aus.");
//Console.Write("Eingabe: ");

Console.Write("Zahl 1: ");
string InputTippschein_1 = Console.ReadLine();
int zahl1 = int.Parse(InputTippschein_1);
//Console.WriteLine($"Zahl 1: {InputTippschein_1} ");

Console.Write("Zahl 2: ");
string InputTippschein_2 = Console.ReadLine();
int zahl2 = int.Parse(InputTippschein_2);
//Console.WriteLine($"Zahl 2: {InputTippschein_2} ");

Console.Write("Zahl 3: ");
string InputTippschein_3 = Console.ReadLine();
int zahl3 = int.Parse(InputTippschein_3);
//Console.WriteLine($"Zahl 3: {InputTippschein_3} ");

Console.Write("Zahl 4: ");
string InputTippschein_4 = Console.ReadLine();
int zahl4 = int.Parse(InputTippschein_4);
//Console.WriteLine($"Zahl4: {InputTippschein_4} ");

Console.Write("Zahl 5: ");
string InputTippschein_5 = Console.ReadLine();
int zahl5 = int.Parse(InputTippschein_5);
//Console.WriteLine($"Zahl5: {InputTippschein_5} ");

Console.Write("Zahl 6: ");
string InputTippschein_6 = Console.ReadLine();
int zahl6 = int.Parse(InputTippschein_6);
//Console.WriteLine($"Zahl 6: {InputTippschein_6} ");

Console.WriteLine($"\nGlückwunsch, Ihre Zahlen: {zahl1} {zahl2} {zahl3} {zahl4} {zahl5} {zahl6}");
