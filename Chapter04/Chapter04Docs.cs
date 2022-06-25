using System;

public class Chapter04Docs
{
    public Chapter04Docs()
    {

    }
    /// <summary>
    /// Pass a 32-bit integer and convert it to its ordinal counterpart (1 = 1st, 2 = 2nd, etc.)
    /// </summary>
    /// <param name="number">Number is the cardinal integer (1, 2, 3, etc.)</param>
    /// <returns>string representing the ordinal value (1st, 2nd, 3rd, etc. 11-13 are designated special cases)</returns>
    public string CardinalToOrdinal(int number)
    {
        switch (number)
        {
            case 11: // special cases for 11th - 13th
            case 12:
            case 13:
                return $"{number}th";
            default:
                int lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number}{suffix}";
        }
    }

}
