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

// Console.WriteLine("Array find repeating numbers");

// int[] countWaldo = { 2, 5, 7, 2, 3, 2, 9, 7 };

// Console.Write("Eingebe einen Zahl ein: ");
// int input = int.Parse(Console.ReadLine());

// int frequency = 0;

// for (int count = 0; count < countWaldo.Length; count++)
// {
//     if (countWaldo[count] == input)
//     {
//         frequency++;
//     }

//     else
//     {
//         continue;
//     }
// }
// Console.WriteLine($"Die Zahl {input} kommt {frequency} mal in Array vor.");

// Console.WriteLine("Schulnoten\n");

// double[] arrayGrade = new double [6];


// double sum = 0;
// int count = 0;
// double grade;

// do
// {
//     Console.Write("Geben Sie Shulnoten ein: ");
//     grade = double.Parse(Console.ReadLine());

//     if (grade == 0)
//         {
//             break;
//         }
//         else if (grade < 1 || grade > 6)
//         {
//             Console.WriteLine("Ungültige Note!");
//             continue;
//         }
//         else
//         {
//             arrayGrade.Add(grade);
//             sum += grade;
//             count++;
//         }
// } while (true);

// double averageGrade = sum / count;

// Console.WriteLine("Geschpeicherte Liste: ");
// for (int i = 0; i < arrayGrade.Count; i++)
// {
//     Console.Write(arrayGrade[i] + " ");
// }
// Console.WriteLine($"Anzahl Noten : {count}. Anzahl Summe: {sum}. Notendurchnitt: {averageGrade:F2}.");

Console.WriteLine("2D array");
int[,] arrayGrades = new int[5, 6];
string[] subjects = { "Java", "DB", "BWL", "Web", "Mathe" };

for (int row = 0; row < arrayGrades.GetLength(0); row++)
{
    for (int col = 0; col < arrayGrades.GetLength(1); col++)
    {
        Console.WriteLine($"Array Grade [ {row},{col}] = {arrayGrades[row, col]}");
    }
}

int sum = 0;
for (int row = 0; row < arrayGrades.GetLength(0); row++)
{
    for (int col = 0; col < arrayGrades.GetLength(1); col++)
    {
        if (row == col) sum += arrayGrades[row, col];
    }
}

Console.WriteLine($"Sum of Array {sum}");


// Working version something like that.

int[,] arrayGrades = new int[5, 6];
string[] subjects = { "Java", "DB", "BWL", "Web", "Mathe" };

// int sum = 0;
// int count = 0;

while (true)
{
    Console.WriteLine("Java = 1, DB = 2, BWL = 3, Web = 4, Mathe = 5, Ende = 0");
    Console.Write("Fachnummer: 1 bis 5. Beenden - 0: ");
    int fach = int.Parse(Console.ReadLine());
    if (fach == 0) break;

    if (fach < 1 || fach > 5)
    {
        Console.WriteLine("Ungültiges Fach!");
        continue;
    }

    Console.Write("Note Eingeben 1 bis 6: ");
    int note = int.Parse(Console.ReadLine());
    if (note < 1 || note > 6)
    {
        Console.WriteLine("Ungültige Note!");
        continue;
    }

    arrayGrades[fach - 1, note - 1]++;
    Console.WriteLine("Eingabe gespeichert.\n");
}

for (int row = 0; row < subjects.Length; row++)
{
    Console.WriteLine($"\nFach: {subjects[row]}");

    int sum = 0;
    int count = 0;

    for (int col = 0; col < 6; col++)
    {
        Console.WriteLine($"Note {col + 1}: {arrayGrades[row, col]}");
        sum += arrayGrades[row, col] * (col + 1);
        count += arrayGrades[row, col];
    }

    if (count > 0)
        Console.WriteLine($"Durchschnitt: {(double)sum / count:F2}");
    else
        Console.WriteLine("Keine Noten eingetragen.");
}
