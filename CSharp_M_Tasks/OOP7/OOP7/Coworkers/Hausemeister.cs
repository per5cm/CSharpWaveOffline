using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworkers
{
    internal class Hausemeister : Coworkers
    {
        internal string Role { get; set; }
        internal Hausemeister(string name, int hoursWorked, string role) : base(name, hoursWorked)
        {
            Role = role;
        }
        internal void Clean()
        {
            Console.WriteLine($"Name: {Name} reinigt gerade das Schulgebäude.");
        }
    }
}
