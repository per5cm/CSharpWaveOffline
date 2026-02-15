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
                foreach (var item in menu)
                    Console.WriteLine(item);

                Console.WriteLine();
                Console.WriteLine("Pick a Option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Pause();
                    continue;
                }


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye!"); return;

                    case 1:
                        {
                            Console.WriteLine("Enter a number to calculate FizzBuzz range: ");
                            string? inputFor = Console.ReadLine();

                            if (!int.TryParse(inputFor, out int rangeIn) || rangeIn < 1)
                            {
                                Console.WriteLine("That not valid positive number. Try again.");
                            }

                            FizzBuzz(rangeIn);

                            Pause();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter binary number: ");
                            string? inputBinary = Console.ReadLine();

                            if (BinToDec(inputBinary, out int valueDecimal))
                                Console.WriteLine($"From Binary to Decimal Number, value is - {valueDecimal}");

                            else Console.WriteLine("Entered an invalid binary number");

                            Pause();
                            break;
                        }

                    default:
                        Pause(); break;
                }
            }
        }

        internal static void FizzBuzz(int rangeOut)
        {
            Console.WriteLine();
            Console.WriteLine($"FizzBuzz up to {rangeOut}");
            Console.WriteLine();

            // loop starts at 0.
            for (int i = 0; i <= rangeOut; i++)
            {
                // or you can just say %15
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

        internal static bool BinToDec(string? binaryIn, out int resultOut)
        {
            resultOut = 0;

            if (string.IsNullOrWhiteSpace(binaryIn)) return false;

            binaryIn = binaryIn.Trim();

            foreach (char c in binaryIn)
                if (c != '0' && c != '1') return false;

            resultOut = Convert.ToInt32(binaryIn, 2);
            return true;
        }
    #region Helppers

    public static void Pause()
        {
            Console.WriteLine("Invalid Option!");
            Console.WriteLine("Press any Key to continue...");
            Console.ReadKey(true); // read key true = doesnt display key pressed, read key false does display pressed key.
        }

        #endregion
    }
}