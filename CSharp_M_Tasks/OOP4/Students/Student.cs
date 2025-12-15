using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4.Student
{
    internal class Student
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string StreetName { get; set; }
        internal string HouseNumber { get; set; }
        internal string ZipCode { get; set; }
        internal string City { get; set; }
        internal string StudentClass { get; set; }
        internal int Note { get; set; }


        internal Student(string name, string surname, string streetName, string houseNumber, string zipCode, string city, string studentClass, int note)
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
    }
}