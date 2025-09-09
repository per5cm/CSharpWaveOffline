// Console.WriteLine("Briefe!\n");

// Console.Write("Bitte gewischt in gram eingeben: ");
// string eingabe_gram = Console.ReadLine();
// int ausgabe_gram = int.Parse(eingabe_gram);

// double duke_dollars = 0;

// switch (ausgabe_gram)
// {
//     case <= 20:
//         duke_dollars += 1.00;
//         Console.WriteLine($"Porto Kosten bis 20 gram: ${duke_dollars:F2}.\n");
//         break;

//     case <= 50:
//         duke_dollars += 1.70;
//         Console.WriteLine($"Porto Kosten bis 50 gram: ${duke_dollars:F2}.\n");
//         break;

//     case <= 100:
//         duke_dollars += 2.40;
//         Console.WriteLine($"Porto Kosten bis 100 gram: ${duke_dollars:F2}.\n");
//         break;

//     case <= 250:
//         duke_dollars += 3.20;
//         Console.WriteLine($"Porto Kosten bis 250 gram: ${duke_dollars:F2}.\n");
//         break;

//     case <= 500:
//         duke_dollars += 4.00;
//         Console.WriteLine($"Porto Kosten bis 500 gram: ${duke_dollars:F2}.\n");
//         break;

//     case <= 1000:
//         duke_dollars += 4.80;
//         Console.WriteLine($"Porto Kosten bis 1000 gram: ${duke_dollars:F2}.\n");
//         break;

//     default:
//         Console.WriteLine("Geh nach Hause bitte!\n");
//         break;
// }

Consol.WriteLine("Tachenrechner\n");

Console.WriteLine("Zahl eins: ");
string zahl_eins = double.Parse(Console.ReadLine());

Console.WriteLine("Mögliche berechnungen +, -, *, /: ");
string operator_auswahl = Console.ReadLine();

Console.WriteLine("Zahl zwei: ");
string zahl_zwei = double.Parse(Console.ReadLine());

double ergebnis_summe;

switch (operator_auswahl)
{
    case "+":
        ergebnis_summe = zahl_eins + zahl_zwei;
        Console.WriteLine($"Ergebnis +: {ergebnis_summe}.");
        break;

    case "-":
        ergebnis_summe = zahl_eins - zahl_zwei;
        Console.WriteLine($"Ergebnis -: {ergebnis_summe}.");
        break;

    case "*":
        ergebnis_summe = zahl_eins * zahl_zwei;
        Console.WriteLine($"Ergebnis *: {ergebnis_summe}.");
        break;

    case "/":
        ergebnis_summe = zahl_eins / zahl_zwei;
        Console.WriteLine($"Ergebnis /: {ergebnis_summe}");
        break;

    default:
        Console.WriteLine("Fehler - Ungültiger Operator!");
        break;
}