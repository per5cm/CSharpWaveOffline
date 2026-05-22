using System;
using ClimateChange_ExE_1.Library;

namespace ClimateChange_ExE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klimasteuergerät gestartet");

            // double sollWert = 21.5;
            // double istWert = 16.5;
            // double aussenTemparatur = 13;

            // List<Klimasteuergeraet> geraet = new()
            // {
            //     new Klimasteuergeraet(sollWert: 21.5, istWert: 16.5, aussenWert: 13, heizungAktiv: false,
            //         luefterstufe: 0),
            //     
            // };

            Klimasteuergeraet geraet = new(sollWert: 21.5, istWert: 16.5, aussenWert: 13, heizungAktiv: false,
                luefterstufe: 0);
            geraet.Heizung();
            geraet.Lueftersteuerung();


            // Console.WriteLine($"Soll wert Klimasteuergerät in {Klimasteuergeraet.sollWert}C");
            // Console.WriteLine($"Ist wert Klimasteuergerät in {istWert}C");
            //

        }
    }
}