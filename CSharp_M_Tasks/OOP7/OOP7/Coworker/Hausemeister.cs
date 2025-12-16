using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworker
{
    internal class Hausemeister : Coworker
    {
        internal string Role { get; set; }
        internal Hausemeister(string name, int hoursWorked, string role) : base(name, hoursWorked)
        {
            Role = role;
        }
        internal override void Work()
        {
            Console.WriteLine($"Name: {Name} arbeitet für {HoursWorked} Stunden in {Role}.");
        }
    }
}
