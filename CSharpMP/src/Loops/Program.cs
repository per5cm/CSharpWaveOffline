// int zahl = 21;
// int i;


// void Begruss(string name, int alter, bool volljaerig, double gewicht)
// {
//     Console.WriteLine("Hallo " + name + " Alter: " + alter + volljaerig + gewicht);
// }

// Begruss("Erikas", 37, false, 81.3);


// Primzahlen berechnen 1.0


int Input;
bool IsPrime(int zahl)
{
    bool teilbar = false;
    decimal grenze = (decimal)Math.Sqrt(zahl);
    
    for (int i = 2; i < grenze; i++)
    {
        if (zahl % i == 0)
        {
            Console.WriteLine("Teilbar durch " + i);
            teilbar = true;
        }
    }
    return !teilbar;
}


Console.WriteLine("Primzahl-Test");
// Console.Write("Gebe ein Zahl zum testen ein: ");
do
{
    Console.Write("Gebe eine Zahl zum testen ein (0 = Beenden): ");

    if (int.TryParse(Console.ReadLine(), out Input))
    {
        if (IsPrime(Input))
        {
            Console.WriteLine(Input + " ist eine Primzahl");
        }
        else
        {
            Console.WriteLine(Input + " ist keine Primzahl");
        }
    }
    else
    {
        Console.WriteLine("Uengultige Eingabe");
    }
} while (Input != 0);    