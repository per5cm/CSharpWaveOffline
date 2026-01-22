using System.Text.RegularExpressions;

namespace SvNr
{
    public class SvNrValidator
    {
        // valid sv ex. 12 150485 M 003
        private static readonly Regex SvFormat =
            new(@"^\d{2}\s\d{6}\s[A-Z]\s\d{3}$", RegexOptions.Compiled);

        public static bool IsValidFormat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = Regex.Replace(input.Trim(), @"\s+", " ");
            input = input.ToUpperInvariant();

            return SvFormat.IsMatch(input);
        }
    }
}
