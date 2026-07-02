using ClimateChange_ExE.Library;

namespace ClimateChange_ExE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klimasteuergerät gestartet");
            
            Ac machine = new(targetSum: 21.5, currentSum: 16.5, outsideSum: 13, acActive: false);
            machine.AcActivation();
            machine.LevelControl();


            Console.WriteLine($"\nSoll wert Klimasteuergerät: {machine.TargetSum}C");
            Console.WriteLine($"Ist wert Klimasteuergerät: {machine.CurrentSum}C");
        }
    }
}