using System;
using System.Collections.Generic;
using System.Text;
using OOP4.Students;

class Program
{
    static List<Students> StudentsData = new();
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
            }
        }
    }

    static void CreateStudent()
    {

    }

    static void ShowAdress()
    {

    }

    static void StudentCount()
    {

    }

    static void ClassList()
    {

    }

    static void Average()
    {

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

    #endregion
}
