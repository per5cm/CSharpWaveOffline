using System.Text.RegularExpressions;

namespace SvNr_2
{
    public class SV
    {
        /* Schreibe eine Funktion, die eine SV-Nummmer
          anhand der Nummer selbst und aller benötigter Infos
          zuverlässig als valide oder invalide identifiziert
          
         -- SV-NR. Zusammensetzung:
         1.-2. Rentenversicherungsträger 
         3.-8. Geburtsdatum ohne "-" und Bei Geb. nur letzten 2 Ziffern)
         9.    Geburtsname 1. Buchstabe
         10.-11. für männliche oder weibliche Person
         12.   Prüfziffer (Modulus 10)
         */
        public bool IstGueltig(string input)
        {
            Match match = Regex.Match(input, @"\d{2}(?!3[0-1]02)(0[1-9]|[12][0-9]|3[01])(0[1-9]|1[0-2])\d{2}[A-Z]\d{2}\d");
            if (match.Success && IsPruefzifferGueltig(input.Substring(input.Length-1)))
                return true;
            else
                return false;
        }

        private static bool IsPruefzifferGueltig(string value)
        {
            return true;
        }
    }
}
