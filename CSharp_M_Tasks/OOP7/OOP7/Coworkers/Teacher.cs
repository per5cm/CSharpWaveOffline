using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7.Coworkers
{
    internal class Teacher : Coworkers
    {
        internal string Subject { get; set; }
        internal Teacher(string name, int hoursWorked, string subject) : base(name, hoursWorked)
        {
            Subject = subject;
        }
        internal void Teach()
        {
            Console.WriteLine($"Name: {Name} unterrichtet gerade {Subject}.");
        }
    }
}
