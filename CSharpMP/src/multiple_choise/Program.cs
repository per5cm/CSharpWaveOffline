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

// Consol.WriteLine("Tachenrechner\n");

// Console.WriteLine("Zahl eins: ");
// string zahl_eins = double.Parse(Console.ReadLine());

// Console.WriteLine("Mögliche berechnungen +, -, *, /: ");
// string operator_auswahl = Console.ReadLine();

// Console.WriteLine("Zahl zwei: ");
// string zahl_zwei = double.Parse(Console.ReadLine());

// double ergebnis_summe = 0;

// switch (operator_auswahl)
// {
//     case "+":
//         ergebnis_summe = zahl_eins + zahl_zwei;
//         Console.WriteLine($"Ergebnis +: {ergebnis_summe}.");
//         break;

//     case "-":
//         ergebnis_summe = zahl_eins - zahl_zwei;
//         Console.WriteLine($"Ergebnis -: {ergebnis_summe}.");
//         break;

//     case "*":
//         ergebnis_summe = zahl_eins * zahl_zwei;
//         Console.WriteLine($"Ergebnis *: {ergebnis_summe}.");
//         break;

//     case "/":
//         ergebnis_summe = zahl_eins / zahl_zwei;
//         Console.WriteLine($"Ergebnis /: {ergebnis_summe}.");
//         break;

//     default:
//         Console.WriteLine("Fehler - Ungültiger Operator!");
//         break;
// }

Console.WriteLine("Kreiszahl PI\n");

Console.WriteLine("1 = Zylinder");
Console.WriteLine("2 = Würfel");
Console.WriteLine("3 = Quader");
Console.WriteLine("4 = Kugel\n");

int menu_button = int.Parse(Console.ReadLine());

switch (menu_button)
{
    case 1:
        Console.Write("Zylinder - radius in cm: ");
        double radius_z = double.Parse(Console.ReadLine());

        Console.Write("Zylinder - höhe in cm: ");
        double height_z = double.Parse(Console.ReadLine());

        double cylinder_o = 2 * Math.PI * radius_z * (radius_z + height_z);
        double volumen_c = Math.PI * radius_z * radius_z * height_z;

        Console.WriteLine($"Zylinder oberfläche: PI{cylinder_o}.");
        Console.WriteLine($"Zylinder volumen: PI{volumen_c}");
        break;

    case 2:
        Console.WriteLine("Würfel - Kantenlänge in cm: ");
        double height_w = double.Parse(Console.ReadLine());

        double cubic_o = 6 * height_w * height_w;
        double cubic_v = height_w * height_w * height_w;

        Console.WriteLine($"Würfel oberfläche: PI{cubic_o}");
        Console.WriteLine($"Würfel volumen: PI{cubic_v}");
        break;

    case 3:
        Console.WriteLine("Quader - höhe in cm: ");
        double height_a = double.Parse(Console.ReadLine());

        Console.WriteLine("Quader - länge in cm: ");
        double height_b = double.Parse(Console.ReadLine());

        Console.WriteLine("Quader - breite in cm: ");
        double height_c = double.Parse(Console.ReadLine());

        double quader_o = 2 * height_a * height_c + 2 * height_b * height_c + 2 * height_a * height_b;
        double quader_v = height_a * height_b * height_c;

        Console.WriteLine($"Quader oberfläche: PI{quader_o}");
        Console.WriteLine($"Quader volumen: PI{quader_v}");
        break;

    case 4:
        Console.WriteLine("Kugel - radius in cm: ");
        double radius_k = double.Parse(Console.ReadLine());

        double circle_o = 4 * Math.PI * radius_k * radius_k;
        double circle_v = (4 / 3) * Math.PI * radius_k * radius_k * radius_k;

        Console.WriteLine($"Quader oberfläche: PI{circle_o}");
        Console.WriteLine($"Kugel volumen: PI{circle_v}");
        break;

    default:
        Console.WriteLine("Kein Bock zu Tippen???!!!");
}
