using System;

class Program
{
    static void Main(string[] args)
    {
        // Aktiviere genau das, was du testen willst
        //array_1();
        //array_2();
        array_3();

    }
    #region Array

    static void array_1()
    {
        int[] first_array = [3, 5, 7, 9];
        //Console.WriteLine(first_array[0]);

        foreach (int i in first_array)
        {
            Console.WriteLine(i);
        }

    }

    static void array_2()
    {
        int[] array_list = { 2, 4, 6, 8 };
        int summe = 0;
        int average = 0;

        //for (int items = 0; items < array_list.Length; items++)
        foreach (var item in array_list)
        {
            summe += item;//array_list[items];
        }
        average = summe / array_list.Length;
        Console.WriteLine($"Array average is: {average}."); // for each = summe 
    }

    static void array_3()
    {
        int[] array_random_numbers = { -3, 10, 5, 12, 0 };
        int max = array_random_numbers[0];
        int min = array_random_numbers[0];

        for (int item = 0; item < array_random_numbers.Length; item++)
        {
            if (array_random_numbers[item] > max)
            {
                max = array_random_numbers[item];
            }
            if (array_random_numbers[item] < min)
            {
                min = array_random_numbers[item];
            }
        }
        Console.WriteLine($"Array maximum number is: {max}.");
        Console.WriteLine($"Array minimum number is: {min}.");
    }
    #endregion

    #region Listen
    static int ArraySumme(int[] array)
    {
        int summe = 0;
        foreach (int einzelneZahl in array)
        {
            summe += einzelneZahl;
        }
        return summe;
    }
    static void List1()
    {
        int[] meinErstesArray = [3, 5, 7];
        int sum = ArraySumme(meinErstesArray);
        foreach (int einzelneZahl in meinErstesArray)
        {
            Console.WriteLine(einzelneZahl);
        }
    }
    #endregion
}
