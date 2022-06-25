using static System.Console;

//TimesTable(25);

//decimal taxToPay = CalculateTax(11500, "CH");
//WriteLine($"You must pay {taxToPay:C} in tax.");

//RunCardinalToOrdinal();

//RunFactorial();

RunFibImperative();

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");

    for (int row = 0; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}

//takes two parameters: Amount of money spent and two letter code to determine region's tax rate. Returns rate x amount spent
static decimal CalculateTax(decimal amount, string TwoLetterRegionCode)
{
    decimal rate = 0.0M;

    switch (TwoLetterRegionCode)
    {
        case "CH": //Switzerland
            rate = 0.08M;
            break;
        case "DK": //Denmark
        case "NO": //Norway
            rate = 0.25M;
            break;
        case "GB": //Great Britain
        case "FR": //France
            rate = 0.2M;
            break;
        case "HU": //Hungary
            rate = 0.27M;
            break;
        case "OR": //Oregon
        case "AK": //Arkansas
        case "MT": //Montana
            rate = 0.0M;
            break;
        case "ND": //North Dakota
        case "WI": //Wisconsin
        case "ME": //Maine
        case "VA": //Virginia
            rate = 0.05M;
            break;
        case "CA": //California
            rate = 0825M;
            break;
        default: //most US states
            rate = 0.06M;
            break;
    }
    return amount * rate;
}

/// <summary>
/// Pass a 32-bit integer and convert it to its ordinal counterpart (1 = 1st, 2 = 2nd, etc.)
/// </summary>
/// <param name="number">Number is the cardinal integer (1, 2, 3, etc.)</param>
/// <returns>string representing the ordinal value (1st, 2nd, 3rd, etc. 11-13 are designated special cases)</returns>
static string CardinalToOrdinal(int number)
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

static void RunCardinalToOrdinal()
{
    for (int i = 1; i <= 40; i++)
    {
        WriteLine($"{CardinalToOrdinal(i)}");

    }
}

//use recursion to calculate value of a factorial
static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
}

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (OverflowException)
        {
            WriteLine("Too big to calculate");
        }
    }
}

static int FibImperative(int term)
{
    if (term == 1) { return 0; }
    else if (term == 2) { return 1; }
    else return FibImperative(term - 1) + FibImperative(term - 2);
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} in the Fibbonaci Sequence is {1:N0}", CardinalToOrdinal(i), FibFunctional(i));
    }
}

static int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };
