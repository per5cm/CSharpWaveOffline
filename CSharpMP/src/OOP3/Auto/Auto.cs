using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3.Auto
{
    internal class Auto
    {
        private static int _anzahlAutos = 0;

        public static int AnzahlAutos
        {
            get
            {
                return _anzahlAutos;
            }
            private set
            {
                _anzahlAutos = value;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("PS", "PS darf nicht negativ sein.");
                }
                ps = value;
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

    }
}
