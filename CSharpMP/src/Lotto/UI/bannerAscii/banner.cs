using System;
using System.Threading;

namespace Lotto.UI.bannerAscii

{
    public static class Banner
    {
        public static void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // change color here for example Green

            string banner = @"
 _      ____  _______ _______  ____  
| |    / __ \|__   __|__   __|/ __ \ 
| |   | |  | |  | |     | |  | |  | |
| |   | |  | |  | |     | |  | |  | |
| |___| |__| |  | |     | |  | |__| |
|______\____/   |_|     |_|   \____/ 
";

            foreach (char c in banner)
            {
                Console.Write(c);
                Thread.Sleep(3); // adjust speed: 1 = fast, 10 = slow.
            }

            Console.ResetColor();
            Console.WriteLine("\n\n🎲 Willkommen zur GEWINNER LOTTO! 🎲\n");
        }
    }
}

