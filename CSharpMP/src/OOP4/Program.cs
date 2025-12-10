using System;
using System.Collections.Generic;
using System.Text;
using OOP4.Students;

class Program
{
    static List<Students> StudentsData = new();
    static int MaxStudents = 100;

    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        var menuOptions = new List<string>
        {
            "1. Anlegen Schüler",
            "2. Ausgeben Adressen",
            "3. Gesamtzahl der Schüler",
            "4. Klassenliste",
            "5. Druchnittsnote",
            "9. Programmende"
        };

        while (true)
        {
            Console.WriteLine("Hauptmenü:");
            foreach (var option in menuOptions)
                Console.WriteLine(option);

            int choice = ReadInt("Deine Wahl: ");

            switch (choice)
            {
                case 9:
                    Console.WriteLine("Auf Wiedersehn!");
                    return;

                case 1: CreateStudent(); break;
                case 2: ShowAdress(); break;
                case 3: StudentCount(); break;
                case 4: ClassList(); break;
                case 5: Average(); break;
                case 6: DisplayList(); break;
                default: Console.WriteLine("Ungültige Eingabe."); break;
            }
        }
    }

    static void CreateStudent()
    {
        Console.WriteLine("<Schüler anlegen>");

        string name = ReadString("Name: ");
        string surname = ReadString("Nachname: ");
        string streetName = ReadString("Straẞenname: ");
        int houseNumber = ReadInt("Hausenummer: ");
        int zipCode = ReadInt("Postleitzahl: ");
        string city = ReadString("Stadt: ");
        string studentClass = ReadString("Klasse: ");
        int note = ReadInt("Note 1 bis 6: ");

        var newStudent = new Students(name, surname, streetName, houseNumber, zipCode, city, studentClass, note);

        StudentData.Add(newStudent);
    }

    static void ShowAdress()
    {

    }

    static void StudentCount()
    {
        Console.WriteLine();
        Console.WriteLine("Schüller Liste ->");
    }

    static void ClassList()
    {

    }

    static void Average()
    {

    }

    static void DisplayList()
    {
        Console.WriteLine();
        Console.WriteLine("Gespeicherte Schüller ->");

        for (int display = 0; display < )
    }

    #region Helpers

    static int ReadInt(string label)
    {
        while (true)
        {
            Console.Write(label);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Gib endlich eine Zahl ein.");
        }
    }

    static string ReadString(string label)
    {
        Console.Write(label);
        string input = Console.ReadLine()?.Trim() ?? "";

        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Darf nicht leer sein.");
            Console.Write(label);
            input = Console.ReadLine()?.Trim() ?? "";
        }
        return input;
    }

    #endregion
}
