using System;
using System.Text;

namespace ConsoleKata_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("i love pizza! für emojis in console ausgeben -> https://emojipedia.org/grinning-face\n");

            string nameBoileplate = 
                """
                Max Mustermann 
                Musterstraße 1
                12345 Musterstadt
                """;

            Console.WriteLine(nameBoileplate);
            Console.WriteLine();

            Console.WriteLine("Da hat wohl \n irgendjemand in \n\t Word ein\n\t\t Bild zu viel\n verschoben!");
            Console.WriteLine();

            Console.WriteLine("Künstlerische Darstellung eines Smiley: 😀 \\(^.^)/");
        }
    }
}
