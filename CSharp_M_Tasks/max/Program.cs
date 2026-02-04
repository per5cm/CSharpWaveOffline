using System;

class Program
{
    static void Main(string[] args)
    {
        int[] CPULoad = new int[] { 12, 10, 40, 73, 33, 60 };
        int max = 0;
        int max2 = 0;

        for (int i = 0; i < CPULoad.Length; i++)
        {
            if (CPULoad[i] > max)
            {
                max2 = max;
                max = CPULoad[i];
            }
            else if (CPULoad[i] > max2)
            {
                max2 = CPULoad[i];
            }
        }

        Console.WriteLine($"first: {max},  second: {max2}");


        //new crap

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }

        FizzBuzz();
        
    }
    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
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
}