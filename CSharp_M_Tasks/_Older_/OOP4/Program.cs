using System;
using System.Collections.Generic;
using System.Text;
using OOP4.Student;

class Program
{
    static List<Student> StudentsData = new();

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
            "6. Alle Schüler anzeigen",
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
                    Console.WriteLine();
                    Console.WriteLine("Auf Wiedersehn!");
                    Pause();
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
        Console.WriteLine();
        Console.WriteLine("<-- Schüler anlegen -->");
        Console.WriteLine();

        int numberOfStudents = ReadInt("Wie viele Schüler möchten Sie anlegen? ");
        Console.WriteLine();

        for (int i = 0; i < numberOfStudents; i++)
        {
            string name = ReadString("Name: ");
            string surname = ReadString("Nachname: ");
            string streetName = ReadString("Straẞenname: ");
            string houseNumber = ReadString("Hausenummer: ");
            string zipCode = ReadString("Postleitzahl: ");
            string city = ReadString("Stadt: ");
            string studentClass = ReadString("Klasse: ");
            int note = ReadInt("Note 1 bis 6: ");

            var newStudent = new Student(name, surname, streetName, houseNumber, zipCode, city, studentClass, note);
            StudentsData.Add(newStudent);
        } 
    }

    static void ShowAdress()
    {
        Console.WriteLine("Schüller Adressen ->");

        for (int display = 0; display < StudentsData.Count; display++)
        {
            var student = StudentsData[display];
            Console.WriteLine($"{student.Name} {student.Surname}, {student.StreetName} {student.HouseNumber}, {student.ZipCode} {student.City}");
        }
        Console.WriteLine();

        Pause();
    }

    static void StudentCount()
    {
        Console.WriteLine();
        Console.WriteLine("Schüller Liste ->");
        Console.WriteLine();

        if (StudentsData.Count > 0)
            Console.WriteLine($"Es sind {StudentsData.Count} Schüler gespeichert.");
        else
            Console.WriteLine("Es sind keine Schüler gespeichert.");

        Pause();
    }

    static void ClassList()
    {
        string className = ReadString("Geben Sie die Klasse ein, die Sie anzeigen möchten: ");
        Console.WriteLine();

        bool found = false;

        foreach (var student in StudentsData)
        {
            //if (student.StudentClass == className)
            if (student.StudentClass.Equals(className, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{student.Name} {student.Surname}, Klasse: {student.StudentClass}");
                found = true;
            }
            //else
            //{
            //    Console.WriteLine("Keine Schüler in dieser Klasse gefunden.");
            //}
        }

        if (!found) Console.WriteLine("Keine Schüler in dieser Klasse gefunden.");

        Pause();
    }

    static void Average()
    {
        string className = ReadString("Geben Sie die Klasse ein, für die Sie die Durchschnittsnote berechnen möchten: ");
        Console.WriteLine();

        int totalNotes = 0;
        int count = 0;

        foreach (var student in StudentsData) 
        {
            //if (student.StudentClass == className)
            if (student.StudentClass.Equals(className, StringComparison.OrdinalIgnoreCase))
            {
                totalNotes += student.Note;
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("Keine Schüler in dieser Klasse gefunden.");
            return;
        }

        double average = (double)totalNotes / count;
        Console.WriteLine($"Durchschnittsnote für Klasse {className}: {average:F2}");

        Pause();
    }

    static void DisplayList()
    {
        Console.WriteLine();
        Console.WriteLine("Gespeicherte Schüller ->");

        for (int display = 0; display < StudentsData.Count; display++)
        {
            var student = StudentsData[display];
            Console.WriteLine($"{student.Name} {student.Surname}, {student.StreetName} {student.HouseNumber}, {student.ZipCode} {student.City}, Klasse: {student.StudentClass}, Note: {student.Note}");
        }
        Console.WriteLine();

        Pause();
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

    static void Pause()
    {
        Console.WriteLine("\nDrücke Enter, um fortzufahren...");
        Console.ReadLine();
    }

    #endregion
}
