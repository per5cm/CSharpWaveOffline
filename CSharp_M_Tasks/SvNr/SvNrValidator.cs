using System.Text.RegularExpressions;

namespace SvNr
{
    public class SvNrValidator
    {
        // valid sv ex. 12 150485 M 003
        // see regex format rules
        private static readonly Regex SvFormat =
        new(@"^\d{2}\s\d{6}\s[A-Z]\s\d{3}$", RegexOptions.Compiled);

        public static bool IsValidFormat(string input)
        {
            // checks for null or empty string
            if (string.IsNullOrWhiteSpace(input))
                return false;

            // trims double spaces with regex and converts lower case letter to upper case
            input = Regex.Replace(input.Trim(), @"\s+", " ");
            input = input.ToUpperInvariant();

            return SvFormat.IsMatch(input);
        }
    }
}
