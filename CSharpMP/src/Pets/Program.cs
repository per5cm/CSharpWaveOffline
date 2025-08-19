// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// hier ist komentar /* multi komentare */

string name = "Erik";
int age = 30;

//console.WriteLine($"I love" + name + "and Pizza! He is: " + age + "years old.");
// $ ist F-string version von Python.
Console.WriteLine($"I love {name} and Pizza! He is: {age} years old.");

// Kundin Sandra Schmidt (27 Jahre) hat Konto-Nr. 
// 9876543210 -M Letzte Messung: 23.7°C Pi = 3.14159. Preis netto: 19.95 € Mitglied? True

//Unterstriche nur für die Lesbarkeit! 
long accountId = 987_654_321_0;
float temperature = 23.7f;
double pi = 3.14159;
decimal price = 19.95m;
bool isMember = true;
char separator = '-';
string firstName = "Sandra";
string lastName = "Schmidt";

Console.WriteLine($"Kundin {firstName} {lastName} {age} Jahre alt" 
+ $"\nKonto-Nr. {accountId}{separator}M Letzte Messung: {temperature}°C"
+ $"Pi = {pi}. Preis netto: {price} € Mitglied: {isMember}");