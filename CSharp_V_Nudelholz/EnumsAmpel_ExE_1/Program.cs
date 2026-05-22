using System;
using EnumsAmpel_ExE_1.Library;

namespace EnumsAmpel_ExE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ampel = new Ampel();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ampel.AktuellePhase);
                ampel.WechselPhase();
            }
        }
    }
}