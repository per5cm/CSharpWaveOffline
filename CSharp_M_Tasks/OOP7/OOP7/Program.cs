using System;
using System.Collections.Generic;
using System.Text;
using OOP7.Coworkers;


namespace OOP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Herr Müller", 5, "Mathematik");
            teacher.IsWorking();
            teacher.Teach();

            Hausemeister hausemeister = new Hausemeister("Frau Schmidt", 10, "Gartenpflege");
            hausemeister.IsWorking();
            hausemeister.Garden();
        }
    }
}