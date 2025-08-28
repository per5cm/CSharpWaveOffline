// Console.WriteLine("Berechnung Bestellwert");
// Console.Write("Bestellwert in Euro: ");

// Ausführlich
// string eingabe = Console.ReadLine();
// double eingabeUmgewandelt = double.Parse(eingabe);

// 2 Schritte auf einmal
// double bestellWert  = double.Parse(Console.ReadLine());
// double ergebnis = bestellWert;

// if(bestellWert < 200)
// {
//     ergebnis = ergebnis + 5.5;
// }

// Console.WriteLine($"Rechnungsbetrag {ergebnis}" );
// Console.WriteLine("Programmende Bestell");

// Console.WriteLine("Ein Dreieck Berechnung");

// Console.Write("Bitte Seite A eingeben: ");
// float seite_a = Convert.ToSingle(Console.ReadLine());

// Console.Write("Bitte Seite B eingeben: ");
// float seite_b = Convert.ToSingle(Console.ReadLine());

// Console.Write("Bitte seite C eingeben: ");
// float seite_c = Convert.ToSingle(Console.ReadLine());


// Console.WriteLine("Gleichung X");

// Console.Write("Gleichunn A: ");
// int gleichung_a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Gleichung B: ");
// int gleichung_b = Convert.ToInt32(Console.ReadLine());

// Prüfung Fehler bei ungültiger Eingabe a = b
// if (gleichung_a == 0)
// {
//     Console.WriteLine("Fehler: ");
// }

// else if (gleichung_b == 0)
// {
//     Console.WriteLine("Fehler: ");
// }

// else
// {
//     double ergebnis_x = -gleichung_b / gleichung_a;
//     Console.WriteLine($"Lösung: {ergebnis_x}");
// }


// starts with

Console.WriteLine("Bank Hallo!!\n");

Console.Write("Bitte geben Sie Ihre Begrüßung ein und finden Sie heraus, welchen Preis Sie bekommen!: ");
string begruessung = Console.ReadLine();
if (begruessung.Equals("Hello", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("0€");
}
else if (begruessung.Equals("H",StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("20€");
}
else
{
    Console.WriteLine("100€");
}

