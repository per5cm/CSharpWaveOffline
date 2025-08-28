using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primzahl-Test v3.0");
        PrimzahlMenu(); //nach return;
    }


    static void PrimzahlMenu()
    {
        //ulong input;

        while(true)
        {
            Console.Write("Gebe eine Zahl zum testen ein (b = Beenden): ");

            string? end_of_chain = Console.ReadLine();

            if (end_of_chain == "b")
                break; // return, wäre auch möglich

            if (BigInteger.TryParse(end_of_chain, out BigInteger output_of_loop))
                {
                    if (isPrime(output_of_loop))
                    {
                        Console.WriteLine(output_of_loop + " ist eine Primzahl.");
                    }
                    else
                    {
                        Console.WriteLine(output_of_loop + " ist keine Primzahl.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }

        } //while (input != 0);
    } // nach break;

    #region Primzahlprüfung
    // Primzahlen berechnen 3.0
    static bool isPrime(BigInteger zahl)
    {
        bool istPrim = true;

        if (zahl <= 1)
            return false;
        if (zahl == 2)
            return true;
        if (zahl % 2 == 0)
            return false;

        for (BigInteger i = 3; i * i <= zahl; i+=2)
            {
                if (zahl % i == 0)
                {
                    Console.WriteLine("Teilbar durch " + i);
                    istPrim = false;
                }
            }
        return istPrim;
    }
    #endregion
}