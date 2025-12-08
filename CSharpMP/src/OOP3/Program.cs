using System;
using System.Collections.Generic;
using System.Text;
using OOP3.Auto;


namespace OOP3
{     
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos = { };
            int auswahl = 0;

            do
            {
                Console.WriteLine("Autoverwaltung");
                Console.WriteLine("Bitte wählen Sie eine Option:");
                Console.WriteLine("1. Anlegen Autos");
                Console.WriteLine("2. Anzeigen Autos");
                Console.WriteLine("3. Gesamtwert");
                Console.WriteLine("4. Abfragen PS");
                Console.WriteLine("5. Preise erhöhen");
                Console.WriteLine("9. Beenden");

                switch (auswahl)
                {
                    case 1: autos = erfassenAuto(autos); break;
                    case 2: ausgebenAutos(autos); break;
                    case 3: ausgabeWert(autos); break;
                    case 4: abfragenPS(autos); break;
                    case 5: preiseErhoehen(autos); break;
                }
            } while (auswahl != 9);
        }

        private static Auto[] preiseErhoehen(Auto[] autos)
        {
            Console.WriteLine("Prozente Erhöhung: ");
            int prozentErhoehung = int.Parse(Console.ReadLine());
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i].Wert += autos[i].Wert * prozentErhoehung / 100;
                // autos[i].Wert *= (1 + (double)prozentErhoehung / 100);
            }
            return autos;
        }

        private static void abfragenPS(Auto[] autos)
        {

        }
    }
}

