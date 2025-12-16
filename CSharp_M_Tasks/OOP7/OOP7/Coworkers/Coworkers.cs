using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworkers
{
    internal class Coworkers
    {
        internal string Name { get; set; }
        internal int HoursWorked { get; set; } = 0;


        internal Coworkers(string name, int hoursWorked) 
        {
            Name = name;
            HoursWorked = hoursWorked;
        }

        internal void IsWorking()
        {
            Console.WriteLine($"Name: {Name} am arbeiten, seit: {HoursWorked} Stunden.");
        }

    }
}
