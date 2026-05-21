namespace Interfaces.Library;

public class Bicycle : IVehicle
{
    public string Name { get; }

    public Bicycle(string name)
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"{Name} Fahrrad ist fahrbereit.");
    }
}