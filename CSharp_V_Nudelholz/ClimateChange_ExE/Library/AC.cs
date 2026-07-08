namespace ClimateChange_ExE.Library;

public class Ac
{
    internal double TargetSum { get; set; }
    internal  double CurrentSum { get; set; }
    internal double OutsideSum { get; set; }
    internal bool AcActive { get; private set; }
    private Level Level { get; set; }

    internal Ac(double targetSum, double currentSum, double outsideSum,  bool acActive)
    {
        TargetSum = targetSum;
        CurrentSum = currentSum;
        OutsideSum = outsideSum;
        AcActive = acActive;
    }

    internal bool AcActivation()
    {
        if (CurrentSum < TargetSum)
        {
            Console.WriteLine("Es ist Kühl!");
            AcActive = true;
            return true;
        }
        else if (CurrentSum > TargetSum)
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
        if (CurrentSum <= 32)
        {
            Console.WriteLine("Lufterstufe 3");
            Level = Level.Strong;
        }
        else if (CurrentSum >= 25)
        {
            Console.WriteLine("Lufterstufe 2");
            Level = Level.Middle;
        }
        else if (CurrentSum >= 10)
        {
            Console.WriteLine("Lufterstufe 1");
            Level = Level.Light;
        }
        else
        {
            Console.WriteLine("Lufter aus!");
            Level = Level.Off;
        }

        return Level;
    }
}