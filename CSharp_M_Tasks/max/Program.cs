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
    }
}