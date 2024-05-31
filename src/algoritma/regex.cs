using System.Text;
using System.Text.RegularExpressions;

class Program
{
    // static void Main()
    // {
    //     string targetString = "Bintang Dwi Marthen";
    //     string pattern = MakePattern(targetString);

    //     // Compile the regex pattern
    //     Regex regex = new Regex(pattern);

    //     // Test strings
    //     string[] testStrings = {
    //         "bintanG DwI mArthen",       // Should match
    //         "B1nt4n6 Dw1 M4rthen",
    //         "Bntng Dw Mrthen",
    //         "b1ntN6 Dw mrthn"
    //     };

    //     // Test the pattern
    //     foreach (string testString in testStrings)
    //     {
    //         if (regex.IsMatch(testString))
    //         {
    //             Console.WriteLine($"'{testString}' matches the pattern");
    //         }
    //         else
    //         {
    //             Console.WriteLine($"'{testString}' does NOT match the pattern");
    //         }
    //     }
    // }

    static string MakePattern(string s)
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
                pattern.Append("(?:[Bb]|13)");
            }
            else if (c == 'D' || c == 'd')
            {
                pattern.Append("(?:[Dd]|17)");
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
                pattern.Append("(?:[Oo])?");
            }
            else if (c == 'R' || c == 'r')
            {
                pattern.Append("(?:[Rr]|12)");
            }
            else if (c == 'G' || c == 'g')
            {
                pattern.Append("(?:[Gg]|6)");
            }
            else
            {
                pattern.Append($"[{char.ToLower(c)}{char.ToUpper(c)}]");
            }
        }

        return pattern.ToString();
    }
}