using System;
using Lotto.UI.bannerAscii;
using static Lotto.Helpers.Helpers;




namespace Lotto
{
    internal static class Program
    {
        static void Main()
        {
            Banner.ShowBanner();
            ShowMenu();
        }

        internal static void ShowMenu()
        {
            // menu with switch case. using helper as input
            while (true)
            {
                Console.WriteLine("1 = Tippschein ausfüllen");
                Console.WriteLine("2 = Lottozahlen ziehen");
                Console.WriteLine("3 = Tippschein speichern");
                Console.WriteLine("0 = Programm beenden\n");
                int choice = ReadInt("Auswahl", 0, 3);

                switch (choice)
                {
                    case 0: return;
                    case 1: FillTicket(); break;
                    case 2: DrawNumber(); break;
                    case 3: SaveTicket(); break;
                }
            }
        }

        private static void FillTicket()
        {

        }

        private static void DrawNumber()
        {

        }
        
        private static void SaveTicket()
        {
            
        }
    }
}
