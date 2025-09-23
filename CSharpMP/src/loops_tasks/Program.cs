// Console.WriteLine("Ganze Zahlen");

// Console.Write("Geben Sie eine ganze Zahl ein: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);

// int whole_number = 1;

// while (whole_number <= number)
// {
//     if (number % whole_number == 0)
//     Console.WriteLine($"{number} teilbar durch: {whole_number}."); // Write geht auch.
//     whole_number++;
// }

// Console.WriteLine("Schulnoten\n");

// double sum = 0;
// int count = 0;
// double grade;

// do
// {
//     Console.Write("Geben Sie Shulnoten ein: ");
//     grade = double.Parse(Console.ReadLine());
//     if (grade == 0)
//     {
//         break;
//     }
//     else if (grade < 1 || grade > 6)
//     {
//         Console.WriteLine("Ungültige Note!");
//         continue;
//     }
//     else
//     {
//         sum += grade;
//         count++;
//     }
// } while (true);

// double average_grade = sum / count;
// Console.WriteLine($"Anzahl Noten : {count}. Anzahl Summe: {sum}. Notendurchnitt: {average_grade:F2}.");

// Console.WriteLine("Zinsenberechnung");

// Console.Write("Anzulegende Betrag in Euro: ");
// string input = Console.ReadLine();
// double intrest_value = double.Parse(input);

// Console.Write("Zinssatz in Prozent: ");
// bool successful = double.TryParse(Console.ReadLine(), out double intrest_rate); //bool to check input.


// Console.Write("Laufzeit in Jahren: ");
// int duration = int.Parse(Console.ReadLine());


// for (double year = 1; year <= duration; year++)
// {
//     intrest_value = intrest_value * (1 + intrest_rate / 100);
//     Console.WriteLine($"Wert nach dem {year}. Jahr: {intrest_value:F2}");
// }

