using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3.Automaton
{
    internal class Auto
    {
        private static int anzahlAutos = 0;
        public static int AnzahlAutos
        {
            get
            {
                return anzahlAutos;
            }
            private set
            {
                anzahlAutos = value;
            }
        }

        public int Nummer { get; set; }
        public int Geschwindikeit { get; set; }
        public double Wert { get; set; }

        private int ps;
        public int PS
        {
            get => ps;
            set
            {
                if (value > 0)
                {
                    ps = value;
                } // TODO: else Pfad definieren
            }
        }

        public string Name { get; set; }

        public Auto(double wert, int ps, string name)
        {
            AnzahlAutos++;
            Nummer = AnzahlAutos;
            Geschwindikeit = 0;
            Wert = wert;
            PS = ps;
            Name = name;
        }

        public string ToString()
        {
            return "Auto " + Nummer + " ist " + Wert + " € wert, fährt aktuell " + Geschwindikeit + " km/h und heißt " + Name;
        }
    }
}
