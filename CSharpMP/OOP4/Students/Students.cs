using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.Students
{
    internal class Students
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string StreetName { get; set; }
        internal int HouseNumber { get; set; }
        internal int ZipCode { get; set; }
        internal string City { get; set; }
        internal string StudentClass { get; set; }
        internal int Note { get; set; }


        internal Students(string name, string surname, string streetName, int houseNumber, int zipCode, string city, string studentClass, int note)
        {
            Name = name;
            Surname = surname;
            StreetName = streetName;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            City = city;
            StudentClass = studentClass;
            Note = note;
        }

        internal void getAdress()
        {
            Console.WriteLine($"{StreetName} {HouseNumber}, {ZipCode} {City}");
        }
    }
}