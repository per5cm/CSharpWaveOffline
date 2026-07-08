namespace ClimateChange_ExE.Library;

public class Ac
{
    internal double TargetTemp { get; set; }
    internal  double CurrentTemp { get; set; }
    internal bool AcActive { get; private set; }
    private Level CurrentLevel { get; set; }

    internal Ac(double targetTemp, double currentTemp, bool acActive)
    {
        TargetTemp = targetTemp;
        CurrentTemp = currentTemp;
        AcActive = acActive;
    }

    internal bool AcActivation()
    {
        if (CurrentTemp < TargetTemp)
        {
            Console.WriteLine("Es ist Kühl!");
            AcActive = true;
            return true;
        }
        else if (CurrentTemp > TargetTemp)
        {
            Console.WriteLine("Es ist zu Heiss!");
            AcActive = true;
            return true;
        }
        else
        {
            Console.WriteLine("Alles Ok!");
            AcActive = false;
            return false;
        }
    }

    internal Level LevelControl()
    {
        if (CurrentTemp >= 32)
        {
            Console.WriteLine("Lufterstufe 3");
            CurrentLevel = Level.Strong;
        }
        else if (CurrentTemp >= 25)
        {
            Console.WriteLine("Lufterstufe 2");
            CurrentLevel = Level.Middle;
        }
        else if (CurrentTemp >= 10)
        {
            Console.WriteLine("Lufterstufe 1");
            CurrentLevel = Level.Light;
        }
        else
        {
            Console.WriteLine("Lufter aus!");
            CurrentLevel = Level.Off;
        }

        return CurrentLevel;
    }
}