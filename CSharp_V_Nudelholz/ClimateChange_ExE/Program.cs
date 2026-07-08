using ClimateChange_ExE.Library;

namespace ClimateChange_ExE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klimasteuergerät gestartet");
            
            Ac machine = new(targetTemp: 21.5, currentTemp: 16.5, acActive: false);
            machine.AcActivation();
            machine.LevelControl();


            Console.WriteLine($"\nSoll wert Klimasteuergerät: {machine.TargetTemp}C");
            Console.WriteLine($"Ist wert Klimasteuergerät: {machine.CurrentTemp}C");
        }
    }
}