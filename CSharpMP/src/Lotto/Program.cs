using System;
using Lotto.UI.bannerAscii;
using Lotto.Helpers;


namespace Lotto
{
    internal static class Program
    {
        static void Main()
        {
            Banner.ShowBanner();

            // your main game logic here
            Console.WriteLine("1 = Tippschein ausfüllen");
            Console.WriteLine("2 = Lottozahlen ziehen");
            Console.WriteLine("3 = Tippschein speichern");
            Console.WriteLine("0 = Programm beenden\n");
        }
    }
}
