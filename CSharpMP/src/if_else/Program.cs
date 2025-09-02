// Console.WriteLine("Durschnittsverbrauch");

// Console.WriteLine("\nBenzin");

// Console.Write("Bitte geben Sie die gefahreren Kilometer ein: ");
// int zahl_kilometer = Convert.ToInt32(Console.ReadLine());

// if (zahl_kilometer == 0)
// {
//     Console.WriteLine("Ungültige Strecke eingegeben!");
//     return;
// }

// Console.Write("Bitte geben Sie die verbrauchten Benzinmenge in Litern ein: ");
// float zahl_benzin = Convert.ToSingle(Console.ReadLine());


// float verbrauch = (zahl_benzin / zahl_kilometer) * 100;

// Console.WriteLine($"Verbrauch: {verbrauch}");


// Console.WriteLine("Kindergeld");

// Console.Write("\nBitte Ihre Jahres Einkommen Eingeben: ");
// string input_einkommen = Console.ReadLine();
// float ausgabe_einkommen = Convert.ToSingle(input_einkommen);

// Console.Write("\nBitte Anzahl Kinder Eingeben: ");
// string input_kinder = Console.ReadLine();
// int ausgabe_kinder = Convert.ToInt32(input_kinder);

// double kinder_kindergeld = 0;

// if (ausgabe_einkommen < 45000)
// {
//     if (ausgabe_kinder == 1)
//     {
//         kinder_kindergeld += 70;
//     }
//     if (ausgabe_kinder == 2)
//     {
//         kinder_kindergeld += 130;
//     }
//     if (ausgabe_kinder == 3)
//     {
//         kinder_kindergeld += 220;
//     }
//     if (ausgabe_kinder == 4)
//     {
//         kinder_kindergeld += 240;
//     }
// }

// else if (ausgabe_einkommen > 45000)
// {
//     if (ausgabe_kinder == 1)
//     {
//         kinder_kindergeld += 70;
//     }
//     if (ausgabe_kinder == 2)
//     {
//         kinder_kindergeld += 70;
//     }
//     if (ausgabe_kinder == 3)
//     {
//         kinder_kindergeld += 140;
//     }
//     if (ausgabe_kinder == 4)
//     {
//         kinder_kindergeld += 140;
//     }
// }

// Console.WriteLine($"Kindergeld: {kinder_kindergeld}");

// Console.WriteLine("Buẞgeld Converter!\n");

// Console.Write("Geschwindikeit in km Eingeben: ");
// string input_eingabe = Console.ReadLine();
// float top_speed = Convert.ToSingle(input_eingabe);

// int ausgabe_knoele_geld = 0;

// if (top_speed < 10)
// {
//     Console.WriteLine("Noch Glück gehabt!");
//     ausgabe_knoele_geld += 0;
// }
// else if (top_speed < 20)
// {
//     Console.WriteLine("Buẞgeld LVL 1!");
//     ausgabe_knoele_geld += 30;
// }
// else if (top_speed < 30)
// {
//     Console.WriteLine("Buẞgeld LVL 2!");
//     ausgabe_knoele_geld += 60;
// }
// else
// {
//     Console.WriteLine("Buẞgeld und Führerschein abgeben!");
//     ausgabe_knoele_geld += 200;
// }

// Console.WriteLine($"Buẞgeld in EUR: {ausgabe_knoele_geld}");


// Console.WriteLine("Temperaturrechner\n");

// Console.Write("Asuwertung Temperatur: ");
// string input_temperatur = Console.ReadLine();
// double output_temperatur = double.Parse(input_temperatur);

// if (output_temperatur <= 0)
// {
//     Console.WriteLine("Es handelt sich um Eis!\n");
// }
// else if (output_temperatur > 110)
// {
//     Console.WriteLine("Es handelt sich um Wasser\n!");
// }
// else if (output_temperatur >= 110)
// {
//     Console.WriteLine("Es handelt sich um Dampf!\n");
// }

// double convert_nach_farenheit = output_temperatur * 1.8 + 32;
// Console.WriteLine($"{output_temperatur} Grad Celsius entsprechen {convert_nach_farenheit} Farenheit");


Console.WriteLine("Gewichtsrechner BMI\n");

Console.Write("Bite Gröẞe in cm Eingeben: ");
string input_lenght = Console.ReadLine();
double convert_lenght = double.Parse(input_lenght);

Console.Write("Bitte Gewischt in kg Eingeben: ");
string input_weight = Console.ReadLine();
double convert_weight = double.Parse(input_weight);

double bmi_normal = convert_lenght - 100;
double bmi_ideal = (convert_lenght - 100) * 0.9;

Console.WriteLine($"\nIhr Normale gewischt wäre: {bmi_normal}\n");
Console.WriteLine($"Ihr Ideale gewischt wäre: {bmi_ideal}\n");

if (convert_weight == bmi_ideal)
{
    Console.WriteLine($"Sie haben ein Idealgewischt!\n");
}
else if (convert_weight < bmi_ideal)
{
    double under_ideal = (bmi_ideal - convert_weight) / bmi_ideal * 100;
    Console.WriteLine($"Sie Liegen {under_ideal:F2} % unter dem idealen gewischt\n");
}

