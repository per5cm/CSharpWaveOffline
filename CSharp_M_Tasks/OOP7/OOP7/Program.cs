using System;
using System.Collections.Generic;
using System.Text;
using OOP7.Coworker;


namespace OOP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Coworker> coworker = new List<Coworker>();

            coworker.Add(new Teacher("Frau Karen Bottoms", 10, "Mathematik"));
            coworker.Add(new Hausemeister("Herr Bob der Baumeister", 8, "Gartenpflege"));
            

            foreach (var c in coworker)
                c.Work();

        }
    }
}