using System.Text;
using System.Text.RegularExpressions;

namespace Slugify;

    public class Detail
    {
        public string Slug(string input)
        {
        //return "pulp-fiction-von-quentin-tarantino";

            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            input = input.Trim().ToLower(); ;

            input = input.Replace("ä", "ae")
                         .Replace("ö", "oe")
                         .Replace("ü", "ue")
                         .Replace("ẞ", "ss");

            return input;
        }
    }
