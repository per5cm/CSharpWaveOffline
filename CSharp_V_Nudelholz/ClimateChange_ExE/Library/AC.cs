namespace ClimateChange_ExE.Library;

public class Ac
{
    internal double TargetSum { get; set; }
    internal  double CurrentSum { get; set; }
    internal double OutsideSum { get; set; }
    internal bool AcAktive { get; set; }
    private Level Level { get; set; }

    internal Ac(double targetSum, double currentSum, double outsideSum,  bool acAktive)
    {
        TargetSum = targetSum;
        CurrentSum = currentSum;
        OutsideSum = outsideSum;
        AcAktive = acAktive;
    }

    internal bool AcActivation()
    {
        if (TargetSum > CurrentSum)
        {
            Console.WriteLine("Es ist Kühl!");
            AcAktive = true;
            return true;
        }
        else if (TargetSum < CurrentSum)
        {
            Console.WriteLine("Es ist zu Heiss!");
            AcAktive = false;
            return false;
        }
        else
        {
            Console.WriteLine("Alles Ok!");
            AcAktive = false;
            return false;
        }
    }

    internal Level LevelControl()
    {
        if (CurrentSum >= 25)
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