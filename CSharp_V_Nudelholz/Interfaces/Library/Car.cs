namespace Interfaces.Library;

public class Car : IVehicle, IFuel
{
    public string Name { get; }

    public Car(string name)
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"{Name} Auto startet den Motor...");
    }

    public void Refuel()
    {
        Console.WriteLine($"{Name} wird betankt...");
    }
}