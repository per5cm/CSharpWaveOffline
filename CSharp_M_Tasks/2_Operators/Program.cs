using System;

class Opoerators
{
    static void Main(string[] args)
    {
        var menuOption = new List<string>
        {
            "1. Basic Math",
            "2. Increment / Decrement",
            "0. Exit"
        };

        while(true)
        {
            Console.WriteLine("<---Operators--->");
            foreach(var option in menuOption)
                Console.WriteLine(option);
        }
    }

    #region Helpers

    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            // to add min and max values, like const
            //if (min == int.MinValue && max == int.MaxValue)
            //    Console.Write($"{label}: ");
            //else
            //    Console.Write($"{label} ({min}-{max}): "); 

            //if (int.TryParse(Console.ReadLine(), out int n) && n >= min && n <= max)
            //    return n;
            if (int.TryParse(Console.ReadLine), out int n)
                return n;

            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    #endregion
}