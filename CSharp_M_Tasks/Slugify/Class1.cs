using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Slugify;

    public class SlugifyRegex
    {
    public string Slug(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        input = input.ToLowerInvariant();

        // replace German special characters
        input = input.Replace("ä", "ae")
                     .Replace("ö", "oe")
                     .Replace("ü", "ue")
                     .Replace("ß", "ss");

        // remove diacritics
        input = RemoveDiacritics(input);

        // turn anything not a - z, 0-9, sapce and hypphen to nothing
        input = Regex.Replace(input, @"[^a-z0-9\s-]", "");
        input = Regex.Replace(input, @"\s+", "-");
        // collapse multiple dashes and trim edges.
        input = Regex.Replace(input, @"-+", "-").Trim('-');

        return input;
    }
    private static string RemoveDiacritics(string text)
    {
        var normalized = text.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder(normalized.Length);

        foreach (var c in normalized)
        {
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}

