using System.Text;
using System.Text.RegularExpressions;

class CustomRegex
{
    public bool PatternMatching(string pattern, string tergetString) {
        // string pattern = MakePattern(patternString);
        
        Regex regex = new Regex(pattern);
        return regex.IsMatch(tergetString);
    }
    public static string MakePattern(string s)
    {
        StringBuilder pattern = new StringBuilder();

        foreach (char c in s)
        {
            if (c == 'A' || c == 'a')
            {
                pattern.Append("(?:[Aa4])?");
            }
            else if (c == 'B' || c == 'b')
            {
                pattern.Append("(?:[Bb8])");
            }
            else if (c == 'D' || c == 'd')
            {
                pattern.Append("(?:[Dd])");
            }
            else if (c == 'E' || c == 'e')
            {
                pattern.Append("(?:[Ee3])?");
            }
            else if (c == 'I' || c == 'i')
            {
                pattern.Append("(?:[Ii1])?");
            }
            else if (c == 'U' || c == 'u')
            {
                pattern.Append("(?:[Uu])?");
            }
            else if (c == 'O' || c == 'o')
            {
                pattern.Append("(?:[Oo0])?");
            }
            else if (c == 'R' || c == 'r')
            {
                pattern.Append("(?:[Rr]|12)");
            }
            else if (c == 'G' || c == 'g')
            {
                pattern.Append("(?:[Gg]|6)");
            }
            else if (c == 'T' || c == 't')
            {
                pattern.Append("(?:[Tt7])");
            }
            else if (c == 'S' || c == 's')
            {
                pattern.Append("(?:[Ss5])");
            }
            else
            {
                pattern.Append($"[{char.ToLower(c)}{char.ToUpper(c)}]");
            }
        }

        return pattern.ToString();
    }
}