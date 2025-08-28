using System;
class Program
{
    static void Main(string[] args)
    {


        // Primzahlen berechnen 1.0
        #region Odd/Even/Prim

        int input;
        bool IsPrime(int zahl)
        {
            bool isPrim = false;
            decimal grenze = (decimal)Math.Sqrt(zahl);

            for (int i = 2; i < grenze; i++)
            {
                if (zahl % i == 0)
                {
                    Console.WriteLine("Teilbar durch " + i);
                    isPrim = true;
                }
            }
            return !isPrim;
        }

        static void PrimzahlMenu()
        {
            Console.WriteLine("Primzahl-Test");
            // Console.Write("Gebe ein Zahl zum testen ein: ");
            do
            {
                Console.Write("Gebe eine Zahl zum testen ein (0 = Beenden): ");

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (IsPrime(Input))
                    {
                        Console.WriteLine(input + " ist eine Primzahl");
                    }
                    else
                    {
                        Console.WriteLine(input + " ist keine Primzahl");
                    }
                }
                else
                {
                    Console.WriteLine("Uengultige Eingabe");
                }
            } while (input != 0);
        }
    }
}
#endregion