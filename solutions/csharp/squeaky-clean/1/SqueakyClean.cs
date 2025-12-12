using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();

        bool makeNextUpper = false;

        foreach (char c in identifier)
        {
            // 1. Space -> underscore
            if (c == ' ')
            {
                result.Append('_');
                continue;
            }

            // 2. Control characters -> "CTRL"
            if (char.IsControl(c))
            {
                result.Append("CTRL");
                continue;
            }

            // 3. Kebab-case: '-' means capitalize next letter
            if (c == '-')
            {
                makeNextUpper = true;
                continue;
            }

            // 4. Skip non-letters
            if (!char.IsLetter(c))
            {
                continue;
            }

            // 5. Skip Greek lowercase α..ω
            if (c >= 'α' && c <= 'ω')
            {
                continue;
            }

            // Apply camelCase conversion after '-'
            if (makeNextUpper)
            {
                result.Append(char.ToUpperInvariant(c));
                makeNextUpper = false;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}