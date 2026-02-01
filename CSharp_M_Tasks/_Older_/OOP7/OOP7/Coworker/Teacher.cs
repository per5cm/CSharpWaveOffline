using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworker
{
    internal class Teacher : Coworkers
    {
        internal string Subject { get; set; }
        internal Teacher(string name, int hoursWorked, string subject) : base(name, hoursWorked)
        {
            Subject = subject;
        }
        internal override void Work()
        {
            Console.WriteLine($"Name: {Name} unterrichtet für {HoursWorked} Studen in der Fach: {Subject}.");
        }
    }
}
