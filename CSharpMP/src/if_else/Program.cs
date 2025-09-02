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


Console.WriteLine("Kindergeld");

Console.Write("\nBitte Ihre Jahres Einkommen Eingeben: ");
string input_einkommen = Console.ReadLine();
float ausgabe_einkommen = Convert.ToSingle(input_einkommen);

Console.Write("\nBitte Anzahl Kinder Eingeben: ");
string input_kinder = Console.ReadLine();
int ausgabe_kinder = Convert.ToInt32(input_kinder);

double kinder_kindergeld = 0;

if (ausgabe_einkommen < 45000)
{
    if (ausgabe_kinder == 1)
    {
        kinder_kindergeld += 70;
    }
    if (ausgabe_kinder == 2)
    {
        kinder_kindergeld += 130;
    }
    if (ausgabe_kinder == 3)
    {
        kinder_kindergeld += 220;
    }
    if (ausgabe_kinder == 4)
    {
        kinder_kindergeld += 240;
    }
}

else if (ausgabe_einkommen > 45000)
{
    if (ausgabe_kinder == 1)
    {
        kinder_kindergeld += 70;
    }
    if (ausgabe_kinder == 2)
    {
        kinder_kindergeld += 70;
    }
    if (ausgabe_kinder == 3)
    {
        kinder_kindergeld += 140;
    }
    if (ausgabe_kinder == 4)
    {
        kinder_kindergeld += 140;
    }
}

Console.WriteLine($"Kindergeld: {kinder_kindergeld}");