using System;
using EnumsAmpel_ExE_1.Library;

namespace EnumsAmpel_ExE_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var ampel = new Ampel(ampelPhase:AmpelPhase.Grün, schaltZeit: 1);

            while (true)
            {
                Console.WriteLine(ampel.AktuellePhase);
                await Task.Delay(ampel.SchaltZeit * 1000);
                ampel.WechselPhase();
            }
        }
    }
}