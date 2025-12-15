using System;
using System.Collections.Generic;
using System.Text;
using OOP3.Automaton;


namespace OOP3.Automaton
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
                Console.WriteLine("Bitte wählen Sie:");
                Console.WriteLine("1 = Anlegen Autos");
                Console.WriteLine("2 = Autos ausgeben");
                Console.WriteLine("3 = Gesamtwert");
                Console.WriteLine("4 = Abfragen PS");
                Console.WriteLine("5 = Preise erhöhen");
                Console.WriteLine("9 = Beenden");
                auswahl = int.Parse(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        autos = erfassenAuto(autos);
                        break;
                    case 2:
                        ausgebenAutos(autos);
                        break;
                    case 3:
                        ausgebenWert(autos); break;
                    case 4:
                        abfragenPS(autos);
                        break;
                    case 5:
                        autos = preiseErhoehen(autos);
                        break;

                }

            } while (auswahl != 9);



        }

        private static Auto[] preiseErhoehen(Auto[] autos)
        {
            Console.WriteLine("Prozent Erhöhung: ");
            int prozentErhoehung = int.Parse(Console.ReadLine());
            for (int i = 0; i < autos.Length; i++)
            {
                autos[i].Wert *= (1 + (double)prozentErhoehung / 100);
                // autos[i].Wert = autos[i].Wert * (1 + (double)prozentErhoehung / 100);
            }
            return autos;
        }

        private static void abfragenPS(Auto[] autos)
        {
            Console.WriteLine("Mindest PS-Zahl:");
            int minPS = int.Parse(Console.ReadLine());

            for (int i = 0; i < autos.Length; i++)
            {
                if (autos[i].PS >= minPS)
                {
                    Console.WriteLine(autos[i].ToString());
                }
            }
        }

        private static void ausgebenWert(Auto[] autos)
        {
            double summe = 0;
            for (int i = 0; i < autos.Length; i++)
            {
                summe += autos[i].Wert;
            }
            Console.WriteLine("Gesamtwert" + summe);
        }

        private static void ausgebenAutos(Auto[] autos)
        {
            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine(autos[i].ToString());
            }
        }

        private static Auto[] erfassenAuto(Auto[] autos)
        {
            Console.WriteLine("Wie viele Autos?");
            int anz = int.Parse(Console.ReadLine());
            autos = new Auto[anz];

            for (int i = 0; i < anz; i++)
            {
                Console.WriteLine("Wert:");
                double wert = double.Parse(Console.ReadLine());
                Console.WriteLine("PS:");
                int ps = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                autos[i] = new Auto(wert, ps, name);
            }
            return autos;
        }
    }
}
