
Console.WriteLine("Einsteins - E = mc^2");
Console.Write("Input mass in kg: ");
double m = double.Parse(Console.ReadLine());

const double c = 299792458;
double E = m * c * c;   // E = m^2

Console.WriteLine($"{E:E6}");


// Console.WriteLine("\nI love Pizza!");
// Console.WriteLine("Musterstrasse 1");
// Console.WriteLine("1234 Musterstadt\n");

// Console.WriteLine("Da hat wohl\nirgendjemand in\n\tWord ein\n\nBild zu viel\nverschoben!\n");

// Console.WriteLine("System.out.println(\"Sie sind ein Künstler, wenn dieser Text erscheint;\" \\(^.^)/\n");

// double x = 1.0;
// double y = 2.5;

// Console.WriteLine("x / y = " + x/y);
// Console.WriteLine(x + y);
// Console.WriteLine(1 + 2 + 3 + 4);
// Console.WriteLine(1 + (2 + 3) + 4);
// Console.WriteLine(1 + 2+ 3 + "4");
// Console.WriteLine("1" + 2 + 3 + 4);
// Console.WriteLine("Hilfe " + true + 3 + "\n");
//Console.WriteLine(true + 3 + "Hilfe"); <--- fehler ausgibt.

// int a = 1;
// int b = 2;
// int c = 3;
// int d = 4;

// Console.WriteLine(a++);
// Console.WriteLine(a);
// Console.WriteLine(++b);
// Console.WriteLine(b);
// Console.WriteLine((++c)+(c++));
// Console.WriteLine(c + "\n");

// int nr = 7;

// Console.WriteLine(nr < 9 && nr >= -5);
// Console.WriteLine(nr != 7 && nr >= 3);
// Console.WriteLine(nr++ == 8 || nr == 7);
// Console.WriteLine((nr > 0 && nr < 10) || nr != 7);
// Console.WriteLine((nr < 0 || nr > 5) && (nr <= 7 || nr > 10));
// Console.WriteLine("\n");

// int i = -3;

// Console.WriteLine((6 * ++i)-8 % 3);
// Console.WriteLine(i);

// i = 7;

// Console.WriteLine((i % 3 == 1) && (i >= 5));
// Console.WriteLine(!(i < 6 || i > 7)); // dreht die loging, z.b. suche den argument in the liste und er hat bestimmten wert nicht gefunden.
// Console.WriteLine((i / 2 == 3 || i == 7) && i != 0);
// Console.WriteLine((i * 2 > 10) && (i + 1 <= 8));