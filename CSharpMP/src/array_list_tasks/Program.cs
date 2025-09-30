// Console.WriteLine("Array liste");

// int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// // int max = firstArray[0];

// // int tempHolder = 0; // for Reverse temporal holder.

// foreach (int i in firstArray)
// {
//     Console.WriteLine(" " + i);
// }

// if (firstArray.Length > 0)
// {
//     for (int counter = firstArray.Length - 1; counter >= 0; counter--)
//     {
//         // tempHolder = firstArray[counter];
//         // firstArray[counter] = firstArray[firstArray.Length - counter - 1];
//         // firstArray[firstArray.Length - counter - 1] = tempHolder;
//         Console.WriteLine(" " + firstArray[counter]);
//     }
// }

// Console.WriteLine("Array Max");

// int[] findWaldo = { 23, 25, 27, 50, 64 };

// int maxWaldo = findWaldo[0];
// int minWaldo = findWaldo[0];

// for (int item = 0; item < findWaldo.Length; item++)
// {
//     if (findWaldo[item] > maxWaldo)
//     {
//         maxWaldo = findWaldo[item];
//     }

//     if (findWaldo[item] < minWaldo)
//     {
//         minWaldo = minWaldo[item];
//     }
// }
// Console.WriteLine($"Waldo steckt in Nummer: {maxWaldo}.");
// Console.WriteLine($"Waldo steckt in Nummer: {minWaldo}.");

Console.WriteLine("Array find repeating numbers");

int[] countWaldo = { 2, 5, 7, 2, 3, 2, 9, 7 };

Console.Write("Eingebe einen Zahl ein: ");
int input = int.Parse(Console.ReadLine());

int frequency = 0;

for (int count = 0; count < countWaldo.Length; count++)
{
    if (countWaldo[count] == input)
    {
        frequency++;
    }

    else
    {
        continue;
    }
}
Console.WriteLine($"Die Zahl {input} kommt {frequency} mal in Array vor.");


