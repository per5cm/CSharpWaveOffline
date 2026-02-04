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
            if (match.Success && IsPruefzifferValid(input.Substring(input.Length - 1)))
                return true;
            else
                return false;
        }

        // Prüfziffern-Berechnung 
        // 1. Buchstabe in eine Zahl umwandeln 
        // 2. Multiplikation mit den Faktoren
        // 3. Quersumme bilden durch for-Schleife
        // 4. Modulus 10 der Quersumme bilden
        // 5. Prüfziffer vergleichen

        // Faktoren für die Multiplikation
        int[] faktoren = { 2, 1, 2, 5, 7, 1, 2, 1, 2, 1, 2, 1 };

        // Buchstaben-Zahlen Zuordnung
        Dictionary<char, int> buchstabenZuZahlen = new Dictionary<char, int>()
        {
            {'A', 01}, {'B', 02}, {'C', 03}, {'D', 04}, {'E', 05},
            {'F', 06}, {'G', 07}, {'H', 08}, {'I', 09}, {'J', 10},
            {'K', 11}, {'L', 12}, {'M', 13}, {'N', 14}, {'O', 15},
            {'P', 16}, {'Q', 17}, {'R', 18}, {'S', 19}, {'T', 20},
            {'U', 21}, {'V', 22}, {'W', 23}, {'X', 24}, {'Y', 25},
            {'Z', 26}
        };

        private static bool IsPruefzifferValid(string value)
        {
            return true;
        }

        // Buchstabe in Zahl umwandeln
        public int BuchstabeZuZahl(char v)
        {
            if (buchstabenZuZahlen.ContainsKey(v))
                return buchstabenZuZahlen[v]; // Ausgabe Zahlenwert, wenn passt
            else
                throw new ArgumentException("Ungültiger Buchstabe");
        }

        // Multiplikation mit Faktoren
        public int[] MultiplikationFaktoren(string input)
        // input ist ein einzelnens Zeichen aus der SV-Nummer
        {
            int[] ergebnis = new int[12];

            for (int i = 0; i < 12; i++)
            {
                // input[i] ist in diesem Fall ein Char (mit einem Char kann keine mathematische
                // Berechnung angestellt werden, deswegen ToString() in eine Zahl...
                bool parseErfolgreich = int.TryParse(input[i].ToString(), out int zahlAlsInt);

                if (parseErfolgreich == false)
                {
                    // bool gibt true oder false zurück
                    // parseErfolgreich gibt True zurück, wenn das parsen erfolgreich war und da was 
                    // sinnvolles drinsteht, gibt 

                    // parseErfolgreich = false, war nicht erfolgreich und enthält "Quatsch"
                    // dann muss der Buchstabe in eine Zahl umgewandelt werden
                    ergebnis[i] = faktoren[i] * BuchstabeZuZahl(input[i]);
                }
                else
                {
                    ergebnis[i] = faktoren[i] * zahlAlsInt;
                }
            }
            return ergebnis;
        }
    }
}