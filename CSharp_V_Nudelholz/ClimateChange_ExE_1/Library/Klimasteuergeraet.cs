namespace ClimateChange_ExE_1.Library;

public class Klimasteuergeraet
{
    // private readonly double _sollWert;
    // private readonly double _istWert;
    // private readonly double _aussenTemparatur;

    private double SollWert { get; set; }
    private  double IstWert { get; set; }
    internal double AussenWert { get; set; }
    internal bool HeizungAktiv { get; set; }
    internal int Luefterstufe { get; set; }

    internal Klimasteuergeraet(double sollWert, double istWert, double aussenWert,  bool heizungAktiv, int luefterstufe)
    {
        SollWert = sollWert;
        IstWert = istWert;
        AussenWert = aussenWert;
        HeizungAktiv = heizungAktiv;
        Luefterstufe = luefterstufe;
    }

    internal bool Heizung()
    {
        if (SollWert > IstWert)
        {
            Console.WriteLine("Es ist Kühl!");
            return true;
        }
        else if (SollWert < IstWert)
        {
            Console.WriteLine("Es ist zu Heiss!");
            return false;
        }
        else
        {
            Console.WriteLine("Alles Ok!");
            return false;
        }
    }

    internal int Lueftersteuerung()
    {
        if (IstWert >= 25)
        {
            Console.WriteLine("Lufterstufe 3");
            return Luefterstufe = 2;
        }
        else if (IstWert >= 10)
        {
            Console.WriteLine("Lufterstufe 1");
            return Luefterstufe = 1;
        }
        else
        {
            Console.WriteLine("Lufter aus!");
            return Luefterstufe = 0;
        }
    }
}