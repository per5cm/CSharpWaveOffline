using System.Diagnostics;

namespace EnumsAmpel_ExE_1.Library;

public class Ampel
{
    internal AmpelPhase AktuellePhase { get; private set; }
    internal int SchaltZeit { get; private set; }

    internal Ampel(AmpelPhase ampelPhase, int schaltZeit)
    {
        SchaltZeit = schaltZeit;
        AktuellePhase = ampelPhase;
    }

    internal void WechselPhase()
    {
        switch (AktuellePhase)
        {
            case AmpelPhase.Grün:
                AktuellePhase = AmpelPhase.Gelb; break;
            case AmpelPhase.Gelb:
                AktuellePhase = AmpelPhase.Rot; break;
            case AmpelPhase.Rot:
                AktuellePhase = AmpelPhase.RotGelb; break;
            case AmpelPhase.RotGelb:
                AktuellePhase = AmpelPhase.Grün; break;
        }
    }
}