using System;

class Operators
{
    static void Main(string[] args)
    {
        var menuOption = new List<string>
        {
            "1. Basic Concatenation",
            "2. Increment / Decrement",
            "3. Logic Expression",
            "0. Exit"
        };

        while(true)
        {
            Console.WriteLine("<---Operators--->");
            foreach(var option in menuOption)
                Console.WriteLine(option);

            int menuPick = ReadInt("Pick: ", 0, 9);

            switch(menuPick)
            {
                case 0:
                    Console.WriteLine("Bye!");
                    return;
                
                case 1: BasicConcatenation(); break;
                case 2: IncrementDecrement(); break;
                case 3: LogicExpression(); break;

            }
        }
    }

    static void BasicConcatenation()
    {
        Console.WriteLine("--- Basic Concatenation Rules ---");

        // console priting logic, + its not like + from math.
        double x = 1.0; 
        double y = 2.5;

        Console.WriteLine("x / y = " + x / y);
        Console.WriteLine(x + y);
        Console.WriteLine(1+ 2 + 3 + 4);
        //Console.WriteLine(1 + [2 + 3] + 4);
        Console.WriteLine(1 + 2 + 3 + "4");
        Console.WriteLine("1" + 2 + 3 + 4);
        Console.WriteLine("Hilfe" + true + 3);
        //Console.WriteLine(true + 3 + "Hilfe");
        
    }

    static void IncrementDecrement()
    {
        // print values are assignet to variables thats why a becomes 2, b becomes 3, c bit more complicated.
        int a = 1, b = 2, c = 3, d = 4;

        Console.WriteLine(a++);
        Console.WriteLine(a);
        Console.WriteLine(++b);
        Console.WriteLine(b);
        Console.WriteLine((++c)+(c++));
        Console.WriteLine(c);
    }

    static void LogicExpression()
    {
        int x = 7;
        Console.WriteLine(x < 9 && x >= -5); // True, 7<9 ->true, 7>=-5 -> true
        Console.WriteLine(x != 7 && x >= 3); // False, 7!=7 ->false
        Console.WriteLine(x++ == 8 || x == 7); // False 7==8 -> flase
        Console.WriteLine((x > 0 && x < 10) || x != 7); // True, left:true||true, false->True
        Console.WriteLine((x < 0 || x > 5) && (x <= 7 || x > 10)); // True, left:flase||true->true, right:true||false->true=true&&true->True.
    }

    #region Helpers

    static int ReadInt(string label, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            //to add min and max values, like const
            if (min == int.MinValue && max == int.MaxValue)
                Console.Write($"{label}: ");
            else
                Console.Write($"{label} ({min}-{max}): ");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= min && n <= max)
                return n;

            Console.WriteLine("Ungültige Eingabe.");
        }
    }
    static string ReadText(string label)
    {
        Console.Write($"{label}: ");
        string? input = Console.ReadLine();
        return string.IsNullOrWhiteSpace(input) ? "" : input.Trim();
    }

    #endregion
}