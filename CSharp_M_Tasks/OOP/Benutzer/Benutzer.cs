using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Benutzer
{
    internal class Benutzer
    {
        internal string Vorname { get; set; }
        internal string Nachname { get; set; }
        internal int Alter { get; set; }
        internal Benutzer(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }

    internal void Vorstellung()
        {
            Console.WriteLine($"Hallo, ich heiße {Vorname} {Nachname} und bin {Alter} Jahre alt.");

        }
    }
}
