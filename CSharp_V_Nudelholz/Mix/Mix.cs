using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Mix
{
    class Snippets
    {
        internal static void Main(string[] args)
        {
            var menu = new List<string>
            {
                "0: Exit.",
                "1: FizzBuzz.",
                "2: Binary String to Decimal."
            };

            while (true)
            {
                foreach(var item in menu)
                    Console.WriteLine(item);

                Console.WriteLine();
                Console.WriteLine("Pick a Option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid Option!");
                        Console.ReadKey(true); // read key true = doesnt display key pressed, read key false does display pressed key.
                    continue;
                }


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye!"); return;

                    case 1: FizzBuzz(); break;
                    case 2:
                        {
                            Console.WriteLine("Enter binary number: ");
                            string? input = Console.ReadLine();

                            if (BinToDec(input, out int value))
                                Console.WriteLine($"Decimal: {value}");

                            else Console.WriteLine("Invalid binary number");

                            Console.ReadKey(true); break;
                        }

                    default:
                        Console.WriteLine("Option not available!");
                        Console.ReadKey(true); break;
                }
            }           
        }

        internal static void FizzBuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }                     
            }
        }

        internal static bool BinToDec(string? bin, out int result)
        {
            result = 0;

            if (string.IsNullOrWhiteSpace(bin))
                return false;

            foreach (char c in bin)
                if (c != '0' && c != '1')
                    return false;

            result = Convert.ToInt32(bin, 2);
            return true;
        }
    }
}