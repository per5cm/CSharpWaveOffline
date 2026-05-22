using System;
using EnumsAmpel_ExE_1.Library;

namespace EnumsAmpel_ExE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ampel = new Ampel(ampelPhase:AmpelPhase.Grün, schaltZeitung: 1);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ampel.AktuellePhase);
                Thread.Sleep(ampel.SchaltZeitung * 1000);
                ampel.WechselPhase();
            }
        }
    }
}