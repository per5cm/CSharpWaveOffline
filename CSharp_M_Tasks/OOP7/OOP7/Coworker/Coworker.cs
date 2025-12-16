using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworker
{
    abstract class Coworker
    {
        internal string Name { get; set; }
        internal int HoursWorked { get; set; } = 0;
        internal abstract void Work();


        internal Coworker(string name, int hoursWorked) 
        {
            Name = name;
            HoursWorked = hoursWorked;
        }
    }
}
